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

namespace QuanLyPhongKham.GUI {
    public partial class BacSi : Form {
        public BacSi() {
            InitializeComponent();
            khamLamSang.BringToFront();
        }

        private void Bacsi_Load( object sender, EventArgs e ) {
            Queue<PatientTreamentNeedsDTO> patientList = BacSiBLL.Instance.QueuePatient[101];
            foreach (PatientTreamentNeedsDTO item in patientList) {
                ListViewItem lvwItem = new ListViewItem(item.ID.ToString());
                lvwItem.SubItems.Add(item.Name);
                lvwItem.Tag = item;
                lvwPatient.Items.Add(lvwItem);
            }
        }



        private void lvwPatient_SelectedIndexChanged( object sender, EventArgs e ) {
            if (lvwPatient.SelectedItems.Count > 0) {
                PatientDTO patient = (lvwPatient.SelectedItems[0].Tag as PatientDTO);
                tbxID.Text = patient.ID.ToString();
                tbxCCCD.Text = patient.CCCD.ToString();
                tbxBirthday.Text = patient.Birthday.ToString();
                tbxAddress.Text = patient.Address.ToString();
                tbxName.Text = patient.Name.ToString();
                tbxPhoneNumber.Text = patient.PhoneNumber.ToString();
                tbxSex.Text = patient.Sex.ToString();

            }
        }


        private void btnLogout_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void btnDonThuoc_Click( object sender, EventArgs e ) {
            donthuoc.BringToFront();
        }

        private void btnDichVuDaKe_Click( object sender, EventArgs e ) {
            dichVuDaKe.BringToFront();
        }

        private void btnKhamLamSang_Click( object sender, EventArgs e ) {
            khamLamSang.BringToFront();
        }

        private void btnLichSuKhamChuaBenh_Click( object sender, EventArgs e ) {
            lichSuKhamChuaBenh.BringToFront();
        }
    }
}
