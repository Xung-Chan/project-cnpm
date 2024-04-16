using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Boolean checkLogin(string phoneNumber, string password)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE phoneNumber = @phoneNumber and password = @password";
            int row =(int) DataProvier.Instance.ExecuteScalar(query, new string[] { phoneNumber, password });
            if (row == 1)
            {
                return true;
            }
            return false;
        }

    }
}
