using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class MedicineDAO {
        private static MedicineDAO instance;
        private MedicineDAO() { }

        public static MedicineDAO Instance {
            get {
                if (instance == null)
                    instance = new MedicineDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<MedicineDTO> getAllMedicine() {
            string query = "select * from Medicine m, Service s where m.ID = s.ID";
            List<MedicineDTO> list = new List<MedicineDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                list.Add(new MedicineDTO(row));
            }
            return list;
        }
        public List<MedicineDTO> findMedicineByName(string name) {
            string query = String.Format("select * from Medicine m, Service s where m.ID = s.ID and name like '%{0}%'", name);
            List<MedicineDTO> list = new List<MedicineDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                list.Add(new MedicineDTO(row));
            }
            return list;
        }
    }
}
