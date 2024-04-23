using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Patient");
            foreach(DataRow row in dt.Rows) {
                PatientDTO patient = new PatientDTO(row);
                patientList.Add(patient);
            }
            return patientList;
        }
        public PatientDTO getPatientByPhoneNumber(string phoneNumber ) {
            DataTable table = DataProvider.Instance.ExecuteQuery(String.Format("select * from Patient where phoneNumber = {0}", phoneNumber));
            foreach(DataRow row in table.Rows) {
                return new PatientDTO(row);
            }
            return null;
        }
        public PatientDTO getPatientByID(string id ) {
            DataTable table = DataProvider.Instance.ExecuteQuery(String.Format("select * from Patient where id = {0}", id));
            foreach(DataRow row in table.Rows) {
                return new PatientDTO(row);
            }
            return null;

        }
        public int savePatient(PatientDTO patient) {
            if(getPatientByID(patient.ID.ToString()) != null) {
                //update
            }
            string query = "exec sp_insertPatient @branchID , @name , @birthday , @sex , @phoneNumber , @address , @cccd";
            return  DataProvider.Instance.ExecuteNonQuery(query, new object[] { patient.BranchID.ToString(), patient.Name.ToString(), patient.Birthday, 
                patient.Sex.ToString(), patient.PhoneNumber.ToString(), patient.Address.ToString(), patient.CCCD.ToString() });

        }
    }
}
