using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYGIAOVIEN
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
        }

        private void btGiaoVien_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new GUI_GiaoVien());
        }

    

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLuong(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new GUI_LuongGV());

        }

        private void btnTDHV_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new GUI_TrinhDoHocVan());
        }

        private void btnChuyennganh_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new GUI_ChuyenNganh());
        }

        private void btnDanhgia_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new GUI_DanhGia());

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            flogin login = new flogin();
            login.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DoiMatKhau DMK = new DoiMatKhau();
            DMK.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new GUI.GUI_ChiTietGiangDay());
        }
    }
}
