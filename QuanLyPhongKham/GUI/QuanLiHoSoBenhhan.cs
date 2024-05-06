using QuanLyPhongKham.BLL;
using QuanLyPhongKham.DAO;
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
    public partial class QuanLiHoSoBenhhan : UserControl {
        //private Dictionary<int, Queue<PatientDTO>> roomPatientQueue = new Dictionary<int, Queue<PatientDTO>>();

        public QuanLiHoSoBenhhan() {
            InitializeComponent();
            loadListPatient(PatientDAO.Instance.getAllPatient());

        }
        public void loadRoom() {
            List<RoomDTO> rooms = RoomDAO.Instance.getAllRoom();
            foreach (RoomDTO room in rooms) {
                int nameRoom = room.RoomNumber;
                //if(BacSiBLL.Instance.QueuePatient.ContainsKey(nameRoom) == false) {
                //    BacSiBLL.Instance.QueuePatient.Add(nameRoom, new Queue<PatientTreamentNeedsDTO>());
                //}
                cbbQueue.Items.Add(nameRoom);
            }
        }
        public void loadTreamentNeeds() {
            List<TreatmentNeedsDTO> list = TreatmentNeedsDAO.Instance.getAllTreatmentNeeds();
            foreach (TreatmentNeedsDTO tmn in list) {
                clbListTreatmentNeeds.Items.Add(tmn.Name);
            }
        }
        private void btnSearch_Click( object sender, EventArgs e ) {
            PatientDTO patient = PatientDAO.Instance.getPatientByPhoneNumber(tbxSearch.Text.Trim());
            if (patient == null) {
                if (MessageBox.Show("Bệnh nhân không có thông tin trong hồ sơ phòng khám.\nBạn có muốn thêm tạo hồ sơ ?", "Không tìm thấy kết quả", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    btnAddPatient_Click(sender, e);
                }
                tbxSearch.Text = "";
                return;
            }
            List<PatientDTO> result = new List<PatientDTO>();
            result.Add(patient);
            loadListPatient(result);
            tbxSearch.Text = "";
            clearThongTinBenhNhan();
        }
        private void loadPatient( PatientDTO patient ) {
            btnPatientID.Text = patient.ID.ToString();
            btnPatientID.Tag = patient;
            btnName.Text = patient.Name.ToString();
            int birthYear = patient.Birthday.Year;
            btnBirthYear.Text = birthYear.ToString();
            btnYearOld.Text = (DateTime.Now.Year - birthYear).ToString();
            btnAddress.Text = patient.Address.ToString();
            btnPhoneNumber.Text = patient.PhoneNumber.ToString();
            btnCCCD.Text = patient.CCCD.ToString();
            if (patient.Sex) {
                rdbMale.Checked = true;
            }
            else {
                rdbFemale.Checked = true;
            }
            cbxIsOldPatient.Checked = ScheduleDAO.Instance.checkOldPatient(patient.ID);
        }

        private void loadListPatient( List<PatientDTO> list ) {
            lvwListPatient.Items.Clear();
            foreach (PatientDTO patient in list) {
                ListViewItem lvwItem = new ListViewItem(patient.ID.ToString());
                lvwItem.SubItems.Add( patient.Name.ToString() );
                lvwItem.Tag= patient;
                lvwListPatient.Items.Add( lvwItem );
            }
        }

        private void tbxSearch_KeyPress( object sender, KeyPressEventArgs e ){
            if (e.KeyChar == (char) Keys.Enter) {
                btnSearch_Click(sender, e);
                tbxSearch.Text = "";
            }
        }

        private void btnAddPatient_Click( object sender, EventArgs e ) {
            ThemBenhNhan tbn = new ThemBenhNhan();
            this.Parent.Hide();
            tbn.ShowDialog();
            this.Parent.Show();
        }

        private void btnUpdatePatient_Click( object sender, EventArgs e ) {
            if (btnPatientID.Tag == null) {
                MessageBox.Show("Vui lòng chọn bệnh nhân trước");
                return;
            }
            ThemBenhNhan tbn = new ThemBenhNhan(btnPatientID.Tag as PatientDTO);
            this.Parent.Hide();
            tbn.ShowDialog();
            loadListPatient(PatientDAO.Instance.getAllPatient());
            clearThongTinBenhNhan();
            this.Parent.Show();
        }

        private void btnAddQueue_Click( object sender, EventArgs e ) {
            if(LeTanBLL.Instance.checkQuanLiHoSoBenhNhan(clbListTreatmentNeeds.CheckedItems, cbbQueue.Text) == false) {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            //Đẩy bệnh nhân vào hàng đợi của phòng bác sĩ
            PatientTreamentNeedsDTO patient = new PatientTreamentNeedsDTO(lvwListPatient.SelectedItems[0].Tag as PatientDTO);
            foreach(string treatmentName in clbListTreatmentNeeds.CheckedItems) {
                TreatmentNeedsDTO treatment = TreatmentNeedsDAO.Instance.getTreatmentNeeds(treatmentName);
                patient.Treatments.Add(treatment);
            }
            BacSiBLL.Instance.QueuePatient[(int)cbbQueue.SelectedItem].Enqueue(patient);
            //Tạo TreamentRecord,Bill và BillInfor (mặc định tiền dịch vụ khám-hồ sơ
            TreamentRecordsDAO.Instance.insertTreamentRecord(int.Parse(btnPatientID.Text), RoomDAO.Instance.getRoomByRoomNumber((int) cbbQueue.SelectedItem).DentistID);
            TreamentRecordsDTO treamentRecord = TreamentRecordsDAO.Instance.getLastestTreamentRecordOfPatient(int.Parse(btnPatientID.Text));
            BillDAO.Instance.insertBill(treamentRecord.ID);
            BillDTO bill = BillDAO.Instance.getBillByTreamentRecord(treamentRecord.ID);
            BillInforDAO.Instance.insertBillInfor(bill.ID, 1,1);//Mặc định thêm dịch vụ khám hồ sơ (parameter 2,3 = 1,1)
            MessageBox.Show("Thêm vào phòng chờ thành công");
        }


        private void lvwListPatient_SelectedIndexChanged( object sender, EventArgs e ) {
            if(lvwListPatient.SelectedItems.Count > 0) {
                loadPatient(lvwListPatient.SelectedItems[0].Tag as PatientDTO);
            }
        }
        private void clearThongTinBenhNhan() {
            btnPatientID.Text = "";
            btnAddress.Text = "";
            btnBirthYear.Text = "";
            btnCCCD.Text = "";
            btnName.Text = "";
            btnPhoneNumber.Text = "";
            btnYearOld.Text = "";
            rdbFemale.Checked = false;
            rdbMale.Checked = false;
        }

        private void tbxSearch_TextChanged( object sender, EventArgs e ) {
            List<PatientDTO> list = PatientDAO.Instance.findPatientByPhoneNumber(tbxSearch.Text.Trim());
            loadListPatient(list);
            clearThongTinBenhNhan();
        }

    }
}
