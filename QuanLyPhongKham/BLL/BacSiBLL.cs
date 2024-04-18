using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.BLL {
    public class BacSiBLL {
        public static List<PatientDTO> getAllPatients() {
            return PatientDAO.Instance.getAllPatient();
        }
    }
}
