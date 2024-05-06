using iTextSharp.text;
using iTextSharp.text.pdf;
using QuanLyPhongKham.BLL;
using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyPhongKham.GUI {
    public partial class BacSi : Form {
        public BacSi() {
            InitializeComponent();
            khamLamSang.BringToFront();
        }

        private void Bacsi_Load( object sender, EventArgs e ) {
            int roomNumber = RoomDAO.Instance.getRoomByDentistID((this.Tag as EmployeeDTO).ID).RoomNumber;
            Queue<PatientTreamentNeedsDTO> patientList = BacSiBLL.Instance.QueuePatient[roomNumber];
            foreach (PatientTreamentNeedsDTO item in patientList) {
                ListViewItem lvwItem = new ListViewItem(item.Patient.ID.ToString());
                lvwItem.SubItems.Add(item.Patient.Name);
                lvwItem.Tag = item;
                lvwPatient.Items.Add(lvwItem);
            }
        }



        private void lvwPatient_SelectedIndexChanged( object sender, EventArgs e ) {
            if (lvwPatient.SelectedItems.Count == 1 ) {
                PatientTreamentNeedsDTO patient = (lvwPatient.SelectedItems[0].Tag as PatientTreamentNeedsDTO);
                //load information to textbox
                tbxID.Text = patient.Patient.ID.ToString();
                tbxCCCD.Text = patient.Patient.CCCD.ToString();
                tbxBirthday.Text = patient.Patient.Birthday.Date.ToString("dd/MM/yyyy");
                tbxName.Text = patient.Patient.Name.ToString();
                tbxPhoneNumber.Text = patient.Patient.PhoneNumber.ToString();
                tbxSex.Text = patient.Patient.Sex.ToString();
                //loaf listview nhu cầu điều trị
                lvwTreamentNeeds.Items.Clear();
                foreach (TreatmentNeedsDTO treament in patient.Treatments) {
                    ListViewItem item = new ListViewItem(treament.Name);
                    lvwTreamentNeeds.Items.Add(item);
                }
                //load lịch sử khám chữa bệnh
                lichSuKhamChuaBenh.loadTreamentRecord(int.Parse(tbxID.Text));
               
                TreamentRecordsDTO treamentRecord = TreamentRecordsDAO.Instance.getLastestTreamentRecordOfPatient(int.Parse(tbxID.Text));
                khamLamSang.Tag = treamentRecord;
                donThuoc.Tag = treamentRecord;
                if (donThuoc.Tag != null)
                    donThuoc.loadPrecrciption(BillInforDAO.Instance.getPrescriptionByBillID(BillDAO.Instance.getBillByTreamentRecord((donThuoc.Tag as TreamentRecordsDTO).ID).ID));

            }
        }


        private void btnLogout_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void btnDonThuoc_Click( object sender, EventArgs e ) {
            donThuoc.BringToFront();
        }


        private void btnKhamLamSang_Click( object sender, EventArgs e ) {
            khamLamSang.BringToFront();
        }

        private void btnLichSuKhamChuaBenh_Click( object sender, EventArgs e ) {
            lichSuKhamChuaBenh.BringToFront();
        }

        private void btnPrintPrescription_Click( object sender, EventArgs e ) {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream("don_thuoc.pdf", FileMode.Create));

            document.Open();
            BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD);
            // ĐƠN THUỐC
            Paragraph header = new Paragraph("ĐƠN THUỐC", font);
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);

            // Tạo bảng danh sách thuốc
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;
            table.SpacingBefore = 10f;
            table.SpacingAfter = 10f;

            // Thêm tiêu đề cho các cột của bảng
            PdfPCell cell1 = new PdfPCell(new Phrase("Tên Thuốc",font));
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell1);

            PdfPCell cell2 = new PdfPCell(new Phrase("Số Lượng",font));
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell2);

            // Thêm dữ liệu cho các hàng của bảng
            table.AddCell("Paracetamol");
            table.AddCell("2 viên");

            table.AddCell("Ibuprofen");
            table.AddCell("1 viên");

            // Thêm bảng vào tài liệu PDF
            document.Add(table);

            // Thêm thông tin bác sĩ và ngày xuất đơn thuốc
            Paragraph footer = new Paragraph("Bác Sĩ Kê: Dr. Nguyễn Văn B", font);
            footer.Alignment = Element.ALIGN_RIGHT;
            document.Add(footer);

            Paragraph date = new Paragraph("Ngày Xuất Đơn: 05/05/2024", font);
            date.Alignment = Element.ALIGN_RIGHT;
            document.Add(date);

            document.Close();

            // Mở tệp PDF sau khi tạo
            System.Diagnostics.Process.Start("don_thuoc.pdf");
        }
    }
}
