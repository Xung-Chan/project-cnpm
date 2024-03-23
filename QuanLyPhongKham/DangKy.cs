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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void eyeHide_Paint(object sender, PaintEventArgs e)
        {
            
        }


        

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
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\Downloads\\project-cnpm-csharp\\QuanLyPhongKham\\DatabaseQuanLyPhongKham.mdf;Integrated Security=True");
            try
            {
                sc.Open();
                string query = "INSERT INTO TAI_KHOAN VALUES (@username,@password,@role,@maUser)";
                SqlCommand cm = new SqlCommand(query, sc);
                cm.Parameters.AddWithValue("@username", tbxSdt.Text.Trim());
                cm.Parameters.AddWithValue("@password", tbxPasswordFirst.Text.Trim());
                cm.Parameters.AddWithValue("@role", tbxRole.Text.Trim());
                cm.Parameters.AddWithValue("@maUser", tbxMaUser.Text.Trim());
                if (cm.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Đăng ký thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void eyeHideSecond_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxPasswordFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eyeShowSecond_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void eyeShowFirst_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
