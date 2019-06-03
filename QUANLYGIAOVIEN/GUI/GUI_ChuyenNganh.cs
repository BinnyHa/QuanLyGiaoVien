using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYGIAOVIEN
{
    public partial class GUI_ChuyenNganh : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QuanLyGiaoVienTieuHoc;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;
        string MaCN = string.Empty;
        public GUI_ChuyenNganh()
        {
            InitializeComponent();
        }
        private void DisplayData()//load lại bảng dữ liệu
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.ChuyenNghanh", con);
            adapt.Fill(dt);
            DtaChuyenNganh.DataSource = dt;
            con.Close();
        }

        private void GUI_ChuyenNganh_Load(object sender, EventArgs e)
        {
            DisplayData();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenCN = cmbTenCN.Text;
            string CNchinh = cmbCNchinh.Text;
            string Cnkhac = cmbCNkhac.Text;
            if (tenCN != "" && CNchinh != "" && Cnkhac != "" )//Để trống là không thêm được
            {
                con.Open();
                KHCmd = new SqlCommand("EXEC dbo.Proc_InsertChuyennganh N'" + tenCN + "',N'" + CNchinh + "',N'" + Cnkhac + "'", con);
                KHCmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
            }
            else
                MessageBox.Show("Yêu cầu nhập đủ!");
        }

        private void DtaChuyenNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtaChuyenNganh.CurrentCell != null && e.RowIndex != -1 && DtaChuyenNganh.CurrentCell.Value != null)
            {
                #region đẩy dữ liệu xuông các ô bên dưới, nếu không sửa thì vẫn dữ nguyên các giá trị
                MaCN = DtaChuyenNganh.Rows[e.RowIndex].Cells[0].Value.ToString();//lấy dữ liệu cột thứ 0 của hàng được chọn
                cmbTenCN.Text = DtaChuyenNganh.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbCNchinh.Text = DtaChuyenNganh.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbCNkhac.Text = DtaChuyenNganh.Rows[e.RowIndex].Cells[3].Value.ToString();
             
                #endregion
                btnSua.Enabled = true;// khi có 1 hàng dữ liệu được chọn thì sáng nút sửa và xóa
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenCN = cmbTenCN.Text;
            string CNchinh = cmbCNchinh.Text;
            string Cnkhac = cmbCNkhac.Text;
            if (tenCN != "" && CNchinh != "" && Cnkhac != "")//Để trống là không thêm được
            {
                if ((MessageBox.Show("Xác nhận SỬA : " + MaCN, "Xác nhận SỬA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && MaCN != null)
                {
                    con.Open();
                    KHCmd = new SqlCommand("EXEC dbo.Proc_UpdateChuyenNganh N'" + MaCN + "',N'" + tenCN + "',N'" + CNchinh + "',N'" + Cnkhac + "'", con);
                    KHCmd.ExecuteNonQuery();
                    con.Close();
                    DisplayData();
                }
            }

            else
            {
                MessageBox.Show("Yêu cầu nhập đủ!");
                con.Close();
            }
                

            }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaCN != "")
            {
                con.Open();
                KHCmd = new SqlCommand("EXEC dbo.Proc_DeleteChuyenNganhByID N'" + MaCN + "'", con);
                KHCmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
            }
            else
                MessageBox.Show("Chọn bản ghi để xóa!");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.ChuyenNghanh WHERE MaCN LIKE N'%" + txtInp.Text +
                "%' OR TenCN LIKE N'%" + txtInp.Text +
                "%' OR CN_Chinh LIKE N'%" + txtInp.Text +
                "%' OR CN_Khac LIKE N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            DtaChuyenNganh.DataSource = dt;
            con.Close();
        }
    }
}
