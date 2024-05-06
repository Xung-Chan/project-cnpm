using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class BillDAO {
        private static BillDAO instance;
        private BillDAO() { }

        public static BillDAO Instance {
            get {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set => instance = value;
        }
        public bool insertBill(int treamentRecordID) {
            string query = "insert into Bill(treamentRecordID, dateCheckIn) values( @treamentID , @dateCheckIn )";
            int check = DataProvider.Instance.ExecuteNonQuery(query, new object[] { treamentRecordID, DateTime.Now });
            return check > 0;
        }
        public BillDTO getBillByTreamentRecord(int treamentRecordID) {
            string query = String.Format("select * from Bill where treamentRecordID ={0}",treamentRecordID);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new BillDTO(row);
            }
            return null;
        }
    }
}
