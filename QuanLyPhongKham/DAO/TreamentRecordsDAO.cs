using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class TreamentRecordsDAO {
        private static TreamentRecordsDAO instance;

        public static TreamentRecordsDAO Instance {
            get {
                if (instance == null)
                    instance = new TreamentRecordsDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<TreamentRecordsDTO> getAllTreamentRecordsByPatientID(int patientID) {
            List<TreamentRecordsDTO> list = new List<TreamentRecordsDTO>();
            string query = String.Format("select * from TreamentRecords where patientID = {0}", patientID);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                list.Add(new TreamentRecordsDTO(row));
            }
            return list;
        }
        public bool insertTreamentRecord(int patientID, int dentistID) {
            string query = String.Format("insert into TreamentRecords(patientID, dentistID, date) values ({0}, {1}, '{2}')", patientID, dentistID,DateTime.Now);
            int check = DataProvider.Instance.ExecuteNonQuery(query);
            return check > 0;
        }
        public TreamentRecordsDTO getLastestTreamentRecordOfPatient(int patientID) {
            string query = String.Format("select top(1) * from TreamentRecords where patientID ={0} order by ID desc", patientID);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new TreamentRecordsDTO(row);

            }
            return null;
        }
    }
}
