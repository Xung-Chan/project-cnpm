﻿using QuanLyPhongKham.DAO;
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

namespace QuanLyPhongKham.GUI
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
            string phoneNumber = tbxPhoneNumber.Text.Trim();
            string password = tbxPassword.Text.Trim();
            if (checkLogin(phoneNumber, password)){
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
        private Boolean checkLogin(string phoneNumber, string password) {
            return EmployeeDAO.Instance.checkLogin(phoneNumber, password);
        }

        #endregion
    }
}