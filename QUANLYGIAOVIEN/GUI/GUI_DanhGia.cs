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
    public partial class GUI_DanhGia : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QuanLyGiaoVienTieuHoc;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;
        string MaDG = string.Empty;

        public GUI_DanhGia()
        {
            InitializeComponent();
        }

        private void DisplayData()//load lại bảng dữ liệu
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.DanhGia", con);
            adapt.Fill(dt);
            DtaDanhGia.DataSource = dt;
            con.Close();
        }

        //Select MaLuong as item from LuongGV where MaGV ='4'

        private void GUI_DanhGia_Load(object sender, EventArgs e)
        {
            DisplayData();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            #region đẩy dữ liệu vào combobox mã giáo viên, load tên giáo viên + (mã) sau đó tách chuỗi sau
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select TenGV+'('+ CONVERT(varchar,MaGV)+')' as item from GiaoVien", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmbMaGV.Items.Add((string)row["item"]);
            }
            con.Close();
            #endregion
        }

        private void btnTimkiem_Click(object sender, EventArgs e) // tìm kiếm trên tất cả các cột
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.DanhGia where MaDG like N'%" + txtInp.Text +
                "%' or DanhHieu like N'%" + txtInp.Text + "%' or KhenThuong like N'%" + txtInp.Text +
                "%' or MaGV like N'%" + txtInp.Text + "%' or KiLuat like N'%" + txtInp.Text + txtInp.Text + "%' or Nam like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            DtaDanhGia.DataSource = dt;
            con.Close();
        }

        private void DtaDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)// bắt sự kiện chọn hàng
        {
            if (DtaDanhGia.CurrentCell != null && e.RowIndex != -1 && DtaDanhGia.CurrentCell.Value != null)
            {
                #region đẩy dữ liệu xuông các ô bên dưới, nếu không sửa thì vẫn dữ nguyên các giá trị
                txtDanhHieu.Text = DtaDanhGia.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbKhenthuong.Text = DtaDanhGia.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbKiLuat.Text = DtaDanhGia.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbMaGV.Text = DtaDanhGia.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateNam.Text = DtaDanhGia.Rows[e.RowIndex].Cells[5].Value.ToString();
                #endregion
                btnSua.Enabled = true;// khi có 1 hàng dữ liệu được chọn thì sáng nút sửa và xóa
                btnXoa.Enabled = true;
                MaDG = DtaDanhGia.Rows[e.RowIndex].Cells[0].Value.ToString();//lấy dữ liệu cột thứ 0 của hàng được chọn
            }
        }

        private void btnThem_Click(object sender, EventArgs e)//Tên đăng nhập = mã GV, mật khẩu mặc định 123
        {

            string danhHieu = txtDanhHieu.Text;
            string khenthuong = cmbKhenthuong.Text;
            string maGV = cmbMaGV.Text;
            string kiluat = cmbKiLuat.Text;
            string nam = dateNam.Value.ToShortDateString();



            if (danhHieu != "" && khenthuong != "" && kiluat != "" && maGV != "" && nam != "")//Để trống là không thêm được
            {
                con.Open();
                KHCmd = new SqlCommand("EXEC dbo.[Proc_InsertDanhGia] N'" + danhHieu +
                    "',N'" + khenthuong +
                    "',N'" + kiluat +
                    "',N'" + TachChuoi(maGV) +
                    "',N'" + nam + "'", con);
                KHCmd.ExecuteNonQuery();
                con.Close();
                txtDanhHieu.Clear();
                DisplayData();
            }
            else
                MessageBox.Show("Yêu cầu nhập đủ!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string danhHieu = txtDanhHieu.Text;
            string khenthuong = cmbKhenthuong.Text;
            string maGV = cmbMaGV.Text;
            string kiluat = cmbKiLuat.Text;
            string nam = dateNam.Value.ToShortDateString();


            if (danhHieu != "" && khenthuong != "" && kiluat != "" && maGV != "" && nam != "")//Để trống là không thêm được
            {
                con.Open();
                KHCmd = new SqlCommand("EXEC dbo.Proc_UpdateDanhGia N'" + MaDG +
                    "',N'" + danhHieu +
                    "',N'" + khenthuong +
                    "',N'" + kiluat +
                    "',N'" + TachChuoi(maGV) +
                    "',N'" + nam + "'", con);
                KHCmd.ExecuteNonQuery();
                con.Close();
                txtDanhHieu.Clear();
                DisplayData();
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập đủ!");
                con.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaDG != null)
            {
                if ((MessageBox.Show("Xác nhận XOÁ giáo viên: " + MaDG, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && MaDG != null)
                {
                    con.Open();
                    KHCmd = new SqlCommand("EXEC dbo.[Proc_DeleteDanhGiaByID] " + MaDG, con);
                    KHCmd.ExecuteNonQuery();
                    con.Close();
                }
                DisplayData();
            }
        }

        public string TachChuoi(string inp)
        {
            int len = inp.Length;// Toán(1) -> length = 7   (Đếm tính từ 1)
            int vt = inp.IndexOf("("); //Tìm vị trí của ký tự đầu tiên ->vt=4  (Đếm tính từ 0)
            return vt < 0 ? inp : inp.Substring(vt + 1, len - vt - 2); //Substring(Vị trí bắt đầu cắt, khoảng cách) ->Substring(5,7-4-2)
        }

       
    }
}
