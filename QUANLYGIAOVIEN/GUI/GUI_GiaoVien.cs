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
    public partial class GUI_GiaoVien : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QuanLyGiaoVienTieuHoc;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;
        string MaGV = string.Empty;
        public GUI_GiaoVien()
        {
            InitializeComponent();
        }

        private void DisplayData()//load lại bảng dữ liệu
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.GiaoVien", con);
            adapt.Fill(dt);
            DtaGiaoVien.DataSource = dt;
            con.Close();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            DisplayData();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            #region đẩy dữ liệu vào combobox mã chuyên ngành, load tên chuyên ngành mã sau đó tách chuỗi sau
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select TenCN+'('+ CONVERT(varchar,MaCN)+')' as item from ChuyenNghanh", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmbChuyenNganh.Items.Add((string)row["item"]);
            }
            con.Close();
            #endregion
            #region đẩy dữ liệu vào combobox mã chuyên ngành, load tên chuyên ngành mã sau đó tách chuỗi sau
            con.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("SELECT CONVERT(varchar, MaLuong) as item FROM dbo.Luong", con);
            adapt.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                cmbMaLuong.Items.Add((string)row["item"]);
            }
            con.Close();
            #endregion
            #region đẩy dữ liệu vào combobox mã chuyên ngành, load tên chuyên ngành mã sau đó tách chuỗi sau
            con.Open();
            DataTable dt3 = new DataTable();
            adapt = new SqlDataAdapter("SELECT CONVERT(varchar, MaCT) as item FROM dbo.CongTac", con);
            adapt.Fill(dt3);
            foreach (DataRow row in dt3.Rows)
            {
                cmbMaCongTac.Items.Add((string)row["item"]);
            }
            con.Close();
            #endregion
            #region đẩy dữ liệu vào combobox mã chuyên ngành, load tên chuyên ngành mã sau đó tách chuỗi sau
            con.Open();
            DataTable dt4 = new DataTable();
            adapt = new SqlDataAdapter("SELECT CONVERT(varchar, MaTDHV) as item FROM dbo.TrinhDoHocVan", con);
            adapt.Fill(dt4);
            foreach (DataRow row in dt4.Rows)
            {
                cmbMaTDHV.Items.Add((string)row["item"]);
            }
            con.Close();
            #endregion
        }

        private void btnTimkiem_Click(object sender, EventArgs e) // tìm kiếm trên tất cả các cột
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.GiaoVien where MaGV like N'%" + txtInp.Text +
                "%' or TenGV like N'%" + txtInp.Text +
                "%' or Ngay_Sinh like N'%" + txtInp.Text +
                "%' or GioiTinh like N'%" + txtInp.Text +
                  "%' or SĐT like N'%" + txtInp.Text +
                    "%' or CMND like N'%" + txtInp.Text +
                      "%' or Email like N'%" + txtInp.Text +
                        "%' or Que_quan like N'%" + txtInp.Text +
                          "%' or DanToc like N'%" + txtInp.Text +
                            "%' or TonGiao like N'%" + txtInp.Text +
                              "%' or So_BHYT like N'%" + txtInp.Text +
                                "%' or MaChuyenNganh like N'%" + txtInp.Text +
                                  "%' or MaLuong like N'%" + txtInp.Text +
                                    "%' or MaCT like N'%" + txtInp.Text +
                "%' or MaTDHV like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            DtaGiaoVien.DataSource = dt;
            con.Close();
        }

        private void DtaGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)// bắt sự kiện chọn hàng
        {

            if (DtaGiaoVien.CurrentCell != null && e.RowIndex != -1 && DtaGiaoVien.CurrentCell.Value != null)
            {
                #region đẩy dữ liệu xuông các ô bên dưới, nếu không sửa thì vẫn dữ nguyên các giá trị
                txtHoTen.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimepk1.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbGioiTinh.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDT.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCMND.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtEmail.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtQueQuan.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDanToc.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtTonGiao.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtBHYT.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[10].Value.ToString();
                cmbChuyenNganh.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[11].Value.ToString();
                cmbMaLuong.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[12].Value.ToString();
                cmbMaCongTac.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[13].Value.ToString();
                cmbMaTDHV.Text = DtaGiaoVien.Rows[e.RowIndex].Cells[14].Value.ToString();
                
                #endregion
                btnSua.Enabled = true;// khi có 1 hàng dữ liệu được chọn thì sáng nút sửa và xóa
                btnXoa.Enabled = true;
                MaGV = DtaGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();//lấy dữ liệu cột thứ 0 của hàng được chọn
            }
        }

        private void btnThem_Click(object sender, EventArgs e)//Tên đăng nhập = mã GV, mật khẩu mặc định 123
        {
            string hoten = txtHoTen.Text;
            string NS = dateTimepk1.Text;
            string GT = cmbGioiTinh.Text;
            string SDT = txtSDT.Text;
            string CMND = txtCMND.Text;
            string email = txtEmail.Text;
            string queQuan = txtQueQuan.Text;
            string tongGiao = txtTonGiao.Text;
            string BHYT = txtBHYT.Text;
            string chuyenNganh = TachChuoi(cmbChuyenNganh.Text);
            string maLuong = cmbMaLuong.Text;
            string maCT = cmbMaCongTac.Text;
            string maTDHV = cmbMaTDHV.Text;
            string danToc = txtDanToc.Text;

            if (hoten != "" && NS != "" && maLuong != "" && maCT != "" && chuyenNganh != "" && maTDHV != "")//Để trống là không thêm được
            {
                con.Open();
                KHCmd = new SqlCommand("EXEC dbo.Proc_InsertGiaoVien N'" + hoten +
                    "','" + NS +
                    "',N'" + GT +
                    "',N'" + SDT +
                    "',N'" + CMND +
                    "',N'" + email +
                    "',N'" + queQuan +
                    "',N'" + danToc +
                    "',N'" + tongGiao +
                    "',N'" + BHYT +
                    "',N'" + chuyenNganh +
                    "',N'" + maLuong +
                    "',N'" + maCT +
                    "',N'" + maTDHV + "'", con);
                KHCmd.ExecuteNonQuery();
                con.Close();
                txtHoTen.Clear();
                txtSDT.Clear();
                txtCMND.Clear();
                txtEmail.Clear();
                txtQueQuan.Clear();
                txtTonGiao.Clear();
                txtBHYT.Clear();
                DisplayData();
            }
            else
                MessageBox.Show("Yêu cầu nhập đủ!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            string NS = dateTimepk1.Text;
            string GT = cmbGioiTinh.Text;
            string SDT = txtSDT.Text;
            string CMND = txtCMND.Text;
            string email = txtEmail.Text;
            string queQuan = txtQueQuan.Text;
            string tongGiao = txtTonGiao.Text;
            string BHYT = txtBHYT.Text;
            string chuyenNganh = TachChuoi(cmbChuyenNganh.Text);
            string maLuong = cmbMaLuong.Text;
            string maCT = cmbMaCongTac.Text;
            string maTDHV = cmbMaTDHV.Text;
            string danToc = txtDanToc.Text;

            if (hoten != "" && NS != "" && maLuong != "" && maCT != "" && chuyenNganh != "" && maTDHV != "")//Để trống là không thêm được
            {
                if ((MessageBox.Show("Xác nhận SỬA giáo viên: " + MaGV, "Xác nhận SỬA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && MaGV != null)
                {

                    con.Open();
                    KHCmd = new SqlCommand("EXEC dbo.Proc_UpdateGiaoVien N'" + MaGV +
                     "','" + hoten +
                     "','" + NS +
                     "',N'" + GT +
                     "',N'" + SDT +
                     "',N'" + CMND +
                     "',N'" + email +
                     "',N'" + queQuan +
                     "',N'" + danToc +
                     "',N'" + tongGiao +
                     "',N'" + BHYT +
                     "',N'" + chuyenNganh +
                     "',N'" + maLuong +
                     "',N'" + maCT +
                     "',N'" + maTDHV + "'", con);
                    KHCmd.ExecuteNonQuery();
                    con.Close();
                    txtHoTen.Clear();
                    txtSDT.Clear();
                    txtCMND.Clear();
                    txtEmail.Clear();
                    txtQueQuan.Clear();
                    txtTonGiao.Clear();
                    txtBHYT.Clear();
                    DisplayData();
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
            if (MaGV != null)
            {
                if ((MessageBox.Show("Xác nhận XOÁ giáo viên: " + MaGV, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && MaGV != null)
                {
                    con.Open();
                    KHCmd = new SqlCommand("EXEC dbo.Proc_DeleteGiaoVien " + MaGV, con);
                    KHCmd.ExecuteNonQuery();
                    con.Close();
                }
                DisplayData();
            }
        }

        public string TachChuoi(string inp)
        {
            int len = inp.Length;// Toán(1) -> length = 7   (Đếm tính từ 1)
            int vt = inp.IndexOf("(");//Tìm vị trí của ký tự đầu tiên ->vt=4  (Đếm tính từ 0)
            return vt < 0 ? inp : inp.Substring(vt + 1, len - vt - 2);//Substring(Vị trí bắt đầu cắt, khoảng cách) ->Substring(5,7-4-2)
        }

      
    }
}
