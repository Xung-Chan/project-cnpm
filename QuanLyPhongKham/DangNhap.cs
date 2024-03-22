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

namespace QuanLyPhongKham
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cbkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = cbkShowPassword.Checked;
        }
        private void tbxPassword_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Downloads\\project-cnpm-csharp\\QuanLyPhongKham\\DatabaseQuanLyPhongKham.mdf;Integrated Security=True");
            try
            {
                sc.Open();
                string query = "select * from TAI_KHOAN where Username = @username";
                SqlCommand cm = new SqlCommand(query, sc);
                cm.Parameters.AddWithValue("@username", tbxUsername.Text);
                SqlDataReader reader = cm.ExecuteReader();

                if (reader.Read())
                {
                    string[] data = new string[3];
                    for (int i = 0; i < 3; i++)
                    {
                        data[i] = reader.IsDBNull(i) ? null : reader.GetString(i).Trim();
                    }

                    if (data[0] == tbxUsername.Text.Trim() && data[1] == tbxPassword.Text.Trim())
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        //code here continue
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    }


                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!\n Nhấn \"OK\" để tạo tài khoản");
                    DangKy dk = new DangKy();
                    dk.Show();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
