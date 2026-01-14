using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace MovieTicketApp
{
    public partial class TestTicket : UserControl
    {
        private int currentTicketId = -1;

        public TestTicket()
        {
            InitializeComponent();
            ClearTicketInfo();
        }

        private void ClearTicketInfo()
        {
            lblPhimValue.Text = "---";
            lblNgayValue.Text = "---";
            lblGioValue.Text = "---";
            lblPhongValue.Text = "---";
            lblRapValue.Text = "---";
            lblGheValue.Text = "---";
            lblTrangThaiValue.Text = "Chưa kiểm tra";
            lblTrangThaiValue.ForeColor = Color.Gray;
            panelTrangThai.FillColor = Color.FromArgb(245, 245, 245);
            panelTrangThai.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string maVe = txtMaVe.Text.Trim();
            if (string.IsNullOrEmpty(maVe))
            {
                MessageBox.Show("Vui lòng nhập mã vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DataTable ticketInfo = db.GetTicketByCode(maVe);

                if (ticketInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    currentTicketId = -1;
                    ClearTicketInfo();
                    return;
                }

                DataRow row = ticketInfo.Rows[0];
                lblPhimValue.Text = row["Title"].ToString();
                lblNgayValue.Text = Convert.ToDateTime(row["ShowDate"]).ToString("dd/MM/yyyy");
                lblGioValue.Text = row["ShowTime"].ToString();
                lblPhongValue.Text = row["RoomName"].ToString();
                lblRapValue.Text = row["LocationName"].ToString();
                lblGheValue.Text = row["SeatNumber"].ToString();

                currentTicketId = Convert.ToInt32(row["TicketID"]);

                int trangThaiId = Convert.ToInt32(row["TrangThaiID"]);
                int idChuaDung = db.GetTrangThaiId("Chưa Sử Dụng");
                int idDaDung = db.GetTrangThaiId("Đã Sử Dụng");
                int idHetHan = db.GetTrangThaiId("Quá Hạn");
                int idChuaTT = db.GetTrangThaiId("Chưa Thanh Toán");

                if (trangThaiId == idChuaDung)
                {
                    lblTrangThaiValue.Text = "VÉ HỢP LỆ - CHƯA SỬ DỤNG";
                    lblTrangThaiValue.ForeColor = Color.FromArgb(34, 197, 94);
                    panelTrangThai.FillColor = Color.FromArgb(220, 252, 231);
                    panelTrangThai.BackColor = Color.FromArgb(220, 252, 231);
                }
                else if (trangThaiId == idDaDung)
                {
                    lblTrangThaiValue.Text = "VÉ ĐÃ ĐƯỢC SỬ DỤNG";
                    lblTrangThaiValue.ForeColor = Color.FromArgb(239, 68, 68);
                    panelTrangThai.FillColor = Color.FromArgb(254, 226, 226);
                    panelTrangThai.BackColor = Color.FromArgb(254, 226, 226);
                }
                else if (trangThaiId == idHetHan)
                {
                    lblTrangThaiValue.Text = "VÉ ĐÃ HẾT HẠN";
                    lblTrangThaiValue.ForeColor = Color.FromArgb(234, 179, 8);
                    panelTrangThai.FillColor = Color.FromArgb(254, 249, 195);
                    panelTrangThai.BackColor = Color.FromArgb(254, 249, 195);
                }
                else if (trangThaiId == idChuaTT)
                {
                    lblTrangThaiValue.Text = "CHƯA THANH TOÁN";
                    lblTrangThaiValue.ForeColor = Color.FromArgb(156, 163, 175);
                    panelTrangThai.FillColor = Color.FromArgb(243, 244, 246);
                    panelTrangThai.BackColor = Color.FromArgb(243, 244, 246);
                }
                else
                {
                    lblTrangThaiValue.Text = "TRẠNG THÁI KHÔNG XÁC ĐỊNH";
                    lblTrangThaiValue.ForeColor = Color.FromArgb(249, 115, 22);
                    panelTrangThai.FillColor = Color.FromArgb(255, 237, 213);
                    panelTrangThai.BackColor = Color.FromArgb(255, 237, 213);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (currentTicketId <= 0)
            {
                MessageBox.Show("Vui lòng kiểm tra vé trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                DataTable ticketInfo = db.GetTicketByCode(txtMaVe.Text.Trim());
                if (ticketInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy vé để xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int trangThaiHienTai = Convert.ToInt32(ticketInfo.Rows[0]["TrangThaiID"]);
                int idChuaDung = db.GetTrangThaiId("Chưa Sử Dụng");
                int idDaDung = db.GetTrangThaiId("Đã Sử Dụng");

                if (trangThaiHienTai != idChuaDung)
                {
                    MessageBox.Show("Vé này đã được sử dụng hoặc không ở trạng thái 'Chưa dùng'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật trạng thái vé
                db.UpdateTicketStatus(currentTicketId, idDaDung);

                lblTrangThaiValue.Text = "XÁC NHẬN THÀNH CÔNG - ĐÃ SỬ DỤNG";
                lblTrangThaiValue.ForeColor = Color.FromArgb(59, 130, 246);
                panelTrangThai.FillColor = Color.FromArgb(219, 234, 254);
                panelTrangThai.BackColor = Color.FromArgb(219, 234, 254);

                MessageBox.Show("Vé đã được xác nhận thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult resultExcel = MessageBox.Show("Bạn có muốn in hóa đơn không?",
                                                           "Xuất Excel",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);

                if (resultExcel == DialogResult.Yes)
                {
                    ExportInvoiceToExcel(ticketInfo.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xác nhận vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportInvoiceToExcel(DataRow ticketRow)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Hóa đơn");

                    // Tiêu đề
                    worksheet.Cell("A1").Value = "HÓA ĐƠN XÁC NHẬN VÉ";
                    worksheet.Range("A1:B1").Merge().Style
                        .Font.SetBold(true)
                        .Font.SetFontSize(16)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    // Thông tin
                    worksheet.Cell("A3").Value = "Mã vé:";
                    worksheet.Cell("B3").Value = txtMaVe.Text.Trim();

                    worksheet.Cell("A4").Value = "Phim:";
                    worksheet.Cell("B4").Value = ticketRow["Title"].ToString();

                    worksheet.Cell("A5").Value = "Ngày chiếu:";
                    worksheet.Cell("B5").Value = Convert.ToDateTime(ticketRow["ShowDate"]).ToString("dd/MM/yyyy");

                    worksheet.Cell("A6").Value = "Giờ chiếu:";
                    worksheet.Cell("B6").Value = ticketRow["ShowTime"].ToString();

                    worksheet.Cell("A7").Value = "Phòng:";
                    worksheet.Cell("B7").Value = ticketRow["RoomName"].ToString();

                    worksheet.Cell("A8").Value = "Rạp:";
                    worksheet.Cell("B8").Value = ticketRow["LocationName"].ToString();

                    worksheet.Cell("A9").Value = "Ghế:";
                    worksheet.Cell("B9").Value = ticketRow["SeatNumber"].ToString();

                    worksheet.Cell("A10").Value = "Trạng thái:";
                    worksheet.Cell("B10").Value = "ĐÃ SỬ DỤNG";

                    worksheet.Cell("A12").Value = "Thời gian xác nhận:";
                    worksheet.Cell("B12").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    // Style
                    worksheet.Column("A").Width = 20;
                    worksheet.Column("B").Width = 35;
                    worksheet.Column("A").Style.Font.SetBold(true);

                    // Save
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Files|*.xlsx";
                        sfd.Title = "Lưu hóa đơn";
                        sfd.FileName = "HoaDon_" + txtMaVe.Text.Trim() + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Đã xuất hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
