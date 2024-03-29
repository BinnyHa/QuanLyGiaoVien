﻿using System;
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
    public partial class DoiMatKhau : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QuanLyGiaoVienTieuHoc;Integrated Security=True");
        SqlCommand MKCmd;
        SqlDataAdapter adapt;

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Xác nhận thay đổi", "Đổi mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                con.Open();
                string tk = comboBox1.Text;
                string mk = txtMK1.Text;
                string sql = "select * from dbo.Users where UserName='" + tk + "' and PassWord='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader(); //select ExecuteReader();  insert/delete ExecuteNonQuery
                if ((dta.Read() == true && dta.GetValue(0).ToString() != "") || UserInfo.UserName == "1")
                {
                    con.Close();
                    if (txtMK2.Text != txtMK3.Text)
                    {
                        MessageBox.Show("Mật khẩu xác nhận phải giống nhau");
                    }
                    else if(txtMK2.Text == "")
                    {
                        MessageBox.Show("Không được để trống");
                    }
                    else
                    {
                        con.Open();
                        MKCmd = new SqlCommand("Update Users set PassWord='" + txtMK2.Text + "' where UserName ='" + comboBox1.Text + "'", con);
                        MKCmd.ExecuteNonQuery();
                        MessageBox.Show("Đổi thành công");
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu sai.");
                }
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT CONVERT(VARCHAR,UserName) AS item FROM dbo.Users", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add((string)row["item"]);
            }
            con.Close();
            comboBox1.Text = UserInfo.UserName;
            comboBox1.Visible = false;
            label4.Visible = false;
            if (UserInfo.UserName == "1")
            {
                comboBox1.Visible = true;
                label4.Visible = true;
                txtMK1.Enabled = false;
                label2.Enabled = false;
            }
        }
    }
}
