using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace MovieTicketApp
{
    public partial class TestFoodVoucher : UserControl
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private int _currentHoaDonId = -1;
        private int _statusChuaDung = -1;
        private int _statusDaDung = -1;
        private int _statusChuaThanhToan = -1;
        private int _statusHetHan = -1;

        public TestFoodVoucher()
        {
            InitializeComponent();
            InitializeGrid();
            ClearInfo();
        }

        private void InitializeGrid()
        {
            gridMonAn.AutoGenerateColumns = false;
            gridMonAn.Columns.Clear();

            gridMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTenMon",
                HeaderText = "Tên món",
                DataPropertyName = "FoodName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 180,
                ReadOnly = true
            });

            gridMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSoLuong",
                HeaderText = "Số lượng",
                DataPropertyName = "SoLuong",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = true
            });

            gridMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDonGia",
                HeaderText = "Đơn giá",
                DataPropertyName = "DonGia",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = true
            });

            gridMonAn.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colThanhTien",
                HeaderText = "Thành tiền",
                DataPropertyName = "ThanhTien",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = true
            });

            gridMonAn.CellFormatting += gridMonAn_CellFormatting;
        }

        private void gridMonAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = gridMonAn.Columns[e.ColumnIndex].Name;
            if ((columnName == "colDonGia" || columnName == "colThanhTien") && e.Value != null && e.Value != DBNull.Value)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:N0} đ", value);
                    e.FormattingApplied = true;
                }
            }
        }

        private void EnsureStatusCache()
        {
            if (_statusChuaDung < 0)
                _statusChuaDung = _db.GetTrangThaiId("Chưa Sử Dụng");
            if (_statusDaDung < 0)
                _statusDaDung = _db.GetTrangThaiId("Đã Sử Dụng");
            if (_statusChuaThanhToan < 0)
                _statusChuaThanhToan = _db.GetTrangThaiId("Chưa Thanh Toán");
            if (_statusHetHan < 0)
                _statusHetHan = _db.GetTrangThaiId("Quá Hạn");
        }

        private void ClearInfo()
        {
            lblMaHoaDonValue.Text = "---";
            lblKhachHangValue.Text = "---";
            lblSoDienThoaiValue.Text = "---";
            lblNgayLapValue.Text = "---";
            lblDiaDiemValue.Text = "---";
            lblTongTienValue.Text = "---";
            lblTrangThaiValue.Text = "Chưa kiểm tra";
            lblTrangThaiValue.ForeColor = Color.Gray;
            panelTrangThai.FillColor = Color.FromArgb(245, 245, 245);
            panelTrangThai.BackColor = Color.FromArgb(245, 245, 245);
            gridMonAn.DataSource = null;
            _currentHoaDonId = -1;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string raw = txtMaHoaDon.Text.Trim();
            if (string.IsNullOrEmpty(raw))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(raw, out int hoaDonId))
            {
                MessageBox.Show("Mã hóa đơn chỉ được chứa số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadInvoice(hoaDonId, true);
        }

        private bool LoadInvoice(int hoaDonId, bool showMessageWhenNotFound)
        {
            var result = _db.GetFoodInvoiceById(hoaDonId);
            if (result.header.Rows.Count == 0)
            {
                if (showMessageWhenNotFound)
                {
                    MessageBox.Show("Không tìm thấy phiếu đồ ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearInfo();
                return false;
            }

            ApplyInvoiceData(result.header.Rows[0], result.details);
            return true;
        }

        private void ApplyInvoiceData(DataRow info, DataTable details)
        {
            _currentHoaDonId = Convert.ToInt32(info["HoaDonID"]);

            lblMaHoaDonValue.Text = _currentHoaDonId.ToString();
            lblKhachHangValue.Text = string.IsNullOrWhiteSpace(info["HoTen"]?.ToString()) ? "---" : info["HoTen"].ToString();
            lblSoDienThoaiValue.Text = string.IsNullOrWhiteSpace(info["SoDienThoai"]?.ToString()) ? "---" : info["SoDienThoai"].ToString();
            lblDiaDiemValue.Text = string.IsNullOrWhiteSpace(info["LocationName"]?.ToString()) ? "Chưa cập nhật" : info["LocationName"].ToString();
            lblTongTienValue.Text = FormatCurrency(info["TongTien"]);

            if (info["NgayLap"] == DBNull.Value)
            {
                lblNgayLapValue.Text = "---";
            }
            else
            {
                DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                lblNgayLapValue.Text = ngayLap.ToString("dd/MM/yyyy HH:mm");
            }

            gridMonAn.DataSource = details;

            int statusId = info["TrangThaiID"] == DBNull.Value ? -1 : Convert.ToInt32(info["TrangThaiID"]);
            UpdateStatusBadge(statusId);
        }

        private string FormatCurrency(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return "---";
            }

            if (decimal.TryParse(value.ToString(), out decimal money))
            {
                return string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:N0} đ", money);
            }

            return "---";
        }

        private void UpdateStatusBadge(int trangThaiId)
        {
            EnsureStatusCache();

            if (trangThaiId == _statusChuaDung)
            {
                lblTrangThaiValue.Text = "PHIẾU HỢP LỆ - CHƯA ĐỔI";
                lblTrangThaiValue.ForeColor = Color.FromArgb(34, 197, 94);
                panelTrangThai.FillColor = Color.FromArgb(220, 252, 231);
                panelTrangThai.BackColor = Color.FromArgb(220, 252, 231);
            }
            else if (trangThaiId == _statusDaDung)
            {
                lblTrangThaiValue.Text = "PHIẾU ĐÃ ĐƯỢC ĐỔI";
                lblTrangThaiValue.ForeColor = Color.FromArgb(59, 130, 246);
                panelTrangThai.FillColor = Color.FromArgb(219, 234, 254);
                panelTrangThai.BackColor = Color.FromArgb(219, 234, 254);
            }
            else if (trangThaiId == _statusChuaThanhToan)
            {
                lblTrangThaiValue.Text = "CHƯA THANH TOÁN";
                lblTrangThaiValue.ForeColor = Color.FromArgb(156, 163, 175);
                panelTrangThai.FillColor = Color.FromArgb(243, 244, 246);
                panelTrangThai.BackColor = Color.FromArgb(243, 244, 246);
            }
            else if (trangThaiId == _statusHetHan)
            {
                lblTrangThaiValue.Text = "PHIẾU ĐÃ HẾT HẠN";
                lblTrangThaiValue.ForeColor = Color.FromArgb(234, 179, 8);
                panelTrangThai.FillColor = Color.FromArgb(254, 249, 195);
                panelTrangThai.BackColor = Color.FromArgb(254, 249, 195);
            }
            else
            {
                lblTrangThaiValue.Text = "TRẠNG THÁI KHÔNG XÁC ĐỊNH";
                lblTrangThaiValue.ForeColor = Color.FromArgb(249, 115, 22);
                panelTrangThai.FillColor = Color.FromArgb(255, 237, 213);
                panelTrangThai.BackColor = Color.FromArgb(255, 237, 213);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (_currentHoaDonId <= 0)
            {
                MessageBox.Show("Vui lòng kiểm tra phiếu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var currentData = _db.GetFoodInvoiceById(_currentHoaDonId);
            if (currentData.header.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu để xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearInfo();
                return;
            }

            EnsureStatusCache();
            DataRow info = currentData.header.Rows[0];
            int trangThaiId = info["TrangThaiID"] == DBNull.Value ? -1 : Convert.ToInt32(info["TrangThaiID"]);

            if (trangThaiId != _statusChuaDung)
            {
                MessageBox.Show("Phiếu này không ở trạng thái 'Chưa dùng'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _db.UpdateHoaDonStatus(_currentHoaDonId, _statusDaDung);
                MessageBox.Show("Đã xác nhận phiếu đồ ăn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var refreshed = _db.GetFoodInvoiceById(_currentHoaDonId);
                if (refreshed.header.Rows.Count > 0)
                {
                    ApplyInvoiceData(refreshed.header.Rows[0], refreshed.details);
                }
                else
                {
                    ClearInfo();
                }

                DialogResult export = MessageBox.Show("Bạn có muốn in phiếu đồ ăn không?", "Xuất Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (export == DialogResult.Yes && refreshed.header.Rows.Count > 0)
                {
                    ExportInvoiceToExcel(refreshed.header.Rows[0], refreshed.details);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportInvoiceToExcel(DataRow headerRow, DataTable details)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("PhieuDoAn");

                    worksheet.Cell("A1").Value = "PHIẾU XÁC NHẬN ĐỒ ĂN";
                    worksheet.Range("A1:D1").Merge().Style
                        .Font.SetBold(true)
                        .Font.SetFontSize(16)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    worksheet.Cell("A3").Value = "Mã hóa đơn:";
                    worksheet.Cell("B3").Value = headerRow["HoaDonID"].ToString();

                    worksheet.Cell("A4").Value = "Khách hàng:";
                    worksheet.Cell("B4").Value = headerRow["HoTen"].ToString();

                    worksheet.Cell("A5").Value = "Số điện thoại:";
                    worksheet.Cell("B5").Value = headerRow["SoDienThoai"].ToString();

                    worksheet.Cell("A6").Value = "Ngày lập:";
                    worksheet.Cell("B6").Value = headerRow["NgayLap"] == DBNull.Value
                        ? "---"
                        : Convert.ToDateTime(headerRow["NgayLap"]).ToString("dd/MM/yyyy HH:mm:ss");

                    worksheet.Cell("A7").Value = "Địa điểm:";
                    worksheet.Cell("B7").Value = headerRow["LocationName"].ToString();

                    worksheet.Cell("A8").Value = "Tổng tiền:";
                    worksheet.Cell("B8").Value = FormatCurrency(headerRow["TongTien"]);

                    worksheet.Cell("A9").Value = "Trạng thái:";
                    worksheet.Cell("B9").Value = headerRow["TenTrangThai"]?.ToString() ?? "---";

                    worksheet.Cell("A11").Value = "Danh sách món";
                    worksheet.Cell("A11").Style.Font.SetBold(true);

                    worksheet.Cell("A12").Value = "Tên món";
                    worksheet.Cell("B12").Value = "Số lượng";
                    worksheet.Cell("C12").Value = "Đơn giá";
                    worksheet.Cell("D12").Value = "Thành tiền";
                    worksheet.Range("A12:D12").Style
                        .Font.SetBold(true)
                        .Fill.SetBackgroundColor(XLColor.FromArgb(241, 245, 249));

                    int row = 13;
                    foreach (DataRow detail in details.Rows)
                    {
                        worksheet.Cell(row, 1).Value = detail["FoodName"].ToString();
                        worksheet.Cell(row, 2).Value = detail["SoLuong"] == DBNull.Value
                            ? 0
                            : Convert.ToInt32(detail["SoLuong"]);
                        worksheet.Cell(row, 3).Value = detail["DonGia"] == DBNull.Value
                            ? 0m
                            : Convert.ToDecimal(detail["DonGia"]);
                        worksheet.Cell(row, 4).Value = detail["ThanhTien"] == DBNull.Value
                            ? 0m
                            : Convert.ToDecimal(detail["ThanhTien"]);
                        row++;
                    }

                    worksheet.Columns("A:D").AdjustToContents();

                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Files|*.xlsx";
                        sfd.Title = "Lưu phiếu đồ ăn";
                        sfd.FileName = $"PhieuDoAn_{headerRow["HoaDonID"]}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Đã xuất phiếu đồ ăn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
