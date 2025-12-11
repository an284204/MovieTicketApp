using System;
using System.Data;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Bosstk : UserControl
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        public Bosstk()
        {
            InitializeComponent();
        }

        private void Bosstk_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadRoles();
        }

        private void LoadAccounts()
        {
            dgvAccounts.DataSource = db.GetAllAccounts();
            if (dgvAccounts.Columns["MatKhau"] != null)
            {
                dgvAccounts.Columns["MatKhau"].Visible = false;
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
            }
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccounts.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtPassword.Text = row.Cells["MatKhau"].Value.ToString();
                txtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cbEditRole.SelectedItem = row.Cells["RoleName"].Value.ToString();
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

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            int roleId = db.GetRoleIdByName(roleName);
            db.InsertAccount(hoTen, ngaySinh, email, sdt, password, roleId);

            MessageBox.Show("Thêm tài khoản thành công!");
            LoadAccounts();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvAccounts.SelectedRows[0].Cells["UserID"].Value);
                db.DeleteAccount(userId);

                MessageBox.Show("Xóa tài khoản thành công!");
                LoadAccounts();
            }
        }

        private void btnSuaRole_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvAccounts.SelectedRows[0].Cells["UserID"].Value);
                string newRole = cbEditRole.SelectedItem.ToString();
                int roleId = db.GetRoleIdByName(newRole);

                db.UpdateAccountRole(userId, roleId);

                MessageBox.Show("Cập nhật Role thành công!");
                LoadAccounts();
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e) { }
        private void txtNgaySinh_ValueChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void cbEditRole_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}