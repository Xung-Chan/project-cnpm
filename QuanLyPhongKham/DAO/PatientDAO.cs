using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class PatientDAO {
        private static PatientDAO instance;
        private PatientDAO() { }

        public static PatientDAO Instance {
            get {
                if (instance == null)
                    instance = new PatientDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<PatientDTO> getAllPatient() {
            List<PatientDTO> patientList = new List<PatientDTO>();
            DataTable dt = DataProvier.Instance.ExecuteQuery("select * from Patient");
            foreach(DataRow row in dt.Rows) {
                PatientDTO patient = new PatientDTO(row);
                patientList.Add(patient);
            }
            return patientList;
        }
    }
}
