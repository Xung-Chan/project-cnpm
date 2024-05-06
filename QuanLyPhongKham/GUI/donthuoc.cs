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
            loadListMedicine(MedicineDAO.Instance.getAllMedicine());
        }
        private void loadListMedicine( List<MedicineDTO> list ) {
            lvwStockMedicine.Items.Clear();
            foreach( MedicineDTO medicine in list ) {
                ListViewItem item = new ListViewItem(medicine.ID.ToString());
                item.SubItems.Add(medicine.Name);
                item.SubItems.Add(medicine.Stock.ToString());
                lvwStockMedicine.Items.Add(item);
            }
        }

        private void lvwStockMedicine_SelectedIndexChanged( object sender, EventArgs e ) {

        }

        private void tbsSearch_TextChanged( object sender, EventArgs e ) {
           loadListMedicine(MedicineDAO.Instance.findMedicineByName(tbsSearch.Text));
        }

        private void btnAddMedicine_Click( object sender, EventArgs e ) {
            if(lvwStockMedicine.SelectedItems.Count == 0) {
                MessageBox.Show("Vui lòng chọn thuốc");
                return;
            }
            if (lvwPrescription.Columns[0].)
                ListViewItem item = new ListViewItem(lvwStockMedicine.SelectedItems[0].Text);
            item.SubItems.Add(lvwStockMedicine.SelectedItems[0].SubItems[1].Text);
            item.SubItems.Add(nudQuantity.Value.ToString());
            lvwPrescription.Items.Add(item);
        }
    }
}
