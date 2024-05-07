using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class DutyScheduleDTO {
        private int roomNumber;
        private int shiftID;
        private DateTime date;
        private int dentistID;
        private int assistantID;
        public DutyScheduleDTO(DataRow row) {
            this.RoomNumber = (int) row["roomNumber"];
            this.ShiftID = (int) row["shiftID"];
            this.Date = (DateTime) row["date"];
            this.DentistID = (int) row["dentistID"];
            this.AssistantID = (int) row["assistantID"];
        }
        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public int ShiftID { get => shiftID; set => shiftID = value; }
        public DateTime Date { get => date; set => date = value; }
        public int DentistID { get => dentistID; set => dentistID = value; }
        public int AssistantID { get => assistantID; set => assistantID = value; }
    }
}
