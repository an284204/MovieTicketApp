using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class FrmGioHang : Form
    {
        private readonly int currentUserId; // giữ UserID
        private readonly List<(string TenMon, string Gia, int SoLuong)> gioHang;

        public FrmGioHang(int userId, List<(string TenMon, string Gia, int SoLuong)> gioHang)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.gioHang = gioHang;

            // Cấu hình DataGridView
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToDeleteRows = false;
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Thêm cột
            dgvGioHang.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "Chon", HeaderText = "" });
            dgvGioHang.Columns.Add("TenMon", "Tên món");
            dgvGioHang.Columns.Add("SoLuong", "Số lượng");
            dgvGioHang.Columns.Add("Gia", "Giá");
            dgvGioHang.Columns.Add("ThanhTien", "Thành tiền");

            // Load dữ liệu giỏ hàng
            foreach (var item in gioHang)
            {
                string giaStr = item.Gia.Replace(" VND", "").Replace(",", "").Replace(".", "").Trim();
                int gia = 0;
                int.TryParse(giaStr, out gia);

                int thanhTien = gia * item.SoLuong;
                dgvGioHang.Rows.Add(false, item.TenMon, item.SoLuong, gia, thanhTien);
            }

            // Gọi tính tổng ban đầu
            TinhTongTien();

            // Sự kiện chỉnh sửa số lượng
            dgvGioHang.CellEndEdit += (s, e) =>
            {
                if (e.ColumnIndex == dgvGioHang.Columns["SoLuong"].Index)
                {
                    var row = dgvGioHang.Rows[e.RowIndex];
                    if (int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out int soLuong))
                    {
                        if (int.TryParse(row.Cells["Gia"].Value?.ToString(), out int gia))
                        {
                            int thanhTien = soLuong * gia;
                            row.Cells["ThanhTien"].Value = thanhTien;
                            TinhTongTien();
                        }
                    }
                }
            };

            // Format hiển thị giá và thành tiền
            dgvGioHang.CellFormatting += (s, e) =>
            {
                if (dgvGioHang.Columns[e.ColumnIndex].Name == "Gia" ||
                    dgvGioHang.Columns[e.ColumnIndex].Name == "ThanhTien")
                {
                    if (e.Value != null && int.TryParse(e.Value.ToString(), out int val))
                    {
                        e.Value = val.ToString("N0") + " VND";
                        e.FormattingApplied = true;
                    }
                }
            };

            // Commit checkbox khi click
            dgvGioHang.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvGioHang.IsCurrentCellDirty)
                    dgvGioHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            // Khi checkbox thay đổi → tính tổng
            dgvGioHang.CellValueChanged += (s, e) =>
            {
                if (e.ColumnIndex == dgvGioHang.Columns["Chon"].Index)
                {
                    TinhTongTien();
                }
            };

            // Xử lý thanh toán
            //btnThanhToan.Click += (s, e) =>
            //{
            //    StringBuilder sb = new StringBuilder("Bạn đã thanh toán các sản phẩm:\n");
            //    List<string> daThanhToan = new List<string>();

            //    DatabaseHelper db = new DatabaseHelper();

            //    // 1. Lấy trạng thái ID cho hóa đơn mới
            //    int trangThaiId = db.GetTrangThaiId("Chua dung");

            //    // 2. Tạo hóa đơn mới với đúng UserID
            //    int hoaDonId = db.InsertHoaDon(currentUserId, TinhTongTienSo(), "DoAn", trangThaiId);

            //    // 3. Thêm chi tiết đồ ăn
            //    foreach (DataGridViewRow row in dgvGioHang.Rows)
            //    {
            //        bool chon = Convert.ToBoolean(row.Cells["Chon"].Value ?? false);
            //        if (chon)
            //        {
            //            string tenMon = row.Cells["TenMon"].Value.ToString();
            //            int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
            //            int gia = Convert.ToInt32(row.Cells["Gia"].Value);

            //            sb.AppendLine($"{tenMon} - SL: {soLuong} - {(soLuong * gia):N0} VND");
            //            daThanhToan.Add(tenMon);

            //            db.InsertChiTietHoaDonDoAn(hoaDonId, tenMon, soLuong, gia * soLuong);
            //        }
            //    }

            //    // 4. Hiển thị thông báo
            //    sb.AppendLine("\n" + lblTongTien.Text);
            //    MessageBox.Show(sb.ToString(), "Thanh toán thành công");

            //    // 5. Xóa các dòng đã chọn khỏi DataGridView
            //    foreach (DataGridViewRow row in dgvGioHang.Rows.Cast<DataGridViewRow>().ToList())
            //    {
            //        bool chon = Convert.ToBoolean(row.Cells["Chon"].Value ?? false);
            //        if (chon)
            //        {
            //            dgvGioHang.Rows.Remove(row);
            //        }
            //    }

            //    // 6. Trả về danh sách món đã thanh toán cho UC_DoAn
            //    this.Tag = daThanhToan;
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //};
            btnThanhToan.Click += (s, e) =>
            {
                // Kiểm tra có phần hàng được chọn
                bool coMonDuocChon = false;
                foreach (DataGridViewRow row in dgvGioHang.Rows)
                {
                    bool chon = Convert.ToBoolean(row.Cells["Chon"].Value ?? false);
                    if (chon)
                    {
                        coMonDuocChon = true;
                        break;
                    }
                }

                if (!coMonDuocChon)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất 1 món để thanh toán!");
                    return;
                }

                try
                {
                    DatabaseHelper db = new DatabaseHelper();

                    // 1. Lấy trạng thái ID cho hóa đơn mới
                    int trangThaiId = db.GetTrangThaiId("Chưa Thanh Toán");

                    // 2. Tạo hóa đơn mới với đúng UserID
                    decimal totalAmount = TinhTongTienSo();
                    int hoaDonId = db.InsertHoaDon(currentUserId, (int)totalAmount, "DoAn", trangThaiId);

                    // 3. Lấy danh sách đồ ăn được chọn
                    List<(string TenMon, int SoLuong, int Gia)> selectedFoods = new List<(string, int, int)>();
                    List<string> daThanhToan = new List<string>();

                    foreach (DataGridViewRow row in dgvGioHang.Rows)
                    {
                        bool chon = Convert.ToBoolean(row.Cells["Chon"].Value ?? false);
                        if (chon)
                        {
                            string tenMon = row.Cells["TenMon"].Value.ToString();
                            int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                            int gia = Convert.ToInt32(row.Cells["Gia"].Value);

                            selectedFoods.Add((tenMon, soLuong, gia));
                            daThanhToan.Add(tenMon);

                            // Thêm chi tiết đồ ăn vào database
                            db.InsertChiTietHoaDonDoAn(hoaDonId, tenMon, soLuong, gia * soLuong);
                        }
                    }

                    // 4. Mở FoodPaymentForm
                    FoodPaymentForm paymentForm = new FoodPaymentForm(
                        hoaDonId,
                        currentUserId,
                        totalAmount,
                        selectedFoods
                    );

                    DialogResult paymentResult = paymentForm.ShowDialog();

                    if (paymentResult == DialogResult.OK)
                    {
                        // Thanh toán thành công
                        MessageBox.Show("Thanh toán thành công! Đơn hàng của bạn đã được xác nhận.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Xóa các dòng đã chọn khỏi DataGridView
                        foreach (DataGridViewRow row in dgvGioHang.Rows.Cast<DataGridViewRow>().ToList())
                        {
                            bool chon = Convert.ToBoolean(row.Cells["Chon"].Value ?? false);
                            if (chon)
                            {
                                dgvGioHang.Rows.Remove(row);
                            }
                        }

                        // 6. Trả về danh sách món đã thanh toán cho UC_DoAn
                        this.Tag = daThanhToan;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        // Thanh toán bị hủy - xóa hóa đơn đã tạo
                        string deleteQuery = $"DELETE FROM ChiTietHoaDonDoAn WHERE HoaDonID = {hoaDonId}";
                        db.ExecuteNonQuery(deleteQuery);

                        string deleteInvoiceQuery = $"DELETE FROM HoaDon WHERE HoaDonID = {hoaDonId}";
                        db.ExecuteNonQuery(deleteInvoiceQuery);

                        MessageBox.Show("Thanh toán đã bị hủy.", "Hủy bỏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            };
        }

        private int TinhTongTienSo()
        {
            int tong = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                bool chon = Convert.ToBoolean(row.Cells["Chon"].Value ?? false);
                if (chon && int.TryParse(row.Cells["ThanhTien"].Value?.ToString(), out int thanhTien))
                {
                    tong += thanhTien;
                }
            }
            return tong;
        }

        private void TinhTongTien()
        {
            int tong = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                bool chon = Convert.ToBoolean(row.Cells["Chon"].Value ?? false);
                if (chon && int.TryParse(row.Cells["ThanhTien"].Value?.ToString(), out int thanhTien))
                {
                    tong += thanhTien;
                }
            }
            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VND";
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // đã xử lý bằng lambda trong constructor, nên có thể để trống
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}