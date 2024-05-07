using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class ThanhToan : UserControl {
        public ThanhToan() {
            InitializeComponent();
        }

        private void ThanhToan_Load( object sender, EventArgs e ) {

        }
        private void loadBillInfor(List<BillInforDTO> list ) {
            lvwBillInfor.Items.Clear();
            int totalFee = 0;
            foreach (BillInforDTO billInfor in list) {
                ServiceDTO service = ServiceDAO.Instance.getServiceByID(billInfor.ServiceID);
                ListViewItem item = new ListViewItem(service.Name);
                item.SubItems.Add(billInfor.Quantity.ToString());
                int price = billInfor.Quantity * service.Price;
                item.SubItems.Add(price.ToString());
                lvwBillInfor.Items.Add(item);
                totalFee += price;
            }
            btnTotalFee.Text = totalFee.ToString();
        }

        private void btnSearch_Click( object sender, EventArgs e ) {
            btnTotalFee.Text = "0";
            List<BillInforDTO> list = BillInforDAO.Instance.getBillInforByBillID(int.Parse(tbxBillID.Text));
            if(list.Count <= 0) {
                MessageBox.Show("Mã hóa đơn không chính xác");
                return;
            }
            loadBillInfor(list);
            
        }

        private void btnPay_Click( object sender, EventArgs e ) {
            if (BillDAO.Instance.payBillByBillID(int.Parse(tbxBillID.Text))) {
                MessageBox.Show("Thanh toán thành công");
            }
            else {
                MessageBox.Show("Thanh toán thất bại");
            }
        }
    }
}
