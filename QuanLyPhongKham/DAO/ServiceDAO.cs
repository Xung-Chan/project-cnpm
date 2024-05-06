using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class ServiceDAO {
        private static ServiceDAO instance;
        private ServiceDAO() { }
        public static ServiceDAO Instance {
            get {
                if (instance == null)
                    instance = new ServiceDAO();
                return instance;
            }
            private set => instance = value;
        }
        public ServiceDTO getServiceByID(int id) {
            string query = String.Format("select * from Service where ID ={0}", id);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows) {
                return new ServiceDTO(row);
            }
            return null;
        }
    }
}
