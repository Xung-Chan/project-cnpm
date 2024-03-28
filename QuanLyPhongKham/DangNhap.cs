using QuanLyPhongKham.DAO;
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



        #region Event
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
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
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text.Trim();
            if (checkLogin(username, password)){
                //this.Hide();
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");

            }
            tbxPassword.Text = "";
        }
        #endregion


        #region method
        private Boolean checkLogin(string username, string password) {
            return AccountDAO.Instance.checkLogin(username, password);
        }

        #endregion
    }
}
