using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.DAO {
    public class AttendanceDAO {
        private static AttendanceDAO instance;
        private AttendanceDAO() { }
        public static AttendanceDAO Instance {
            get {
                if (instance == null)
                    instance = new AttendanceDAO();
                return instance;
            }
            private set => instance = value;
        }
        public bool insertAttendance(int employeeID) {
            int data = DataProvider.Instance.ExecuteNonQuery("exec sp_insertAttendanceData @employeeID , @time", new object[] { employeeID, DateTime.Now });
            if (data < 1) {
                return false;
            }
            return true;
        }
    }
}
