using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class RoomDTO {
        private int roomNumber;
        private int dentistID;
        private int assistantID;
        public RoomDTO(DataRow row ) {
            this.roomNumber = (int)row["roomNumber"];
            this.dentistID = (int) row["dentistID"];
            this.assistantID = (int) row["assistantID"];
        }
        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public int DentistID { get => dentistID; set => dentistID = value; }
        public int AssistantID { get => assistantID; set => assistantID = value; }
    }
}
