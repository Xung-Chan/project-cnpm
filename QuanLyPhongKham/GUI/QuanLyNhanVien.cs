﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class QuanLyNhanVien : UserControl {
        public QuanLyNhanVien() {
            InitializeComponent();
        }

        private void btnAddEmployee_Click( object sender, EventArgs e ) {
            DangKyNhanVien dk = new DangKyNhanVien();
            this.Parent.Hide();
            dk.ShowDialog();
            this.Parent.Show();
        }
    }
}