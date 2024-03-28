using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private AccountDAO() { }

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public Boolean checkLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM TAI_KHOAN WHERE Username = @username and Password = @password";
            int row = DataProvier.Instance.ExecuteScalar(query,new string[] {username, password });
            if (row == 1) { 
                return true;
            }
            return false;
        }
        
    }
}
