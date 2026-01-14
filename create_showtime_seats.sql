-- =====================================================
-- SCRIPT TẠO SƠ ĐỒ GHẾ CHO CÁC SUẤT CHIẾU MỚI
-- =====================================================
-- Mỗi suất chiếu cần có bản ghi ShowTimeSeat riêng

USE [MovieTicketDB]
GO

-- =====================================================
-- STORED PROCEDURE: Tự động tạo ghế cho 1 suất chiếu
-- =====================================================
-- Procedure này sẽ tự động tạo tất cả ghế cho 1 ShowTime
-- dựa trên RoomID của suất chiếu đó

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_CreateSeatsForShowTime')
    DROP PROCEDURE sp_CreateSeatsForShowTime
GO

CREATE PROCEDURE sp_CreateSeatsForShowTime
    @ShowTimeID INT
AS
BEGIN
    DECLARE @RoomID INT
    
    -- Lấy RoomID của suất chiếu
    SELECT @RoomID = RoomID FROM ShowTime WHERE ShowTimeID = @ShowTimeID
    
    IF @RoomID IS NULL
    BEGIN
        PRINT N'Không tìm thấy ShowTime với ID: ' + CAST(@ShowTimeID AS VARCHAR)
        RETURN
    END
    
    -- Kiểm tra xem đã có ghế cho suất chiếu này chưa
    IF EXISTS (SELECT 1 FROM ShowTimeSeat WHERE ShowTimeID = @ShowTimeID)
    BEGIN
        PRINT N'Suất chiếu ' + CAST(@ShowTimeID AS VARCHAR) + N' đã có sơ đồ ghế!'
        RETURN
    END
    
    -- Tạo ghế cho suất chiếu từ bảng Seat của Room tương ứng
    INSERT INTO ShowTimeSeat (ShowTimeID, SeatID, Status)
    SELECT @ShowTimeID, SeatID, 'available'
    FROM Seat
    WHERE RoomID = @RoomID
    
    PRINT N'Đã tạo sơ đồ ghế cho suất chiếu ' + CAST(@ShowTimeID AS VARCHAR) + 
          N' (Phòng ' + CAST(@RoomID AS VARCHAR) + N')'
END
GO

-- =====================================================
-- STORED PROCEDURE: Tạo ghế cho TẤT CẢ suất chiếu chưa có
-- =====================================================
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_CreateSeatsForAllShowTimes')
    DROP PROCEDURE sp_CreateSeatsForAllShowTimes
GO

CREATE PROCEDURE sp_CreateSeatsForAllShowTimes
AS
BEGIN
    DECLARE @ShowTimeID INT
    DECLARE @Count INT = 0
    
    -- Cursor để duyệt qua tất cả ShowTime chưa có ghế
    DECLARE showtime_cursor CURSOR FOR
    SELECT st.ShowTimeID 
    FROM ShowTime st
    WHERE NOT EXISTS (SELECT 1 FROM ShowTimeSeat sts WHERE sts.ShowTimeID = st.ShowTimeID)
    
    OPEN showtime_cursor
    FETCH NEXT FROM showtime_cursor INTO @ShowTimeID
    
    WHILE @@FETCH_STATUS = 0
    BEGIN
        EXEC sp_CreateSeatsForShowTime @ShowTimeID
        SET @Count = @Count + 1
        FETCH NEXT FROM showtime_cursor INTO @ShowTimeID
    END
    
    CLOSE showtime_cursor
    DEALLOCATE showtime_cursor
    
    PRINT N'=== Đã tạo sơ đồ ghế cho ' + CAST(@Count AS VARCHAR) + N' suất chiếu ==='
END
GO

-- =====================================================
-- CHẠY: Tạo ghế cho tất cả suất chiếu hiện có chưa có ghế
-- =====================================================
EXEC sp_CreateSeatsForAllShowTimes
GO

-- =====================================================
-- TRIGGER: Tự động tạo ghế khi thêm suất chiếu mới
-- =====================================================
-- Trigger này sẽ TỰ ĐỘNG tạo sơ đồ ghế mỗi khi INSERT vào ShowTime

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_CreateSeatsOnShowTimeInsert')
    DROP TRIGGER trg_CreateSeatsOnShowTimeInsert
GO

CREATE TRIGGER trg_CreateSeatsOnShowTimeInsert
ON ShowTime
AFTER INSERT
AS
BEGIN
    -- Tạo ghế cho mỗi suất chiếu vừa được thêm
    INSERT INTO ShowTimeSeat (ShowTimeID, SeatID, Status)
    SELECT i.ShowTimeID, s.SeatID, 'available'
    FROM inserted i
    INNER JOIN Seat s ON s.RoomID = i.RoomID
END
GO

PRINT N'=== ĐÃ TẠO XONG TRIGGER VÀ STORED PROCEDURES ==='
PRINT N'Từ giờ mỗi khi thêm ShowTime mới, ghế sẽ được tự động tạo!'
GO

-- =====================================================
-- VÍ DỤ: Thêm suất chiếu mới (ghế sẽ tự động được tạo)
-- =====================================================
/*
-- Thêm 1 suất chiếu mới cho phim Avengers (MovieID=1)
INSERT INTO ShowTime (MovieID, RoomID, ShowDate, ShowTime, TicketPrice, LocationID)
VALUES (1, 1, '2025-12-17', '20:00:00', 100000, 1)

-- Ghế sẽ TỰ ĐỘNG được tạo nhờ Trigger!
-- Kiểm tra:
SELECT * FROM ShowTimeSeat WHERE ShowTimeID = (SELECT MAX(ShowTimeID) FROM ShowTime)
*/

-- =====================================================
-- KIỂM TRA: Xem số ghế của mỗi suất chiếu
-- =====================================================
SELECT 
    st.ShowTimeID,
    m.Title AS MovieTitle,
    r.RoomName,
    st.ShowDate,
    st.ShowTime,
    COUNT(sts.ShowTimeSeatID) AS TotalSeats,
    SUM(CASE WHEN sts.Status = 'available' THEN 1 ELSE 0 END) AS AvailableSeats,
    SUM(CASE WHEN sts.Status = 'booked' THEN 1 ELSE 0 END) AS BookedSeats
FROM ShowTime st
LEFT JOIN ShowTimeSeat sts ON st.ShowTimeID = sts.ShowTimeID
LEFT JOIN Movie m ON st.MovieID = m.MovieID
LEFT JOIN Room r ON st.RoomID = r.RoomID
GROUP BY st.ShowTimeID, m.Title, r.RoomName, st.ShowDate, st.ShowTime
ORDER BY st.ShowTimeID
GO
