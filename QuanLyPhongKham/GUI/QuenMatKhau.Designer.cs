namespace QuanLyPhongKham.GUI {
    partial class QuenMatKhau {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNewPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(164, 3);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(200, 22);
            this.tbxID.TabIndex = 0;
            this.tbxID.TextChanged += new System.EventHandler(this.tbxID_TextChanged);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(164, 52);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(200, 22);
            this.tbxEmail.TabIndex = 1;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email đã đăng kí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // tbxConfirmPass
            // 
            this.tbxConfirmPass.Location = new System.Drawing.Point(164, 129);
            this.tbxConfirmPass.Name = "tbxConfirmPass";
            this.tbxConfirmPass.Size = new System.Drawing.Size(200, 22);
            this.tbxConfirmPass.TabIndex = 15;
            this.tbxConfirmPass.TextChanged += new System.EventHandler(this.tbxConfirmPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.Location = new System.Drawing.Point(164, 95);
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.Size = new System.Drawing.Size(200, 22);
            this.tbxNewPass.TabIndex = 13;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(116, 198);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(133, 23);
            this.btnChangePass.TabIndex = 18;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.tbxID);
            this.panel1.Controls.Add(this.btnChangePass);
            this.panel1.Controls.Add(this.tbxEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxConfirmPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxNewPass);
            this.panel1.Location = new System.Drawing.Point(62, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 247);
            this.panel1.TabIndex = 19;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(161, 163);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 19;
            this.lblError.Visible = false;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 298);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            this.Load += new System.EventHandler(this.QuenMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNewPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblError;
    }
}