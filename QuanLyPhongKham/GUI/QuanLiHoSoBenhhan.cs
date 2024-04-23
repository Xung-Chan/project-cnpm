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
        Dictionary<string,Queue<PatientDTO>> roomPatientQueue = new Dictionary<string, Queue<PatientDTO>>();
        public QuanLiHoSoBenhhan() {
            InitializeComponent();
            loadQueue();

        }
        public void loadQueue() {
            List<RoomDTO> rooms = LeTanBLL.Instance.loadQueue();
            foreach(RoomDTO room in rooms) {
                string nameRoom = room.Name;
                roomPatientQueue.Add(nameRoom, new Queue<PatientDTO>());
                cbbQueue.Items.Add(nameRoom);
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
            loadPatient(patient);
        }
        private void loadPatient( PatientDTO patient ) {
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
            btnSearch.Tag = patient;

        }

        private void tbxSearch_KeyPress( object sender, KeyPressEventArgs e ) {
            if (e.KeyChar == (char) Keys.Enter) {
                btnSearch_Click(sender, e);
            }
        }

        private void btnAddPatient_Click( object sender, EventArgs e ) {
            ThemBenhNhan tbn = new ThemBenhNhan();
            this.Parent.Hide();
            tbn.ShowDialog();
            this.Parent.Show();
        }

        private void btnUpdatePatient_Click( object sender, EventArgs e ) {
            if (btnSearch.Tag == null) {
                MessageBox.Show("Vui lòng chọn bệnh nhân trước");
                return;
            }
            ThemBenhNhan tbn = new ThemBenhNhan(btnSearch.Tag as PatientDTO);
            this.Parent.Hide();
            tbn.ShowDialog();
            this.Parent.Show();
        }

        private void btnAddQueue_Click( object sender, EventArgs e ) {
            roomPatientQueue[cbbQueue.SelectedItem.ToString()].Enqueue(btnSearch.Tag as PatientDTO);
            MessageBox.Show("Thêm vào phòng chờ thành công");
        }
    }
}
