using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class QuanLy : Form {
        public QuanLy() {
            InitializeComponent();
        }

        private void Quanliload( object sender, EventArgs e ) {
            quanLyNhanVien.BringToFront();
        }


        private void btnLogout_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void btnQuanLyNhanVien_Click( object sender, EventArgs e ) {
            quanLyNhanVien.BringToFront();
        }


        private void btnDuLieuDiemDanh_Click( object sender, EventArgs e ) {
            duLieuDiemDanh.BringToFront();
        }


        private void btnQuanLyBangGia_Click( object sender, EventArgs e ) {
            quanLyBangGia.BringToFront();
        }
    }
}
