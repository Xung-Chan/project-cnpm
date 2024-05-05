using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class DentistDAO {
        private static DentistDAO instance;
        private DentistDAO() { }

        public static DentistDAO Instance {
            get {
                if (instance == null)
                    instance = new DentistDAO();
                return instance;
            }
            private set => instance = value;
        }
        public EmployeeDTO getEmployeeByID(int id ) {
            return EmployeeDAO.Instance.getEmployeeByID(id);
        }
    }
}
