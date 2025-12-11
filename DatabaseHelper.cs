using MovieTicketApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieTicketApp
{
    internal class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper()
        { 
            connectionString = "Server=LAPTOP-B4J6DCSQ;Database=MovieTicketDB;Integrated Security=True;";
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
        }
        public (int userId, int roleId, string hoTen, string email, string soDienThoai) CheckLogin(string input, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT UserID, RoleID, HoTen, Email, SoDienThoai
            FROM Users
            WHERE (Email = @Input OR SoDienThoai = @Input) AND MatKhau = @MatKhau";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Input", input);
                cmd.Parameters.AddWithValue("@MatKhau", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["UserID"]);
                    int roleId = Convert.ToInt32(reader["RoleID"]);
                    string hoTen = reader["HoTen"].ToString();
                    string email = reader["Email"].ToString();
                    string soDienThoai = reader["SoDienThoai"].ToString();

                    return (userId, roleId, hoTen, email, soDienThoai);
                }
                else
                {
                    return (-1, -1, null, null, null);
                }
            }
        }
        public void SaveMessage(int senderId, int receiverId, string message)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ChatMessages (SenderId, ReceiverId, Message) VALUES (@s, @r, @m)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@s", senderId);
                cmd.Parameters.AddWithValue("@r", receiverId);
                cmd.Parameters.AddWithValue("@m", message);
                cmd.ExecuteNonQuery();
            }
        }
        // Dùng cho chat chung (ReceiverId)
        public List<ChatMessage> GetMessagesByReceiver(int receiverId)
        {
            var messages = new List<ChatMessage>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SenderId, ReceiverId, Message, SentTime FROM Messages WHERE ReceiverId = @r ORDER BY SentTime ASC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@r", receiverId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            messages.Add(new ChatMessage
                            {
                                SenderId = reader.GetInt32(0),
                                ReceiverId = reader.GetInt32(1),
                                Message = reader.GetString(2),
                                SentTime = reader.GetDateTime(3)
                            });
                        }
                    }
                }
            }
            return messages;
        }
        // Dùng cho chat riêng (giữa staff và customer)
        public List<ChatMessage> GetMessagesWithCustomer(int customerId)
        {
            var messages = new List<ChatMessage>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT SenderId, ReceiverId, Message, SentTime  
                         FROM ChatMessages  
                         WHERE (SenderId = @c OR ReceiverId = @c)  
                         ORDER BY SentTime";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@c", customerId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    messages.Add(new ChatMessage
                    {
                        SenderId = (int)reader["SenderId"],
                        ReceiverId = (int)reader["ReceiverId"],
                        Message = reader["Message"].ToString(),
                        SentTime = (DateTime)reader["SentTime"]
                    });
                }
            }
            return messages;
        }
        public List<(int UserId, string HoTen)> GetCustomers()
        {
            var list = new List<(int, string)>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserID, HoTen FROM Users WHERE RoleID = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(((int)reader["UserID"], reader["HoTen"].ToString()));
                }
            }
            return list;
        }
        // Lấy danh sách Roles
        public DataTable GetRoles()
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT RoleID, RoleName FROM Roles";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int GetRoleIdByName(string roleName)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT RoleID FROM Roles WHERE RoleName=@RoleName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoleName", roleName);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
        public DataTable GetMovies()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MovieID, Title, Duration, Poster, Description, Genre FROM Movie";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public void InsertMovie(string title, int duration, string poster, string description, string genre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Movie (Title, Duration, Poster, Description, Genre) 
                         VALUES (@title, @duration, @poster, @description, @genre)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@poster", poster);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@genre", genre);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateMovie(int movieId, string title, int duration, string poster, string description, string genre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Movie 
                         SET Title=@title, Duration=@duration, Poster=@poster, Description=@description, Genre=@genre 
                         WHERE MovieID=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", movieId);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@poster", poster);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@genre", genre);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMovie(int movieId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Movie WHERE MovieID=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", movieId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetFood()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT FoodID, Name, Price, Stock, ImageURL, TitleFood FROM Food";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public bool InsertFood(string name, int price, string imageUrl, string titleFood, string description)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Food (Name, Price, Stock, ImageURL, Status, TitleFood)
                         VALUES (@Name, @Price, @Stock, @ImageURL, @Status, @TitleFood)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Stock", 50); // mặc định 50
                cmd.Parameters.AddWithValue("@ImageURL", imageUrl);
                cmd.Parameters.AddWithValue("@Status", true);
                cmd.Parameters.AddWithValue("@TitleFood", titleFood);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
        public DataTable GetLocation()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT LocationID, LocationName FROM Location";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public string GetLocationName(int showTimeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT L.LocationName
            FROM ShowTime ST
            JOIN Location L ON ST.LocationID = L.LocationID
            WHERE ST.ShowTimeID = @ShowTimeID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowTimeID", showTimeId);

                object result = cmd.ExecuteScalar();
                return result == null ? string.Empty : result.ToString();
            }
        }
        public DateTime GetShowDate(int showTimeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ShowDate FROM ShowTime WHERE ShowTimeID = @ShowTimeID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowTimeID", showTimeId);

                object result = cmd.ExecuteScalar();
                return result == null ? DateTime.Now : Convert.ToDateTime(result);
            }
        }
        public DataTable GetShowTimesByMovie(string movieTitle)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT ST.ShowTimeID, ST.ShowDate, ST.ShowTime, L.LocationName
            FROM ShowTime ST
            INNER JOIN Movie M ON ST.MovieID = M.MovieID
            INNER JOIN Location L ON ST.LocationID = L.LocationID
            WHERE M.Title = @Title
            ORDER BY ST.ShowDate, ST.ShowTime";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", movieTitle);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetSeatsByShowTime(int showTimeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT S.SeatCode, S.IsDouble, STS.Status
            FROM Seat S
            INNER JOIN ShowTimeSeat STS ON S.SeatID = STS.SeatID
            WHERE STS.ShowTimeID = @ShowTimeID
            ORDER BY S.SeatCode";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowTimeID", showTimeId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int GetTicketPrice(int showTimeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TicketPrice FROM ShowTime WHERE ShowTimeID = @ShowTimeID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowTimeID", showTimeId);

                object result = cmd.ExecuteScalar();
                return result == null ? 75000 : Convert.ToInt32(result);
            }
        }

        public int UpdateSeatStatus(int showTimeId, string seatCode, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            UPDATE STS
            SET Status = @Status
            FROM ShowTimeSeat STS
            INNER JOIN Seat S ON STS.SeatID = S.SeatID
            WHERE STS.ShowTimeID = @ShowTimeID AND S.SeatCode = @SeatCode";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ShowTimeID", showTimeId);
                cmd.Parameters.AddWithValue("@SeatCode", seatCode);
                cmd.Parameters.AddWithValue("@Status", status);

                return cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetMoviesWithShowTime()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT M.MovieID, M.Title, M.Duration, M.Poster, M.Description, M.Genre,
                   ST.ShowTimeID, L.LocationName
            FROM Movie M
            JOIN ShowTime ST ON M.MovieID = ST.MovieID
            JOIN Location L ON ST.LocationID = L.LocationID
            WHERE L.LocationName IS NOT NULL";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetRooms()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomID, RoomName, LocationID FROM Room";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetRoomsByLocation(int locationId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomID, RoomName FROM Room WHERE LocationID=@LocationID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LocationID", locationId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable GetShowTimes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT ST.ShowTimeID, M.Title AS MovieTitle, R.RoomName, L.LocationName,
                   ST.ShowDate, ST.ShowTime, ST.TicketPrice
            FROM ShowTime ST
            INNER JOIN Movie M ON ST.MovieID = M.MovieID
            INNER JOIN Room R ON ST.RoomID = R.RoomID
            INNER JOIN Location L ON ST.LocationID = L.LocationID
            ORDER BY ST.ShowDate, ST.ShowTime";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public void InsertShowTime(int movieId, int roomId, int locationId, DateTime showDate, string showTime, decimal ticketPrice)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO ShowTime (MovieID, RoomID, LocationID, ShowDate, ShowTime, TicketPrice)
                         VALUES (@MovieID, @RoomID, @LocationID, @ShowDate, @ShowTime, @TicketPrice)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MovieID", movieId);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@LocationID", locationId);
                    cmd.Parameters.AddWithValue("@ShowDate", showDate);
                    cmd.Parameters.AddWithValue("@ShowTime", showTime);
                    cmd.Parameters.AddWithValue("@TicketPrice", ticketPrice);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateShowTime(int showTimeId, int movieId, int roomId, int locationId, DateTime showDate, string showTime, decimal ticketPrice)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE ShowTime
                         SET MovieID=@MovieID, RoomID=@RoomID, LocationID=@LocationID,
                             ShowDate=@ShowDate, ShowTime=@ShowTime, TicketPrice=@TicketPrice
                         WHERE ShowTimeID=@ShowTimeID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ShowTimeID", showTimeId);
                    cmd.Parameters.AddWithValue("@MovieID", movieId);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@LocationID", locationId);
                    cmd.Parameters.AddWithValue("@ShowDate", showDate);
                    cmd.Parameters.AddWithValue("@ShowTime", showTime);
                    cmd.Parameters.AddWithValue("@TicketPrice", ticketPrice);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteShowTime(int showTimeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ShowTime WHERE ShowTimeID=@ShowTimeID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ShowTimeID", showTimeId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetHoaDonVe(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT h.HoaDonID, h.NgayLap, h.TongTien,
               m.Title AS MovieTitle, t.MaVe, s.SeatCode, st.ShowDate, st.ShowTime, cv.Gia,
               tt.TenTrangThai, tt.ColorCode
        FROM HoaDon h
        JOIN ChiTietHoaDonVe cv ON h.HoaDonID = cv.HoaDonID
        JOIN Ticket t ON cv.TicketID = t.TicketID
        JOIN Seat s ON t.SeatID = s.SeatID
        JOIN ShowTime st ON t.ShowTimeID = st.ShowTimeID
        JOIN Movie m ON st.MovieID = m.MovieID
        JOIN TrangThai tt ON h.TrangThaiID = tt.TrangThaiID
        WHERE h.LoaiHoaDon = 'Ve' AND h.UserID = @UserID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetHoaDonDoAn(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT h.HoaDonID, h.NgayLap, h.TongTien,
               f.Name AS FoodName, cd.SoLuong, cd.Gia,
               tt.TenTrangThai, tt.ColorCode
        FROM HoaDon h
        JOIN ChiTietHoaDonDoAn cd ON h.HoaDonID = cd.HoaDonID
        JOIN Food f ON cd.FoodID = f.FoodID
        JOIN TrangThai tt ON h.TrangThaiID = tt.TrangThaiID
        WHERE h.LoaiHoaDon = 'DoAn' AND h.UserID = @UserID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int InsertHoaDon(int userId, int tongTien, string loaiHoaDon, int trangThaiId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                INSERT INTO HoaDon (UserID, TongTien, LoaiHoaDon, TrangThaiID)
                OUTPUT INSERTED.HoaDonID
                VALUES (@UserID, @TongTien, @LoaiHoaDon, @TrangThaiID)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@TongTien", tongTien);
                cmd.Parameters.AddWithValue("@LoaiHoaDon", loaiHoaDon);
                cmd.Parameters.AddWithValue("@TrangThaiID", trangThaiId);
                return (int)cmd.ExecuteScalar();
            }
        }

        public int InsertTicket(int hoaDonId, int showTimeId, string seatCode, string maVe, int trangThaiId = 1)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
        DECLARE @Inserted TABLE (TicketID INT);

        INSERT INTO Ticket (HoaDonID, ShowTimeID, SeatID, MaVe, TrangThaiID)
        OUTPUT INSERTED.TicketID INTO @Inserted
        SELECT @HoaDonID, @ShowTimeID, S.SeatID, @MaVe, @TrangThaiID
        FROM Seat S
        JOIN ShowTime ST ON ST.RoomID = S.RoomID
        WHERE S.SeatCode = @SeatCode AND ST.ShowTimeID = @ShowTimeID;

        SELECT TicketID FROM @Inserted;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonId);
                cmd.Parameters.AddWithValue("@ShowTimeID", showTimeId);
                cmd.Parameters.AddWithValue("@SeatCode", seatCode);
                cmd.Parameters.AddWithValue("@MaVe", maVe);
                cmd.Parameters.AddWithValue("@TrangThaiID", trangThaiId);

                object result = cmd.ExecuteScalar();
                return result == null ? -1 : Convert.ToInt32(result);
            }
        }

        public void InsertChiTietHoaDonVe(int hoaDonId, int ticketId, int gia)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            INSERT INTO ChiTietHoaDonVe (HoaDonID, TicketID, Gia)
            VALUES (@HoaDonID, @TicketID, @Gia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonId);
                cmd.Parameters.AddWithValue("@TicketID", ticketId);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.ExecuteNonQuery();
            }
        }
        public void InsertChiTietHoaDonDoAn(int hoaDonId, string tenMon, int soLuong, int gia)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            INSERT INTO ChiTietHoaDonDoAn (HoaDonID, FoodID, SoLuong, Gia)
            SELECT @HoaDonID, FoodID, @SoLuong, @Gia
            FROM Food WHERE Name = @TenMon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonId);
                cmd.Parameters.AddWithValue("@TenMon", tenMon);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.ExecuteNonQuery();
            }
        }
        public int GetTrangThaiId(string tenTrangThai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TrangThaiID FROM TrangThai WHERE TenTrangThai = @TenTrangThai";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenTrangThai", tenTrangThai);
                object result = cmd.ExecuteScalar();
                return result == null ? -1 : Convert.ToInt32(result);
            }
        }
        public void UpdateHoaDonStatus(int hoaDonId, int trangThaiId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE HoaDon SET TrangThaiID = @TrangThaiID WHERE HoaDonID = @HoaDonID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrangThaiID", trangThaiId);
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonId);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateTicketStatus(int ticketId, int trangThaiId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Ticket SET TrangThaiID = @TrangThaiID WHERE TicketID = @TicketID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrangThaiID", trangThaiId);
                cmd.Parameters.AddWithValue("@TicketID", ticketId);
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertAccount(string hoTen, DateTime ngaySinh, string email, string sdt, string password, int roleId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"INSERT INTO Users(HoTen, NgaySinh, Email, SoDienThoai, MatKhau, RoleID) 
                         VALUES(@HoTen, @NgaySinh, @Email, @SDT, @MatKhau, @RoleID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                cmd.Parameters.AddWithValue("@RoleID", roleId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAccount(int userId, string hoTen, DateTime ngaySinh, string email, string sdt, string password, int roleId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"UPDATE Users 
                         SET HoTen=@HoTen, NgaySinh=@NgaySinh, Email=@Email, 
                             SoDienThoai=@SDT, MatKhau=@MatKhau, RoleID=@RoleID
                         WHERE UserID=@UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                cmd.Parameters.AddWithValue("@RoleID", roleId);
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAccount(int userId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "DELETE FROM Users WHERE UserID=@UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAccountRole(int userId, int roleId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE Users SET RoleID=@RoleID WHERE UserID=@UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoleID", roleId);
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetAccountsByRole(string roleName)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"SELECT u.UserID, u.HoTen, u.NgaySinh, u.Email, u.SoDienThoai, u.MatKhau, r.RoleName
                         FROM Users u
                         JOIN Roles r ON u.RoleID = r.RoleID
                         WHERE r.RoleName = @RoleName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoleName", roleName);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetAllAccounts()
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"SELECT u.UserID, u.HoTen, u.NgaySinh, u.Email, u.SoDienThoai, u.MatKhau, r.RoleName
                         FROM Users u
                         JOIN Roles r ON u.RoleID = r.RoleID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public DataTable GetTopHotMovies(int topCount)
        {
            string query = @"
        SELECT TOP (@TopCount) m.MovieID, m.Title, m.Poster, COUNT(t.TicketID) AS TotalTickets
        FROM Ticket t
        INNER JOIN ShowTime s ON t.ShowTimeID = s.ShowTimeID
        INNER JOIN Movie m ON s.MovieID = m.MovieID
        GROUP BY m.MovieID, m.Title, m.Poster
        ORDER BY TotalTickets DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TopCount", topCount);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}