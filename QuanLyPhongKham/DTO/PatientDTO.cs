using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class PatientDTO {
        public PatientDTO(DataRow row) {
            this.ID = (int) row["ID"];
            this.branchID = (int) row["branchID"];
            this.name = row["name"].ToString();
            this.birthday = DateTime.Parse(row["birthday"].ToString());
            this.sex = (bool)row["sex"] ? "Nam" : "Nữ";
            this.phoneNumber = row["phoneNumber"].ToString();
            this.address = row["address"].ToString();
        }
        private int iD;
        private int branchID;
        private string name;
        private DateTime birthday;
        private string sex;
        private string phoneNumber;
        private string address;

        public int BranchID { get => branchID; set => branchID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
