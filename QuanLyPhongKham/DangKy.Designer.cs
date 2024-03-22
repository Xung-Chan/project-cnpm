using System.Drawing;

namespace QuanLyPhongKham
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbxMaUser = new System.Windows.Forms.TextBox();
            this.eyeShowSecond = new System.Windows.Forms.Panel();
            this.eyeHideSecond = new System.Windows.Forms.Panel();
            this.tbxRole = new System.Windows.Forms.TextBox();
            this.tbxSdt = new System.Windows.Forms.TextBox();
            this.tbxPasswordSecond = new System.Windows.Forms.TextBox();
            this.eyeShowFirst = new System.Windows.Forms.Panel();
            this.eyeHideFirst = new System.Windows.Forms.Panel();
            this.tbxPasswordFirst = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogup = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.eyeShowSecond.SuspendLayout();
            this.eyeShowFirst.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(219, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 366);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.label6);
            this.panel13.Location = new System.Drawing.Point(4, 114);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(206, 41);
            this.panel13.TabIndex = 11;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã nhân viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.tbxMaUser);
            this.panel9.Controls.Add(this.eyeShowSecond);
            this.panel9.Controls.Add(this.tbxRole);
            this.panel9.Controls.Add(this.tbxSdt);
            this.panel9.Controls.Add(this.tbxPasswordSecond);
            this.panel9.Controls.Add(this.eyeShowFirst);
            this.panel9.Controls.Add(this.tbxPasswordFirst);
            this.panel9.Location = new System.Drawing.Point(240, 71);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(304, 219);
            this.panel9.TabIndex = 6;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // tbxMaUser
            // 
            this.tbxMaUser.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxMaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaUser.Location = new System.Drawing.Point(0, 45);
            this.tbxMaUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMaUser.Multiline = true;
            this.tbxMaUser.Name = "tbxMaUser";
            this.tbxMaUser.Size = new System.Drawing.Size(304, 37);
            this.tbxMaUser.TabIndex = 1;
            this.tbxMaUser.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // eyeShowSecond
            // 
            this.eyeShowSecond.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeShowSecond.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeShowSecond.BackgroundImage")));
            this.eyeShowSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyeShowSecond.Controls.Add(this.eyeHideSecond);
            this.eyeShowSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeShowSecond.Location = new System.Drawing.Point(272, 180);
            this.eyeShowSecond.Name = "eyeShowSecond";
            this.eyeShowSecond.Size = new System.Drawing.Size(30, 32);
            this.eyeShowSecond.TabIndex = 0;
            this.eyeShowSecond.Visible = false;
            this.eyeShowSecond.Click += new System.EventHandler(this.eyeShowSecond_Click);
            this.eyeShowSecond.Paint += new System.Windows.Forms.PaintEventHandler(this.eyeShowSecond_Paint);
            // 
            // eyeHideSecond
            // 
            this.eyeHideSecond.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeHideSecond.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeHideSecond.BackgroundImage")));
            this.eyeHideSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eyeHideSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeHideSecond.Location = new System.Drawing.Point(0, 0);
            this.eyeHideSecond.Name = "eyeHideSecond";
            this.eyeHideSecond.Size = new System.Drawing.Size(30, 32);
            this.eyeHideSecond.TabIndex = 2;
            this.eyeHideSecond.Click += new System.EventHandler(this.eyeHideSecond_Click);
            this.eyeHideSecond.Paint += new System.Windows.Forms.PaintEventHandler(this.eyeHideSecond_Paint);
            // 
            // tbxRole
            // 
            this.tbxRole.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRole.Location = new System.Drawing.Point(0, 86);
            this.tbxRole.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRole.Multiline = true;
            this.tbxRole.Name = "tbxRole";
            this.tbxRole.Size = new System.Drawing.Size(304, 37);
            this.tbxRole.TabIndex = 2;
            this.tbxRole.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxSdt
            // 
            this.tbxSdt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSdt.Location = new System.Drawing.Point(0, 2);
            this.tbxSdt.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSdt.Multiline = true;
            this.tbxSdt.Name = "tbxSdt";
            this.tbxSdt.Size = new System.Drawing.Size(304, 37);
            this.tbxSdt.TabIndex = 0;
            this.tbxSdt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxPasswordSecond
            // 
            this.tbxPasswordSecond.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxPasswordSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPasswordSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPasswordSecond.Location = new System.Drawing.Point(0, 175);
            this.tbxPasswordSecond.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPasswordSecond.Multiline = true;
            this.tbxPasswordSecond.Name = "tbxPasswordSecond";
            this.tbxPasswordSecond.PasswordChar = '*';
            this.tbxPasswordSecond.Size = new System.Drawing.Size(304, 37);
            this.tbxPasswordSecond.TabIndex = 4;
            this.tbxPasswordSecond.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // eyeShowFirst
            // 
            this.eyeShowFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeShowFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeShowFirst.BackgroundImage")));
            this.eyeShowFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyeShowFirst.Controls.Add(this.eyeHideFirst);
            this.eyeShowFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeShowFirst.Location = new System.Drawing.Point(271, 137);
            this.eyeShowFirst.Name = "eyeShowFirst";
            this.eyeShowFirst.Size = new System.Drawing.Size(30, 32);
            this.eyeShowFirst.TabIndex = 5;
            this.eyeShowFirst.Visible = false;
            this.eyeShowFirst.Click += new System.EventHandler(this.eyeShowFirst_Click);
            this.eyeShowFirst.Paint += new System.Windows.Forms.PaintEventHandler(this.eyeShowFirst_Paint);
            // 
            // eyeHideFirst
            // 
            this.eyeHideFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeHideFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeHideFirst.BackgroundImage")));
            this.eyeHideFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eyeHideFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeHideFirst.Location = new System.Drawing.Point(1, 1);
            this.eyeHideFirst.Name = "eyeHideFirst";
            this.eyeHideFirst.Size = new System.Drawing.Size(30, 32);
            this.eyeHideFirst.TabIndex = 2;
            this.eyeHideFirst.Click += new System.EventHandler(this.eyeHideFirst_Click);
            this.eyeHideFirst.Paint += new System.Windows.Forms.PaintEventHandler(this.eyeHide_Paint);
            // 
            // tbxPasswordFirst
            // 
            this.tbxPasswordFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxPasswordFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPasswordFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPasswordFirst.Location = new System.Drawing.Point(0, 133);
            this.tbxPasswordFirst.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPasswordFirst.Multiline = true;
            this.tbxPasswordFirst.Name = "tbxPasswordFirst";
            this.tbxPasswordFirst.PasswordChar = '*';
            this.tbxPasswordFirst.Size = new System.Drawing.Size(302, 37);
            this.tbxPasswordFirst.TabIndex = 3;
            this.tbxPasswordFirst.TextChanged += new System.EventHandler(this.tbxPasswordFirst_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(4, 157);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(206, 41);
            this.panel7.TabIndex = 9;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chức vụ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 63);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(2, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(539, 41);
            this.panel8.TabIndex = 4;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký tài khoản mới";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(4, 71);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 41);
            this.panel6.TabIndex = 12;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(4, 204);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 41);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(4, 247);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 41);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnLogup
            // 
            this.btnLogup.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogup.Location = new System.Drawing.Point(176, 1);
            this.btnLogup.Name = "btnLogup";
            this.btnLogup.Size = new System.Drawing.Size(183, 44);
            this.btnLogup.TabIndex = 1;
            this.btnLogup.Text = "Đăng ký";
            this.btnLogup.UseVisualStyleBackColor = false;
            this.btnLogup.Click += new System.EventHandler(this.btnLogup_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnLogup);
            this.panel3.Location = new System.Drawing.Point(2, 294);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 44);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.eyeShowSecond.ResumeLayout(false);
            this.eyeShowFirst.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbxPasswordSecond;
        private System.Windows.Forms.TextBox tbxPasswordFirst;
        private System.Windows.Forms.TextBox tbxSdt;
        private System.Windows.Forms.Panel eyeHideSecond;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxRole;
        private System.Windows.Forms.Panel eyeShowFirst;
        private System.Windows.Forms.Panel eyeShowSecond;
        private System.Windows.Forms.Panel eyeHideFirst;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMaUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogup;
    }
}