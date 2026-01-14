-- Script thêm nhiều suất chiếu cho các phim
-- Mỗi phim sẽ có nhiều ca khác nhau ở nhiều ngày

USE [MovieTicketDB]
GO

-- Xóa các suất chiếu cũ (nếu muốn reset) - BỎ COMMENT nếu cần
-- DELETE FROM ShowTimeSeat WHERE ShowTimeID > 10
-- DELETE FROM ShowTime WHERE ShowTimeID > 10

-- ========================================
-- THÊM SUẤT CHIẾU CHO AVENGERS: ENDGAME (MovieID = 1)
-- ========================================
-- Ngày 14/12/2025
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 2, '2025-12-14', '10:00:00', 85000, 1)  -- Hà Nội, Phòng 2
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 3, '2025-12-14', '14:00:00', 90000, 1)  -- Hà Nội, Phòng 3
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 4, '2025-12-14', '19:00:00', 100000, 1) -- Hà Nội, Phòng 4
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 5, '2025-12-14', '21:00:00', 100000, 2) -- HCM, Phòng 1

-- Ngày 15/12/2025
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 1, '2025-12-15', '08:00:00', 75000, 1)  -- Hà Nội
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 2, '2025-12-15', '11:00:00', 85000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 3, '2025-12-15', '15:00:00', 90000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 4, '2025-12-15', '18:00:00', 100000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 5, '2025-12-15', '20:30:00', 100000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 6, '2025-12-15', '22:00:00', 110000, 2)

-- Ngày 16/12/2025
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 1, '2025-12-16', '09:00:00', 75000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 2, '2025-12-16', '13:00:00', 85000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (1, 9, '2025-12-16', '16:00:00', 90000, 3)  -- Đà Nẵng

-- ========================================
-- THÊM SUẤT CHIẾU CHO SPIDER-MAN: NO WAY HOME (MovieID = 2)
-- ========================================
-- Ngày 14/12/2025
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 1, '2025-12-14', '09:30:00', 85000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 2, '2025-12-14', '12:00:00', 85000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 3, '2025-12-14', '15:30:00', 90000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 4, '2025-12-14', '19:00:00', 100000, 1)

-- Ngày 15/12/2025
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 1, '2025-12-15', '08:30:00', 75000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 2, '2025-12-15', '11:30:00', 85000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 6, '2025-12-15', '14:00:00', 90000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 7, '2025-12-15', '17:30:00', 100000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 8, '2025-12-15', '20:00:00', 100000, 2)

-- Ngày 16/12/2025
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 9, '2025-12-16', '10:00:00', 85000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 10, '2025-12-16', '14:00:00', 90000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (2, 11, '2025-12-16', '18:00:00', 100000, 3)

-- ========================================
-- THÊM SUẤT CHIẾU CHO CON NHÓT MÓT CHỒNG (MovieID = 5)
-- ========================================
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (5, 1, '2025-12-14', '08:00:00', 75000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (5, 2, '2025-12-14', '10:30:00', 80000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (5, 3, '2025-12-14', '14:00:00', 85000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (5, 4, '2025-12-14', '17:00:00', 90000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (5, 1, '2025-12-14', '20:00:00', 100000, 1)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (5, 5, '2025-12-15', '09:00:00', 75000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (5, 6, '2025-12-15', '12:00:00', 85000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (5, 7, '2025-12-15', '15:30:00', 90000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (5, 8, '2025-12-15', '19:00:00', 100000, 2)

-- ========================================
-- THÊM SUẤT CHIẾU CHO IT CHAPTER TWO (MovieID = 8)
-- ========================================
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 2, '2025-12-14', '09:00:00', 85000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 3, '2025-12-14', '13:00:00', 90000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 2, '2025-12-14', '21:00:00', 100000, 1)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 5, '2025-12-15', '10:00:00', 85000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 6, '2025-12-15', '14:30:00', 90000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 7, '2025-12-15', '19:00:00', 100000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 8, '2025-12-15', '22:00:00', 110000, 2)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 9, '2025-12-16', '11:00:00', 85000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 10, '2025-12-16', '15:00:00', 90000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (8, 11, '2025-12-16', '20:00:00', 100000, 3)

-- ========================================
-- THÊM SUẤT CHIẾU CHO BỐ GIÀ (MovieID = 17)
-- ========================================
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 1, '2025-12-14', '08:30:00', 75000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 2, '2025-12-14', '11:00:00', 85000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 3, '2025-12-14', '14:30:00', 90000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 4, '2025-12-14', '18:00:00', 100000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 1, '2025-12-14', '21:00:00', 100000, 1)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 5, '2025-12-15', '09:30:00', 80000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 6, '2025-12-15', '13:00:00', 85000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 7, '2025-12-15', '16:30:00', 90000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 8, '2025-12-15', '20:00:00', 100000, 2)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 13, '2025-12-16', '10:00:00', 85000, 4)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 14, '2025-12-16', '14:00:00', 90000, 4)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (17, 15, '2025-12-16', '18:30:00', 100000, 4)

-- ========================================
-- THÊM SUẤT CHIẾU CHO AVATAR (MovieID = 16)
-- ========================================
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 2, '2025-12-14', '08:00:00', 80000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 3, '2025-12-14', '11:30:00', 90000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 4, '2025-12-14', '15:00:00', 95000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 2, '2025-12-14', '18:30:00', 100000, 1)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 5, '2025-12-15', '09:00:00', 85000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 6, '2025-12-15', '12:30:00', 90000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 7, '2025-12-15', '16:00:00', 95000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 8, '2025-12-15', '19:30:00', 100000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 5, '2025-12-15', '22:30:00', 110000, 2)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 9, '2025-12-16', '10:30:00', 85000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 10, '2025-12-16', '14:30:00', 95000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (16, 11, '2025-12-16', '18:00:00', 100000, 3)

-- ========================================
-- THÊM SUẤT CHIẾU CHO JOHN WICK 4 (MovieID = 3)
-- ========================================
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (3, 1, '2025-12-14', '10:00:00', 90000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (3, 2, '2025-12-14', '14:00:00', 95000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (3, 3, '2025-12-14', '18:00:00', 100000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (3, 4, '2025-12-14', '21:30:00', 110000, 1)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (3, 5, '2025-12-15', '11:00:00', 90000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (3, 6, '2025-12-15', '15:00:00', 95000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (3, 7, '2025-12-15', '19:00:00', 100000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (3, 8, '2025-12-15', '22:30:00', 110000, 2)

-- ========================================
-- THÊM SUẤT CHIẾU CHO DORAEMON (MovieID = 4)
-- ========================================
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 1, '2025-12-14', '08:00:00', 65000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 2, '2025-12-14', '10:00:00', 70000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 3, '2025-12-14', '14:00:00', 75000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 4, '2025-12-14', '16:30:00', 80000, 1)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 5, '2025-12-15', '08:30:00', 65000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 6, '2025-12-15', '10:30:00', 70000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 7, '2025-12-15', '14:30:00', 75000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 8, '2025-12-15', '17:00:00', 80000, 2)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 9, '2025-12-16', '09:00:00', 65000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 10, '2025-12-16', '11:00:00', 70000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (4, 11, '2025-12-16', '15:00:00', 75000, 3)

-- ========================================
-- THÊM SUẤT CHIẾU CHO AQUAMAN (MovieID = 6)
-- ========================================
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (6, 1, '2025-12-14', '09:30:00', 85000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (6, 2, '2025-12-14', '13:00:00', 90000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (6, 3, '2025-12-14', '16:30:00', 95000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (6, 4, '2025-12-14', '20:00:00', 100000, 1)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (6, 5, '2025-12-15', '10:00:00', 85000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (6, 6, '2025-12-15', '13:30:00', 90000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (6, 7, '2025-12-15', '17:00:00', 95000, 2)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (6, 8, '2025-12-15', '20:30:00', 100000, 2)

-- ========================================
-- THÊM SUẤT CHIẾU CHO FAST & FURIOUS 10 (MovieID = 7)
-- ========================================
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 1, '2025-12-14', '11:00:00', 90000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 2, '2025-12-14', '14:30:00', 95000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 3, '2025-12-14', '18:00:00', 100000, 1)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 4, '2025-12-14', '21:00:00', 105000, 1)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 9, '2025-12-15', '10:30:00', 90000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 10, '2025-12-15', '14:00:00', 95000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 11, '2025-12-15', '17:30:00', 100000, 3)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 12, '2025-12-15', '21:00:00', 105000, 3)

INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 13, '2025-12-16', '11:00:00', 90000, 4)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 14, '2025-12-16', '15:00:00', 95000, 4)
INSERT INTO [ShowTime] ([MovieID], [RoomID], [ShowDate], [ShowTime], [TicketPrice], [LocationID]) 
VALUES (7, 15, '2025-12-16', '19:00:00', 100000, 4)

PRINT N'Đã thêm thành công các suất chiếu mới!'
GO
