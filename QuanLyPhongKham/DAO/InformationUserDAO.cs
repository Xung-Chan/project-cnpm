using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO
{
    public class InformationUserDAO
    {
        private static InformationUserDAO instance;
        private InformationUserDAO() { }

        public static InformationUserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InformationUserDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public Boolean isExistUserID(string userID)
        {
            string query = "SELECT COUNT(*) FROM INFORMATION_USER WHERE MaUser = @userID";
            int row = DataProvier.Instance.ExecuteScalar(query,new string[] {userID});
            return row == 1;
        }
    }
}
