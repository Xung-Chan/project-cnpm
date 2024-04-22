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

namespace QuanLyPhongKham.GUI
{
    public partial class QuanLy : Form
    {
        private bool isCollapsed;
        public QuanLy()
        {
            InitializeComponent();
        }

        private void Quanliload(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                PanelDrop.Height += 10;
                if(PanelDrop.Size == PanelDrop.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                PanelDrop.Height -= 10;
                if (PanelDrop.Size == PanelDrop.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
  
            }
        }

        private void dropbutton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void buttonql_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {
                panel3.Height += 10;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void bcth1_Load(object sender, EventArgs e)
        {

        }
    }
}
