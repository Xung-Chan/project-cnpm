using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class DutyScheduleDAO {
        private static DutyScheduleDAO instance;
        private DutyScheduleDAO() { }

        public static DutyScheduleDAO Instance {
            get {
                if (instance == null)
                    instance = new DutyScheduleDAO();
                return instance;
            }
            private set => instance = value;
        }
        public DutyScheduleDTO getDutyScheduleByDentistID(int dentist ) {
            string query ="select * from DutySchedule where dentistID = @dentistID and date= @date and shiftID = @shift";
            int shiftID = 0;
            if(DateTime.Now.Hour >= 13 && DateTime.Now.Hour <= 18) {
                shiftID = 2;
            }
            else if(DateTime.Now.Hour >= 7 && DateTime.Now.Hour <= 11) {
                shiftID = 1;
            }
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { dentist, DateTime.Now, shiftID });
            foreach(DataRow row in table.Rows) {
                return new DutyScheduleDTO(row);
            }
            return null;

        }
        public DutyScheduleDTO getDutyScheduleByRoomNumber(int roomNumber ) {
            string query ="select * from DutySchedule where roomNumber= @room and date= @date and shiftID = @shift";
            int shiftID = 0;
            if(DateTime.Now.Hour >= 13 && DateTime.Now.Hour <= 18) {
                shiftID = 2;
            }
            else if(DateTime.Now.Hour >= 7 && DateTime.Now.Hour <= 11) {
                shiftID = 1;
            }
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { roomNumber, DateTime.Now, shiftID });
            foreach(DataRow row in table.Rows) {
                return new DutyScheduleDTO(row);
            }
            return null;

        }
    }
}
