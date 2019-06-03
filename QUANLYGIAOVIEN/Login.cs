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
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    Application.Exit();
            //}
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QuanLyGiaoVienTieuHoc;Integrated Security=True");
            try
            {
                cn.Open();
                string tk = username.Text;
                string mk = mkhau.Text;
                string sql = "select * from Users where UserName='" + tk + "' and PassWord='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dta = cmd.ExecuteReader(); //select ExecuteReader();  insert/delete ExecuteNonQuery
                if (dta.Read() == true && dta.GetValue(0).ToString() != "")
                {
                    this.Hide();
                    UserInfo.UserName = tk;
                    UserInfo.FullName = dta["MaGV"].ToString();
                    TableManager f = new TableManager();
                    f.ShowDialog();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
