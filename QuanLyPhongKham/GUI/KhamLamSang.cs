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
    public partial class KhamLamSang : UserControl
    {
        public KhamLamSang()
        {
            InitializeComponent();
        }

        private void btnSave_Click( object sender, EventArgs e ) {
            TreamentRecordsDTO treamentRecords = this.Tag as TreamentRecordsDTO;
            treamentRecords.Status = tbxStatus.Text;
            treamentRecords.OtherDiseases = tbxOtherDiseases.Text;
            treamentRecords.DrugAllergy = tbxDrugAllergy.Text;
            treamentRecords.Diagnostic = tbxDiagnostic.Text;
            treamentRecords.TreamentDirection = tbxTreatmentDirection.Text;
            treamentRecords.Date = DateTime.Now;
            treamentRecords.Note = tbxNote.Text;
            if(TreamentRecordsDAO.Instance.updateTreamentRecord(treamentRecords)) {
                MessageBox.Show("Đã lưu hồ sơ");
            }
            else {
                MessageBox.Show("Lưu khoogn thành công");
            }
        }
    }
}
