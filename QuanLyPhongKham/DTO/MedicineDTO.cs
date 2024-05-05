using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class MedicineDTO {
        private int iD;
        private int stock;
        public MedicineDTO(DataRow row ) {
            this.iD = (int) row["ID"];
            this.stock = (int) row["stock"];
        }
        public int ID { get => iD; set => iD = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
