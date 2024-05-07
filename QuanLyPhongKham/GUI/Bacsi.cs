﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using QuanLyPhongKham.BLL;
using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyPhongKham.GUI {
    public partial class BacSi : Form {
        public BacSi() {
            InitializeComponent();
            khamLamSang.BringToFront();
        }

        private void Bacsi_Load( object sender, EventArgs e ) {
            int roomNumber = RoomDAO.Instance.getRoomByDentistID((this.Tag as EmployeeDTO).ID).RoomNumber;
            Queue<PatientTreamentNeedsDTO> patientList = BacSiBLL.Instance.QueuePatient[roomNumber];
            foreach (PatientTreamentNeedsDTO item in patientList) {
                ListViewItem lvwItem = new ListViewItem(item.Patient.ID.ToString());
                lvwItem.SubItems.Add(item.Patient.Name);
                lvwItem.Tag = item;
                lvwPatient.Items.Add(lvwItem);
            }
        }



        private void lvwPatient_SelectedIndexChanged( object sender, EventArgs e ) {
            if (lvwPatient.SelectedItems.Count == 1 ) {
                PatientTreamentNeedsDTO patient = (lvwPatient.SelectedItems[0].Tag as PatientTreamentNeedsDTO);
                //load information to textbox
                tbxID.Text = patient.Patient.ID.ToString();
                tbxCCCD.Text = patient.Patient.CCCD.ToString();
                tbxBirthday.Text = patient.Patient.Birthday.Date.ToString("dd/MM/yyyy");
                tbxName.Text = patient.Patient.Name.ToString();
                tbxPhoneNumber.Text = patient.Patient.PhoneNumber.ToString();
                tbxSex.Text = patient.Patient.Sex.ToString();
                //loaf listview nhu cầu điều trị
                lvwTreamentNeeds.Items.Clear();
                foreach (TreatmentNeedsDTO treament in patient.Treatments) {
                    ListViewItem item = new ListViewItem(treament.Name);
                    lvwTreamentNeeds.Items.Add(item);
                }
                //load lịch sử khám chữa bệnh
                lichSuKhamChuaBenh.loadTreamentRecord(int.Parse(tbxID.Text));
               
                TreamentRecordsDTO treamentRecord = TreamentRecordsDAO.Instance.getLastestTreamentRecordOfPatient(int.Parse(tbxID.Text));
                khamLamSang.Tag = treamentRecord;
                donThuoc.Tag = treamentRecord;
                if (donThuoc.Tag != null)
                    donThuoc.loadPrecrciption(BillInforDAO.Instance.getPrescriptionByBillID(BillDAO.Instance.getBillByTreamentRecord((donThuoc.Tag as TreamentRecordsDTO).ID).ID));

            }
        }


        private void btnLogout_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void btnDonThuoc_Click( object sender, EventArgs e ) {
            donThuoc.BringToFront();
        }


        private void btnKhamLamSang_Click( object sender, EventArgs e ) {
            khamLamSang.BringToFront();
        }

        private void btnLichSuKhamChuaBenh_Click( object sender, EventArgs e ) {
            lichSuKhamChuaBenh.BringToFront();
        }

    }
}
