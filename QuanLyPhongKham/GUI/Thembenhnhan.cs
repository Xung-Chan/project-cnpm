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
        public ThemBenhNhan(PatientDTO patient)
        {
            InitializeComponent();
            loadPatient(patient);
        }
        private void loadPatient(PatientDTO patient) {
            tbxName.Text = patient.Name.ToString();
            dtpBirthday.CustomFormat ="yyyy/MM/dd";
            dtpBirthday.Value = patient.Birthday;
            tbxPhoneNumber.Text = patient.PhoneNumber.ToString();
            tbxAddress.Text = patient.Address.ToString();
            tbxCCCD.Text = patient.CCCD.ToString();
            tbxSex.Text = patient.Sex;
            btnSavePatient.Tag = patient;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemBenhNhan_Load( object sender, EventArgs e ) {

        }
        private void dtpBirthday_ValueChanged( object sender, EventArgs e ) {
            (sender as DateTimePicker).CustomFormat = "yyyy/MM/dd";
        }
        private void btnReset_Click( object sender, EventArgs e ) {
            tbxName.Text = "";
            dtpBirthday.CustomFormat = " ";
            tbxPhoneNumber.Text = "";
            tbxAddress.Text = "";
            tbxCCCD.Text = "";
            tbxSex.Text = "";
        }

        private void btnSavePatient_Click( object sender, EventArgs e ) {
            if(btnSavePatient.Tag != null) {
                LeTanBLL.Instance.savePatient(btnSavePatient.Tag as PatientDTO);
            }
            //int branchID = 1;       //mặc định chi nhánh hiện tại 
            //string name = tbxName.Text;
            //DateTime birthday = dtpBirthday.Value;
            //string phoneNumber = tbxPhoneNumber.Text;
            //string address = tbxAddress.Text;
            //string cccd = tbxCCCD.Text;
            //int sex = tbxSex.Equals("Nam") ? 1 : 0;
            //LeTanBLL.Instance.savePatient(branchID, name, birthday, sex, phoneNumber, address, cccd);
        }


    }
}
