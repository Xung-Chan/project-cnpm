﻿namespace QuanLyPhongKham.GUI {
    partial class PhanCongLichTruc {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lvwDutySchedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.cbbDentist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbShift = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbAssistant = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lvwDutySchedule
            // 
            this.lvwDutySchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.lvwDutySchedule.GridLines = true;
            this.lvwDutySchedule.HideSelection = false;
            this.lvwDutySchedule.Location = new System.Drawing.Point(142, 124);
            this.lvwDutySchedule.Name = "lvwDutySchedule";
            this.lvwDutySchedule.Size = new System.Drawing.Size(982, 317);
            this.lvwDutySchedule.TabIndex = 0;
            this.lvwDutySchedule.UseCompatibleStateImageBehavior = false;
            this.lvwDutySchedule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phòng";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ca";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bác sĩ";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phụ tá";
            this.columnHeader5.Width = 299;
            // 
            // cbbRoom
            // 
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(221, 522);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(132, 24);
            this.cbbRoom.TabIndex = 2;
            // 
            // cbbDentist
            // 
            this.cbbDentist.FormattingEnabled = true;
            this.cbbDentist.Location = new System.Drawing.Point(682, 522);
            this.cbbDentist.Name = "cbbDentist";
            this.cbbDentist.Size = new System.Drawing.Size(160, 24);
            this.cbbDentist.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bác sĩ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1049, 598);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chỉnh sửa lịch trực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ca";
            // 
            // cbbShift
            // 
            this.cbbShift.FormattingEnabled = true;
            this.cbbShift.Location = new System.Drawing.Point(433, 522);
            this.cbbShift.Name = "cbbShift";
            this.cbbShift.Size = new System.Drawing.Size(75, 24);
            this.cbbShift.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(888, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phụ tá";
            // 
            // cbbAssistant
            // 
            this.cbbAssistant.FormattingEnabled = true;
            this.cbbAssistant.Location = new System.Drawing.Point(964, 522);
            this.cbbAssistant.Name = "cbbAssistant";
            this.cbbAssistant.Size = new System.Drawing.Size(150, 24);
            this.cbbAssistant.TabIndex = 10;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(142, 79);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2024, 5, 9, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // PhanCongLichTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbAssistant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbDentist);
            this.Controls.Add(this.cbbRoom);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lvwDutySchedule);
            this.Name = "PhanCongLichTruc";
            this.Size = new System.Drawing.Size(1313, 702);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwDutySchedule;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.ComboBox cbbDentist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbShift;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbAssistant;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
