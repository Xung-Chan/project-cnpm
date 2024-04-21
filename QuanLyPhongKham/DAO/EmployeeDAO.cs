using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        private EmployeeDAO() { }

        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public EmployeeDTO checkLogin(string phoneNumber, string password)
        {
            string query = "select * from Employee WHERE phoneNumber = @phoneNumber and password = @password";
            DataTable table = DataProvier.Instance.ExecuteQuery(query, new object[] { phoneNumber, password });
            if (table.Rows.Count == 1) {
                foreach (DataRow row in table.Rows) {
                    return new EmployeeDTO(row);
                }
                
            }
            return null;
        }
    }
}
