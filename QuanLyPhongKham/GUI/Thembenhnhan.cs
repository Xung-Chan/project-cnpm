using QuanLyPhongKham.BLL;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI
{
    public partial class ThemBenhNhan : Form
    {
        public ThemBenhNhan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemBenhNhan_Load( object sender, EventArgs e ) {

        }

        private void btnSavePatient_Click( object sender, EventArgs e ) {
            int branchID = 1;       //mặc định chi nhánh hiện tại 
            string name = tbxName.Text;
            DateTime birthday = dtpBirthday.Value;
            string phoneNumber = tbxPhoneNumber.Text;
            string address = tbxAddress.Text;
            string cccd = tbxCCCD.Text;
            int sex = tbxSex.Equals("Nam") ? 1 : 0;
            LeTanBLL.Instance.insertPatient(branchID, name, birthday, sex, phoneNumber, address, cccd);
        }

        private void dtpBirthday_ValueChanged( object sender, EventArgs e ) {
            (sender as DateTimePicker).CustomFormat = "yyyy/MM/dd";
        }
    }
}
