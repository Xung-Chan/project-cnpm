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
    public partial class DonThuoc : UserControl {

        public DonThuoc() {
            InitializeComponent();
            loadStockMedicine(MedicineDAO.Instance.getAllMedicine());
        }
        private void loadStockMedicine( List<MedicineDTO> list ) {
            lvwStockMedicine.Items.Clear();
            foreach( MedicineDTO medicine in list ) {
                ListViewItem item = new ListViewItem(medicine.ID.ToString());
                item.SubItems.Add(medicine.Name);
                item.SubItems.Add(medicine.Stock.ToString());
                lvwStockMedicine.Items.Add(item);
            }
        }


        private void tbsSearch_TextChanged( object sender, EventArgs e ) {
           loadStockMedicine(MedicineDAO.Instance.findMedicineByName(tbsSearch.Text));
        }
        public void loadPrecrciption(List<BillInforDTO> prescription ) {
            lvwPrescription.Items.Clear();
            foreach(BillInforDTO billInfor in prescription) {
                ServiceDTO service = ServiceDAO.Instance.getServiceByID(billInfor.ServiceID);
                ListViewItem item = new ListViewItem(service.ID.ToString());
                item.SubItems.Add(service.Name);
                item.SubItems.Add(billInfor.Quantity.ToString());
                lvwPrescription.Items.Add(item);
            }
        }
        private void btnAddMedicine_Click( object sender, EventArgs e ) {
            if(lvwStockMedicine.SelectedItems.Count == 0) {
                MessageBox.Show("Vui lòng chọn thuốc");
                return;
            }
            int billID = BillDAO.Instance.getBillByTreamentRecord((this.Tag as TreamentRecordsDTO).ID).ID;
            int serviceID = int.Parse(lvwStockMedicine.SelectedItems[0].SubItems[0].Text);
            if(BillInforDAO.Instance.insertBillInfor(billID, serviceID, (int) nudQuantity.Value)) {
                MessageBox.Show("Thêm thành công");
                loadPrecrciption(BillInforDAO.Instance.getPrescriptionByBillID(BillDAO.Instance.getBillByTreamentRecord((this.Tag as TreamentRecordsDTO).ID).ID));
            }
            else {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
