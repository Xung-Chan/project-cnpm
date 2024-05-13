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
        public List<ServiceDTO> getServiceAll() {
            List<ServiceDTO> List = new List<ServiceDTO>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Service");
            foreach (DataRow row in dt.Rows) {
                ServiceDTO service = new ServiceDTO(row);
                List.Add(service);
            }
            return List;
        }
        public int insertService( ServiceDTO service ) {
            string query;
            if (service.ID == -1) {
                query = "insert into Service( name, unit, price , note) values( @name , @unit , @price , @note )";
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { service.Name.ToString(), service.Unit.ToString(), service.Price, service.Note.ToString() });
            }
            query = "UPDATE Service SET ID = @id, name = @name, unit = @unit, price = @price, note = @note WHERE ID = @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { service.Name.ToString(), service.Unit.ToString(), service.Price, service.Note.ToString() });
            //tí làm update

        }
        public List<ServiceDTO> findServiceByName( string name ) {
            DataTable table = DataProvider.Instance.ExecuteQuery(String.Format("select * from Service where name like '%{0}%'", name.Trim()));
            List<ServiceDTO> list = new List<ServiceDTO>();
            foreach (DataRow row in table.Rows) {
                list.Add(new ServiceDTO(row));
            }
            return list;
        }
        public ServiceDTO getServiceByName( string name ) {
            DataTable table = DataProvider.Instance.ExecuteQuery(String.Format("select * from Service where name = '{0}'", name));
            foreach (DataRow row in table.Rows) {
                return new ServiceDTO(row);
            }
            return null;
        }
        public bool DeleteService( ServiceDTO service ) {
            int checkeds = (int) DataProvider.Instance.ExecuteScalar(String.Format("Select count(*) from Medicine where ID = '{0}'", service.ID));
            if (checkeds > 0) {
                DataProvider.Instance.ExecuteNonQuery(String.Format("Delete from Medicine where ID = '{0}'", service.ID));

            }
            int check = DataProvider.Instance.ExecuteNonQuery(String.Format("Delete from Service where ID = '{0}'", service.ID));
            return check > 0;

        }
    }
}
