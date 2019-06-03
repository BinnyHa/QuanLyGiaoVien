using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYGIAOVIEN.GUI
{
    public partial class GUI_ChiTietGiangDay : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QuanLyGiaoVienTieuHoc;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;
        public GUI_ChiTietGiangDay()
        {
            InitializeComponent();
        }
        private void DisplayData()//load lại bảng dữ liệu
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.ChiTietGiangDay", con);
            adapt.Fill(dt);
            DtaChitietgiangday.DataSource = dt;
            con.Close();
        }
        private void GUI_ChiTietGiangDay_Load(object sender, EventArgs e)
        {
            DisplayData();
           
        }

        private void GUI_ChiTietGiangDay_Load_1(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.ChiTietGiangDay where MaGiangDay like N'%" + txtInp.Text +
                "%' or MaMon like N'%" + txtInp.Text +
                "%' or MaGV like N'%" + txtInp.Text +
                "%' or SoTiet like N'%" + txtInp.Text +
                "%' or Nam like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            DtaChitietgiangday.DataSource = dt;
            con.Close();
        }
    }
}
