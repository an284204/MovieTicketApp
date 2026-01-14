using System;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class VerifyCodeForm : Form
    {
        private readonly RegisterForm.PendingRegistration _pending;
        private readonly string _expectedCode;

        public VerifyCodeForm(RegisterForm.PendingRegistration pending, string expectedCode)
        {
            InitializeComponent();
            _pending = pending;
            _expectedCode = expectedCode;
            lblInfo.Text = $"Nhập mã xác thực đã gửi tới {pending.Email}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            if (code != _expectedCode)
            {
                MessageBox.Show("Mã xác thực chưa đúng.");
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                // Kiểm tra email có tồn tại không trước khi tạo tài khoản
                if (db.CheckEmailExists(_pending.Email))
                {
                    MessageBox.Show("Email này đã được đăng ký. Vui lòng dùng email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.InsertAccount(
                    _pending.HoTen,
                    _pending.Dob,
                    _pending.Email,
                    _pending.Phone,
                    _pending.Password,
                    1 // default role: user
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo tài khoản: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
