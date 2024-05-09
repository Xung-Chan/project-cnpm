namespace QuanLyPhongKham.GUI {
    partial class DoiMatKhau {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNewPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnChangePass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxConfirmPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxNewPass);
            this.panel1.Location = new System.Drawing.Point(131, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 147);
            this.panel1.TabIndex = 20;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(66, 77);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 19;
            this.lblError.Visible = false;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(105, 104);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(133, 23);
            this.btnChangePass.TabIndex = 18;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // tbxConfirmPass
            // 
            this.tbxConfirmPass.Location = new System.Drawing.Point(145, 46);
            this.tbxConfirmPass.Name = "tbxConfirmPass";
            this.tbxConfirmPass.Size = new System.Drawing.Size(200, 22);
            this.tbxConfirmPass.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.Location = new System.Drawing.Point(145, 3);
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.Size = new System.Drawing.Size(200, 22);
            this.tbxNewPass.TabIndex = 13;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 171);
            this.Controls.Add(this.panel1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNewPass;
    }
}