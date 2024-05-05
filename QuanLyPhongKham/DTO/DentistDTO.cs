using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class DentistDTO {
        private int iD;
        private int specicaltyID;
        public DentistDTO(DataRow row ) {
            this.ID = (int) row["ID"];
            this.specicaltyID = (int) row["specialtyID"];
        }
        public int ID { get => iD; set => iD = value; }
        public int SpecicaltyID { get => specicaltyID; set => specicaltyID = value; }
    }
}
