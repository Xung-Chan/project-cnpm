using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
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
            EmployeeDTO employee = EmployeeDAO.Instance.checkLogin(username, password) ;
            if (employee == null) {
                return null;
            }
            if (!recordLogin(employee.ID)) {
                MessageBox.Show("Điểm danh không thành công", "Lỗi điểm danh", MessageBoxButtons.OK);
                return null;
            }
            return PositionDAO.Instance.getNameByID(employee.PositionID);
           
        }
        private static bool recordLogin(int ID) {
            return AttendanceDAO.Instance.insertAttendance(ID);
        }
    }
}
