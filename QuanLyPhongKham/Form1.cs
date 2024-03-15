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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Server = DESKTOP-R38FMPR\\SQLEXPRESS;Database = QuanLyPhongKham;Integrated Security = True");
            try
            {
                sc.Open();
                string query = "select count(*) from TAI_KHOAN where Username = @username";
                SqlCommand cm = new SqlCommand(query, sc);
                cm.Parameters.AddWithValue("@username", tbxUsername.Text);
                if ((int)cm.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    //code here continue
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!\n Nhấn \"OK\" để tạo tài khoản");
                    DangKy dk = new DangKy();
                    dk.Show();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Except"+ex.Message.ToString());
            }
        }

            private void textBox1_TextChanged_1(object sender, EventArgs e)
            {

            }

        private void cbkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tbxPassword.PasswordChar.ToString());
            if (cbkShowPassword.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '*';

            }

        }
    }
    }
