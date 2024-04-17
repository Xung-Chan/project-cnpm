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
