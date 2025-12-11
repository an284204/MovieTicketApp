using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class UC_ItemDoAn : UserControl
    {
        public UC_ItemDoAn()
        {
            InitializeComponent();
        }

        public void SetData(string tenMon, string gia, Image hinh = null)
        {
            lblTenMon.Text = tenMon;
            lblGia.Text = gia;
            if (hinh != null)
                picMon.Image = hinh;
            else
                picMon.FillColor = Color.LightGray;
        }

        private void UC_ItemDoAn_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler<(string TenMon, string Gia)> OnThemMon;

        private void btnThem_Click(object sender, EventArgs e)
        {
            OnThemMon?.Invoke(this, (lblTenMon.Text, lblGia.Text));
        }
    }
}
