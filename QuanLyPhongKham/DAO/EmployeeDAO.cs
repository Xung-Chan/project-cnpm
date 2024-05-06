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
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { phoneNumber, password });
            if (table.Rows.Count == 1) {
                foreach (DataRow row in table.Rows) {
                    return new EmployeeDTO(row);
                }
                
            }
            return null;
        }
        public int insertEmployee(EmployeeDTO employee) {
            int sex = employee.Sex.Equals("Nam") ? 1 : 0;
            string query = "exec sp_insertEmployee @positionID , @branchID , @name , @birthday , @sex , @phoneNumber , @address , @email";
            int check = DataProvider.Instance.ExecuteNonQuery(query, new object[] { employee.PositionID, employee.BranchID, employee.Name, employee.Birthday, sex, employee.PhoneNumber, employee.Address, employee.Email });
            return check;

        }
        public EmployeeDTO getEmployeeByID(int id ) {
            string query = String.Format("select * from Employee where ID = {0}", id);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new EmployeeDTO(row);
            }
            return null;
        }
        public EmployeeDTO getEmployeeByPhoneNumber(string phoneNumber) {
            string query = String.Format("select * from Employee where phoneNumber = {0}", phoneNumber);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new EmployeeDTO(row);
            }
            return null;

        }
    }
}
