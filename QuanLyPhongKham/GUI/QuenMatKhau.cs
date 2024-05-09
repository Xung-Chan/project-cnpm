using QuanLyPhongKham.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class QuenMatKhau : Form {
        public QuenMatKhau() {
            InitializeComponent();
        }
        private string randomOTP() {
            Random random = new Random();
            return random.Next(999999).ToString("000000");
        }

        private void btnSendOTP_Click( object sender, EventArgs e ) {
            if (lblError.Visible) {
                return;
            }
            string senderMail = "nhomchatkin@gmail.com";
            string password = "nhomchatkin123";
            string receiverMail = tbxEmail.Text.Trim();
            MailMessage mail = new MailMessage(senderMail, receiverMail);
            mail.Subject = "OTP XÁC NHẬN ĐỔI MẬT KHẨU PHÒNG KHÁM";
            mail.Body = "Mã OTP của bạn là:" + randomOTP() + "\nVui lòng không chia sẻ email này với người khác.";
            SmtpClient send = new SmtpClient("smtp.gmail.com");
            send.Port = 587;
            send.UseDefaultCredentials=false;
            send.Credentials = new System.Net.NetworkCredential(senderMail, password);
            send.EnableSsl = true;
            try {
                send.Send(mail);
                MessageBox.Show("Mã OTP đã được gửi đến email của bạn");

            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi gửi email không thành công: " + ex.Message);
            }
        }

        private void tbxID_TextChanged( object sender, EventArgs e ) {
            int ID;
            if(int.TryParse(tbxID.Text, out ID)== false) {
                lblError.Text = "Mã nhân viên không chính xác";
                lblError.Visible = true;
                return;
            }
            if (EmployeeDAO.Instance.findEmployeeByID(ID) == null) {
                lblError.Text = "Mã nhân viên không chính xác";
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;

        }

        private void tbxEmail_TextChanged( object sender, EventArgs e ) {
            if (EmployeeDAO.Instance.findEmployeeByEmail(tbxEmail.Text) == null) {
                lblError.Text = "Email không chính xác";
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;

        }

        private void tbxConfirmPass_TextChanged( object sender, EventArgs e ) {
            if (tbxNewPass.Text != tbxConfirmPass.Text) {
                lblError.Text = "Mật khẩu không trùng khớp";
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;
        }

        private void btnChangePass_Click( object sender, EventArgs e ) {
            if (EmployeeDAO.Instance.changePassword(int.Parse(tbxID.Text), tbxNewPass.Text) == 1) {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
                return;
            }
            MessageBox.Show("Đổi mật khẩu không thành công");
        }

        private void QuenMatKhau_Load( object sender, EventArgs e ) {

        }
    }
}
