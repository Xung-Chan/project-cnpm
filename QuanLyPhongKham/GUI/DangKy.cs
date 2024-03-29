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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
        #region event

        private void eyeShowFirst_Click(object sender, EventArgs e)
        {
            eyeShowFirst.Visible = false;
            eyeHideFirst.Visible = true;
            tbxPasswordFirst.UseSystemPasswordChar = false;
        }

        private void eyeHideFirst_Click(object sender, EventArgs e)
        {
            eyeHideFirst.Visible = false;
            eyeShowFirst.Visible = true;
            tbxPasswordFirst.UseSystemPasswordChar = true;
        }
        private void eyeShowSecond_Click(object sender, EventArgs e)
        {
            eyeShowSecond.Visible = false;
            eyeHideSecond.Visible = true;
            tbxPasswordSecond.UseSystemPasswordChar = false;
        }

        private void eyeHideSecond_Click(object sender, EventArgs e)
        {
            eyeHideSecond.Visible = false;
            eyeShowSecond.Visible = true;
            tbxPasswordSecond.UseSystemPasswordChar = true;
        }

        private void btnLogup_Click(object sender, EventArgs e)
        {   
            //if()
            MessageBox.Show("Đăng ký thành công");
        }
        #endregion

        #region method


        #endregion


    }
}
