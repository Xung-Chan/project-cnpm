using QuanLyPhongKham.BLL;
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

namespace QuanLyPhongKham.GUI
{
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void AddService_Load(ServiceDTO service)
        {   
            tbxName.Text = service.Name.ToString();
            tbxPrice.Text = service.Price.ToString();
            tbxUnit.Text = service.Unit.ToString();
            tbxNote.Text = service.Note.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int iD = -1;
            string name = tbxName.Text;
            string unit = tbxUnit.Text;
            int price = int.Parse(tbxPrice.Text);
            string note = tbxNote.Text;
            ServiceDTO service = new ServiceDTO(iD, name, unit, price ,note);
          
            if (ServiceDAO.Instance.insertService(service) >1)
            {
                MessageBox.Show("Thêm dịch vụ không thành công", "Có lỗi xảy ra", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Thêm dịch vụ thành công", "Successfully", MessageBoxButtons.OK);

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            tbxPrice.Text= "";
            tbxUnit.Text ="";
            tbxNote.Text = "";
        }
        private void Addservice_Load(object sender, EventArgs e)
        {
           
          
        }
        private void tbxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddService_Load_1( object sender, EventArgs e ) {

        }
    }
}
