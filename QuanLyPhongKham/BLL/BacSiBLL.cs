using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.BLL {
    public class BacSiBLL {
        private static BacSiBLL instance;
        private BacSiBLL() { }

        public static BacSiBLL Instance {
            get {
                if (instance == null)
                    instance = new BacSiBLL();
                return instance;
            }
            private set => instance = value;
        }

        public List<PatientDTO> getAllPatients() {
            return PatientDAO.Instance.getAllPatient();
        }
    }
}
