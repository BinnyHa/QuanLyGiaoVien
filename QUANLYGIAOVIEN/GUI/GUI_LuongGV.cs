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

namespace QUANLYGIAOVIEN
{
    public partial class GUI_LuongGV : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QuanLyGiaoVienTieuHoc;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;
        string MaLuong = string.Empty;
        public GUI_LuongGV()
        {
            InitializeComponent();
        }

        private void DisplayData()//load lại bảng dữ liệu
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.Luong", con);
            adapt.Fill(dt);
            DtaLuong.DataSource = dt;
            con.Close();
        }

        private void GUI_LuongGV_Load(object sender, EventArgs e)
        {
            DisplayData();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            //con.Open();
            //DataTable dt = new DataTable();
            //adapt = new SqlDataAdapter("Select TenChuyenNganh+'('+ CONVERT(varchar,MaChuyenNganh)+')' as item from ChuyenMon", con);
            //adapt.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    cmbMaChuyenNganh.Items.Add((string)row["item"]);
            //}
            //con.Close();

            //    con.Open();
            //    DataTable dt2 = new DataTable();
            //    adapt = new SqlDataAdapter("Select HTenGV+'('+ CONVERT(varchar,MaGv)+')' as item from TTGiaoVien", con);
            //    adapt.Fill(dt2);
            //    foreach (DataRow row in dt2.Rows)
            //    {
            //        cmbMaGV.Items.Add((string)row["item"]);
            //    }
            //    con.Close();
            //    #endregion
        }

        private void btnTimkiem_Click(object sender, EventArgs e) // tìm kiếm trên tất cả các cột
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.Luong where MaLuong like N'%" + txtInp.Text +
                "%' or LuongCB like N'%" + txtInp.Text +
                "%' or HeSoLuong like N'%" + txtInp.Text +
                "%' or PhuCapUuDai like N'%" + txtInp.Text +
                "%' or PhuCapThamNien like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            DtaLuong.DataSource = dt;
            con.Close();
        }

        private void DtaLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtaLuong.CurrentCell != null && e.RowIndex != -1 && DtaLuong.CurrentCell.Value != null)
            {
                #region đẩy dữ liệu xuông các ô bên dưới, nếu không sửa thì vẫn dữ nguyên các giá trị
                txtLuongCB.Text = DtaLuong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHeSo.Text = DtaLuong.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtPhuCapUuDai.Text = DtaLuong.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhuCapThamNien.Text = DtaLuong.Rows[e.RowIndex].Cells[4].Value.ToString();
                #endregion
                btnSua.Enabled = true;// khi có 1 hàng dữ liệu được chọn thì sáng nút sửa và xóa
                btnXoa.Enabled = true;
                MaLuong = DtaLuong.Rows[e.RowIndex].Cells[0].Value.ToString();//lấy dữ liệu cột thứ 0 của hàng được chọn
                txtTienLuong.Text = (Convert.ToDouble(txtLuongCB.Text) * Convert.ToDouble(txtHeSo.Text) + Convert.ToDouble(txtPhuCapThamNien.Text) + Convert.ToDouble(txtPhuCapUuDai.Text)).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)//Tên đăng nhập = mã GV, mật khẩu mặc định 123
        {
            string luongCB = txtLuongCB.Text;
            string HeSo = txtHeSo.Text;
            string PC_UuDai = txtPhuCapUuDai.Text;
            string PC_ThamNien = txtPhuCapThamNien.Text;
            if (luongCB != "" && HeSo != "" && PC_UuDai != "" && PC_ThamNien != "")//Để trống là không thêm được
            {
                con.Open();
                KHCmd = new SqlCommand("EXEC dbo.Proc_InsertLuong N'" + luongCB +
                    "','" + HeSo +
                    "','" + PC_UuDai +
                    "','" + PC_ThamNien + "'", con);
                KHCmd.ExecuteNonQuery();
                con.Close();
                txtLuongCB.ResetText();
                txtHeSo.ResetText();
                txtPhuCapUuDai.ResetText();
                txtPhuCapThamNien.ResetText();
                DisplayData();
            }
            else
                MessageBox.Show("Yêu cầu nhập đủ!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string luongCB = txtLuongCB.Text;
            string HeSo = txtHeSo.Text;

            string PC_UuDai = txtPhuCapUuDai.Text;
            string PC_ThamNien = txtPhuCapThamNien.Text;

            if (luongCB != "" && HeSo != "" && PC_UuDai != "" && PC_ThamNien != "")//Để trống là không sửa được
            {
                if ((MessageBox.Show("Xác nhận SỬA giáo viên: " + MaLuong, "Xác nhận SỬA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && MaLuong != null)
                {
                    con.Open();
                    KHCmd = new SqlCommand("EXEC dbo.[Proc_UpdateLuong] N'" + MaLuong +
                        "','" + luongCB +
                        "','" + HeSo +
                        "','" + PC_UuDai +
                        "','" + PC_ThamNien + "'", con);
                    KHCmd.ExecuteNonQuery();
                    con.Close();
                    txtLuongCB.ResetText();
                    txtHeSo.ResetText();
                    txtPhuCapUuDai.ResetText();
                    txtPhuCapThamNien.ResetText();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
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
            if (MaLuong != null)
            {
                if ((MessageBox.Show("Xác nhận XOÁ giáo viên: " + MaLuong, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && MaLuong != null)
                {
                    con.Open();
                    KHCmd = new SqlCommand("EXEC dbo.[Proc_DeleteLuongGVByID] " + MaLuong, con);
                    KHCmd.ExecuteNonQuery();
                    con.Close();
                    txtLuongCB.ResetText();
                    txtHeSo.ResetText();
                    txtPhuCapUuDai.ResetText();
                    txtPhuCapThamNien.ResetText();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                DisplayData();
            }
        }

        public string TachChuoi(string inp)
        {
            int len = inp.Length;
            int vt = inp.IndexOf("(");
            return vt < 0 ? inp : inp.Substring(vt + 1, len - vt - 2);
        }


    }
}
