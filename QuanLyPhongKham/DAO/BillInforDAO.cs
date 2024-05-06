using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class BillInforDAO {
        private static BillInforDAO instance;
        private BillInforDAO() { }

        public static BillInforDAO Instance {
            get {
                if (instance == null)
                    instance = new BillInforDAO();
                return instance;
            }
            private set => instance = value;
        }
        public bool insertBillInfor(BillInforDTO billInfor ) {
            string query = "insert into BillInfor values( @bill , @service , @quantity)";
            int check = DataProvider.Instance.ExecuteNonQuery( query , new object[] {billInfor.BillID, billInfor.ServiceID, billInfor.Quantity});
            return check > 0;
        }
    }
}
