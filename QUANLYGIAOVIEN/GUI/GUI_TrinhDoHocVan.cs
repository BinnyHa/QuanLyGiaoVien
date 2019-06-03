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
    public partial class GUI_TrinhDoHocVan : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QuanLyGiaoVienTieuHoc;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;
        string MaTDHV = string.Empty;
        public GUI_TrinhDoHocVan()
        {
            InitializeComponent();
        }

        private void DisplayData()//load lại bảng dữ liệu
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.TrinhDoHocVan", con);
            adapt.Fill(dt);
            DtaTrinhDoHocVan.DataSource = dt;
            con.Close();
        }

        private void GUI_TrinhDoHocVan_Load(object sender, EventArgs e)
        {
            DisplayData();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }


      

        private void DtaTrinhDoHocVan_CellClick(object sender, DataGridViewCellEventArgs e)// bắt sự kiện chọn hàng
        {
            if (DtaTrinhDoHocVan.CurrentCell != null && e.RowIndex != -1 && DtaTrinhDoHocVan.CurrentCell.Value != null)
            {
                #region đẩy dữ liệu xuông các ô bên dưới, nếu không sửa thì vẫn dữ nguyên các giá trị
                MaTDHV = DtaTrinhDoHocVan.Rows[e.RowIndex].Cells[0].Value.ToString();//lấy dữ liệu cột thứ 0 của hàng được chọn
                txtTrinhDoCm.Text = DtaTrinhDoHocVan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTrinhDoNN.Text = DtaTrinhDoHocVan.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTrinhDoTH.Text = DtaTrinhDoHocVan.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTrinhDoChinh.Text = DtaTrinhDoHocVan.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTrinhDoKhac.Text = DtaTrinhDoHocVan.Rows[e.RowIndex].Cells[5].Value.ToString();
                #endregion
                btnSua.Enabled = true;// khi có 1 hàng dữ liệu được chọn thì sáng nút sửa và xóa
                btnXoa.Enabled = true;
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.TrinhDoHocVan WHERE MaTDHV LIKE N'%" + txtInp.Text + 
                "%' OR Trinhdo_chinh LIKE N'%" + txtInp.Text + 
                "%' OR Trinhdo_CM LIKE N'%" + txtInp.Text + 
                "%' OR Trinhdo_khac LIKE N'%" + txtInp.Text +
                "%' OR Trinhdo_NN LIKE N'%" + txtInp.Text +
                "%' OR Trinhdo_TinHoc LIKE N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            DtaTrinhDoHocVan.DataSource = dt;
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaTDHV != null)
            {
                if ((MessageBox.Show("Xác nhận XOÁ giáo viên: " + MaTDHV, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && MaTDHV != null)
                {
                    con.Open();
                    KHCmd = new SqlCommand("EXEC dbo.Proc_DeleteTrinhDoHocVanByID " + MaTDHV, con);
                    KHCmd.ExecuteNonQuery();
                    con.Close();
                    txtTrinhDoCm.Clear();
                    txtTrinhDoNN.Clear();
                    txtTrinhDoChinh.Clear();
                    txtTrinhDoTH.Clear();
                    txtTrinhDoKhac.Clear();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                }
                DisplayData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string trinhDoCM = txtTrinhDoCm.Text;
            string trinhDoNN = txtTrinhDoNN.Text;
            string trinhDoTH = txtTrinhDoTH.Text;
            string trinhDoChinh = txtTrinhDoChinh.Text;
            string trinhDoKhac = txtTrinhDoKhac.Text;

            if (trinhDoCM != "" && trinhDoNN != "" && trinhDoTH != "" && trinhDoChinh != "" && trinhDoKhac != "")//Để trống là không sửa được
            {
                if ((MessageBox.Show("Xác nhận SỬA giáo viên: " + MaTDHV, "Xác nhận SỬA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && MaTDHV != null)
                {

                    con.Open();
                    KHCmd = new SqlCommand("EXEC dbo.Proc_UpdateTrinhDoHocVan  N'" + MaTDHV + "',N'" + trinhDoCM + "',N'" + trinhDoNN + "',N'" + trinhDoTH + "',N'" + trinhDoChinh + "',N'" + trinhDoKhac + "'", con);
                    KHCmd.ExecuteNonQuery();
                    con.Close();
                    txtTrinhDoCm.Clear();
                    txtTrinhDoNN.Clear();
                    txtTrinhDoChinh.Clear();
                    txtTrinhDoTH.Clear();
                    txtTrinhDoKhac.Clear();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    DisplayData();
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập đủ!");
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string trinhDoCM = txtTrinhDoCm.Text;
            string trinhDoNN = txtTrinhDoNN.Text;
            string trinhDoTH = txtTrinhDoTH.Text;
            string trinhDoChinh = txtTrinhDoChinh.Text;
            string trinhDoKhac = txtTrinhDoKhac.Text;
            if (trinhDoCM != "" && trinhDoNN != "" && trinhDoTH != "" && trinhDoChinh != "" && trinhDoKhac != "")//Để trống là không thêm được
            {
                con.Open();
                KHCmd = new SqlCommand("EXEC dbo.Proc_InsertTrinhDoHocVan N'" + trinhDoCM + "',N'" + trinhDoNN + "',N'" + trinhDoTH + "',N'" + trinhDoChinh + "',N'" + trinhDoKhac + "'", con);
                KHCmd.ExecuteNonQuery();
                con.Close();
                txtTrinhDoCm.Clear();
                txtTrinhDoNN.Clear();
                txtTrinhDoChinh.Clear();
                txtTrinhDoTH.Clear();
                txtTrinhDoKhac.Clear();
                DisplayData();
            }
            else
                MessageBox.Show("Yêu cầu nhập đủ!");
        }
    }
}
