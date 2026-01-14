using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Bosstk : UserControl
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private const string BossRoleName = "Boss";

        public Bosstk()
        {
            InitializeComponent();
            SetFieldsEditable(true);
        }

        private void Bosstk_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadRoles();
        }

        private void LoadAccounts()
        {
            try
            {
                dgvAccounts.DataSource = db.GetAllAccounts();
                if (dgvAccounts.Columns["MatKhau"] != null)
                {
                    dgvAccounts.Columns["MatKhau"].Visible = false;
                }
                dgvAccounts.ClearSelection();
                ClearInputFields();
                SetFieldsEditable(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải tài khoản: " + ex.Message);
            }
        }

        private void LoadRoles()
        {
            cbEditRole.Items.Clear();
            cbFilterRole.Items.Clear();

            DataTable roles = db.GetRoles();
            cbFilterRole.Items.Add("Tất cả");

            foreach (DataRow row in roles.Rows)
            {
                string roleName = row["RoleName"].ToString();
                cbEditRole.Items.Add(roleName);
                cbFilterRole.Items.Add(roleName);
            }

            if (cbEditRole.Items.Count > 0) cbEditRole.SelectedIndex = 0;
            if (cbFilterRole.Items.Count > 0) cbFilterRole.SelectedIndex = 0;
        }

        private void cbFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cbFilterRole.SelectedItem.ToString();
            if (selectedRole == "Tất cả")
            {
                LoadAccounts();
            }
            else
            {
                dgvAccounts.DataSource = db.GetAccountsByRole(selectedRole);
                if (dgvAccounts.Columns["MatKhau"] != null)
                {
                    dgvAccounts.Columns["MatKhau"].Visible = false;
                }
                dgvAccounts.ClearSelection();
                ClearInputFields();
                SetFieldsEditable(true);
            }
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccounts.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? string.Empty;
                txtPassword.Text = row.Cells["MatKhau"].Value?.ToString() ?? string.Empty;

                if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ngaySinh))
                {
                    txtNgaySinh.Value = ngaySinh;
                }

                string roleName = row.Cells["RoleName"].Value?.ToString() ?? string.Empty;
                int roleIndex = cbEditRole.Items.IndexOf(roleName);
                if (roleIndex >= 0)
                {
                    cbEditRole.SelectedIndex = roleIndex;
                }

                SetFieldsEditable(!roleName.Equals(BossRoleName, StringComparison.OrdinalIgnoreCase));
            }
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
                btnTogglePassword.Text = "🙈";
            }
            else
            {
                txtPassword.PasswordChar = '●';
                btnTogglePassword.Text = "👁";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            DateTime ngaySinh = txtNgaySinh.Value;
            string email = txtEmail.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string password = txtPassword.Text.Trim();
            string roleName = cbEditRole.SelectedItem.ToString();

            // Kiểm tra bắt buộc
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Kiểm tra định dạng email
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            // Kiểm tra số điện thoại: từ 9 đến 11 số
            if (!Regex.IsMatch(sdt, @"^\d{9,11}$"))
            {
                MessageBox.Show("Số điện thoại phải từ 9 đến 11 chữ số!");
                return;
            }

            try
            {
                int roleId = db.GetRoleIdByName(roleName);
                db.InsertAccount(hoTen, ngaySinh, email, sdt, password, roleId);
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvAccounts.SelectedRows[0].Cells["UserID"].Value);

                var confirm = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?",
                                              "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        db.DeleteAccountSafe(userId);
                        MessageBox.Show("Xóa tài khoản thành công!");
                        LoadAccounts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message);
                    }
                }
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dgvAccounts.SelectedRows[0];
            string currentRole = selectedRow.Cells["RoleName"].Value?.ToString() ?? string.Empty;

            if (currentRole.Equals(BossRoleName, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Không thể sửa thông tin tài khoản Boss.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string password = txtPassword.Text.Trim();
            DateTime ngaySinh = txtNgaySinh.Value;

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Họ tên, email và mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(sdt, @"^\d{9,11}$"))
            {
                MessageBox.Show("Số điện thoại phải từ 9 đến 11 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEditRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn quyền hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roleId = db.GetRoleIdByName(cbEditRole.SelectedItem.ToString());
            int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

            try
            {
                db.UpdateAccount(userId, hoTen, ngaySinh, email, sdt, password, roleId);
                MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtHoTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtPassword.Text = string.Empty;
            if (cbEditRole.Items.Count > 0)
            {
                cbEditRole.SelectedIndex = 0;
            }
            txtNgaySinh.Value = DateTime.Today;
        }

        private void SetFieldsEditable(bool isEditable)
        {
            txtHoTen.ReadOnly = !isEditable;
            txtEmail.ReadOnly = !isEditable;
            txtSoDienThoai.ReadOnly = !isEditable;
            txtPassword.ReadOnly = !isEditable;
            txtNgaySinh.Enabled = isEditable;
            cbEditRole.Enabled = isEditable;
            btnSuaThongTin.Enabled = isEditable;
        }
    }
}