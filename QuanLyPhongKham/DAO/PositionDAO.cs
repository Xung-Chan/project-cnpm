using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    internal class PositionDAO {
        private static PositionDAO instance;
        private PositionDAO() { }

        internal static PositionDAO Instance {
            get {
                if (instance == null)
                    instance = new PositionDAO();
                return instance;
            }
            private set => instance = value;
        }
        public string getNameByID(int id) {
            string query = "select name from Position where ID = " + id;
            string name = (string)DataProvier.Instance.ExecuteScalar(query);
            return name;
        }
    }
}
