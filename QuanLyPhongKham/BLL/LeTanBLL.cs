using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.BLL {
    public class LeTanBLL {
        private static LeTanBLL instance;
        private LeTanBLL() { }

        public static LeTanBLL Instance {
            get {
                if (instance == null)
                    instance = new LeTanBLL();
                return instance;
            }
            private set => instance = value;
        }
        public void savePatient(PatientDTO patient) {
            if (PatientDAO.Instance.savePatient(patient) < 1) {
                MessageBox.Show("Thêm bệnh nhân không thành công", "Có lỗi xảy ra", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Thêm bệnh nhân thành công", "Successfully", MessageBoxButtons.OK);
        }
        public List<RoomDTO> loadQueue() {
            return RoomDAO.Instance.getAllRoom();
        }
    }
}
