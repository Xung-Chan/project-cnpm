using QuanLyPhongKham.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.BLL
{
    public class EmployeeBLL
    {
        public static string checkLoginBLL(string username, string password)
        {
            if (EmployeeDAO.Instance.checkLogin(username, password)){

                string role =(string) DataProvier.Instance.ExecuteScalar("select p.name from Employee e,Position p where e.positionID = p.ID and @username = phoneNumber and @password = password", new string[] { username, password });
                return role;
            }
            return null;
        }
    }
}
