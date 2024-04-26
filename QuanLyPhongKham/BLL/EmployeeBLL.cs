using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.BLL {
    public class EmployeeBLL {
        private static EmployeeBLL instance;
        private EmployeeBLL() { }

        public static EmployeeBLL Instance {
            get {
                if (instance == null)
                    instance = new EmployeeBLL();
                return instance;
            }
            set => instance = value;
        }

        public string checkLoginBLL( string username, string password ) {
            EmployeeDTO employee = EmployeeDAO.Instance.checkLogin(username, password);
            if (employee == null) {
                return null;
            }
            if (!recordLogin(employee.ID)) {
                MessageBox.Show("Điểm danh không thành công", "Lỗi điểm danh", MessageBoxButtons.OK);
                return null;
            }
            return PositionDAO.Instance.getNameByID(employee.PositionID);

        }
        private bool recordLogin( int ID ) {
            return AttendanceDAO.Instance.insertAttendance(ID);
        }
        public string insertEmployee( EmployeeDTO employee ) {
            if (EmployeeDAO.Instance.insertEmployee(employee) > 0) {
                return "Thêm nhân viên thành công";
            }
            return "Thêm nhân viên không thành công";
        }
    }
}
