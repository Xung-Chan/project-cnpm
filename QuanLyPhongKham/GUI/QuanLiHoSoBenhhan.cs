﻿using QuanLyPhongKham.DAO;
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
    public partial class QuanLiHoSoBenhhan : UserControl
    {
        public QuanLiHoSoBenhhan()
        {
            InitializeComponent();
        }

        private void btnSearch_Click( object sender, EventArgs e ) {
            PatientDTO patient = PatientDAO.Instance.getPatientByPhoneNumber(tbxSearch.Text.Trim());
            if (patient == null ) {
                MessageBox.Show("Bệnh nhân không có thông tin trong hồ sơ phòng khám", "Không tìm thấy kết quả", MessageBoxButtons.OK);
                tbxSearch.Text = "";
                return;
            }
            loadPatient(patient);
        }
        private void loadPatient(PatientDTO patient ) {
            btnPatientID.Text = patient.ID.ToString();
            btnName.Text = patient.Name.ToString();
            int birthYear = patient.Birthday.Year;
            btnBirthYear.Text = birthYear.ToString();
            btnYearOld.Text = (DateTime.Now.Year - birthYear).ToString();
            btnAddress.Text = patient.Address.ToString();
            btnPhoneNumber.Text = patient.PhoneNumber.ToString();   
            btnCCCD.Text = patient.CCCD.ToString();
            btnSex.Text = patient.Sex.ToString();
            tbxSearch.Text = "";

        }

        private void tbxSearch_KeyPress( object sender, KeyPressEventArgs e ) {
            if(e.KeyChar == (char) Keys.Enter) {
                btnSearch_Click( sender, e );
            }
        }

        private void btnAddPatient_Click( object sender, EventArgs e ) {
            ThemBenhNhan tbn = new ThemBenhNhan();
            this.Parent.Hide();
            tbn.ShowDialog();
            this.Parent.Show();
        }
    }
}