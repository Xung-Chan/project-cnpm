namespace QuanLyPhongKham.GUI
{
    partial class ThemBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbxCCCD = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxSex = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSavePatient = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(49, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 52);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Linen;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(52, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "Thông Tin bệnh nhân";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 524);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.dtpBirthday);
            this.panel3.Controls.Add(this.tbxCCCD);
            this.panel3.Controls.Add(this.tbxAddress);
            this.panel3.Controls.Add(this.tbxPhoneNumber);
            this.panel3.Controls.Add(this.tbxSex);
            this.panel3.Controls.Add(this.tbxName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(49, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 450);
            this.panel3.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SpringGreen;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Location = new System.Drawing.Point(549, 369);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 37);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = " ";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(245, 107);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(411, 22);
            this.dtpBirthday.TabIndex = 2;
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // tbxCCCD
            // 
            this.tbxCCCD.Location = new System.Drawing.Point(245, 315);
            this.tbxCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCCCD.Multiline = true;
            this.tbxCCCD.Name = "tbxCCCD";
            this.tbxCCCD.Size = new System.Drawing.Size(411, 50);
            this.tbxCCCD.TabIndex = 6;
            this.tbxCCCD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(245, 261);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(411, 50);
            this.tbxAddress.TabIndex = 5;
            this.tbxAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(245, 204);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPhoneNumber.Multiline = true;
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(411, 50);
            this.tbxPhoneNumber.TabIndex = 4;
            this.tbxPhoneNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxSex
            // 
            this.tbxSex.Location = new System.Drawing.Point(245, 146);
            this.tbxSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSex.Multiline = true;
            this.tbxSex.Name = "tbxSex";
            this.tbxSex.Size = new System.Drawing.Size(411, 50);
            this.tbxSex.TabIndex = 3;
            this.tbxSex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(245, 39);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(411, 50);
            this.tbxName.TabIndex = 1;
            this.tbxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(61, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "CCCD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(61, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(61, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điện thoại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(61, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giới tính";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(61, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày sinh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(61, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên bệnh nhân";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSavePatient
            // 
            this.btnSavePatient.BackColor = System.Drawing.Color.Aqua;
            this.btnSavePatient.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSavePatient.Location = new System.Drawing.Point(581, 588);
            this.btnSavePatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePatient.Name = "btnSavePatient";
            this.btnSavePatient.Size = new System.Drawing.Size(192, 37);
            this.btnSavePatient.TabIndex = 4;
            this.btnSavePatient.Text = "Lưu";
            this.btnSavePatient.UseVisualStyleBackColor = false;
            this.btnSavePatient.Click += new System.EventHandler(this.btnSavePatient_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(789, 588);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1035, 52);
            this.panel4.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::QuanLyPhongKham.Properties.Resources.N9_NiceNight__1_;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(983, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(48, 47);
            this.panel8.TabIndex = 5;
            // 
            // ThemBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1032, 638);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSavePatient);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Bệnh Nhân";
            this.Load += new System.EventHandler(this.ThemBenhNhan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxCCCD;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxSex;
        private System.Windows.Forms.Button btnSavePatient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnReset;
    }
}