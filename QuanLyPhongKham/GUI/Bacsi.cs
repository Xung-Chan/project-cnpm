using QuanLyPhongKham.BLL;
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

namespace QuanLyPhongKham.GUI
{
    public partial class BacSi : Form
    {
        public BacSi()
        {
            InitializeComponent();
            kls1.BringToFront();
        }

        private void Bacsi_Load( object sender, EventArgs e ) {
            List<PatientDTO> patientList = BacSiBLL.getAllPatients();
            foreach(PatientDTO item in patientList) {
                ListViewItem lvwItem = new ListViewItem(item.ID.ToString());
                lvwItem.SubItems.Add(item.Name);
                lvwItem.SubItems.Add(item.PhoneNumber);
                lvwPatient.Items.Add(lvwItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            donthuoc1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kls1.BringToFront();
        }
    }
}
