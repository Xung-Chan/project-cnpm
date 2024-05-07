namespace QuanLyPhongKham.GUI
{
    public partial class KhamLamSang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDrugAllergy = new System.Windows.Forms.TextBox();
            this.tbxTreatmentDirection = new System.Windows.Forms.TextBox();
            this.tbxDiagnostic = new System.Windows.Forms.TextBox();
            this.tbxOtherDiseases = new System.Windows.Forms.TextBox();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.tbxNote);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxDrugAllergy);
            this.groupBox2.Controls.Add(this.tbxTreatmentDirection);
            this.groupBox2.Controls.Add(this.tbxDiagnostic);
            this.groupBox2.Controls.Add(this.tbxOtherDiseases);
            this.groupBox2.Controls.Add(this.tbxStatus);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1673, 455);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSave.Location = new System.Drawing.Point(1441, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxNote
            // 
            this.tbxNote.Location = new System.Drawing.Point(1060, 133);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.Size = new System.Drawing.Size(511, 50);
            this.tbxNote.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(875, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ghi chú";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxDrugAllergy
            // 
            this.tbxDrugAllergy.Location = new System.Drawing.Point(190, 133);
            this.tbxDrugAllergy.Multiline = true;
            this.tbxDrugAllergy.Name = "tbxDrugAllergy";
            this.tbxDrugAllergy.Size = new System.Drawing.Size(540, 50);
            this.tbxDrugAllergy.TabIndex = 5;
            // 
            // tbxTreatmentDirection
            // 
            this.tbxTreatmentDirection.Location = new System.Drawing.Point(190, 293);
            this.tbxTreatmentDirection.Multiline = true;
            this.tbxTreatmentDirection.Name = "tbxTreatmentDirection";
            this.tbxTreatmentDirection.Size = new System.Drawing.Size(1381, 56);
            this.tbxTreatmentDirection.TabIndex = 5;
            // 
            // tbxDiagnostic
            // 
            this.tbxDiagnostic.Location = new System.Drawing.Point(190, 213);
            this.tbxDiagnostic.Multiline = true;
            this.tbxDiagnostic.Name = "tbxDiagnostic";
            this.tbxDiagnostic.Size = new System.Drawing.Size(1381, 56);
            this.tbxDiagnostic.TabIndex = 5;
            // 
            // tbxOtherDiseases
            // 
            this.tbxOtherDiseases.Location = new System.Drawing.Point(1060, 53);
            this.tbxOtherDiseases.Multiline = true;
            this.tbxOtherDiseases.Name = "tbxOtherDiseases";
            this.tbxOtherDiseases.Size = new System.Drawing.Size(511, 50);
            this.tbxOtherDiseases.TabIndex = 5;
            // 
            // tbxStatus
            // 
            this.tbxStatus.Location = new System.Drawing.Point(190, 53);
            this.tbxStatus.Multiline = true;
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.Size = new System.Drawing.Size(540, 50);
            this.tbxStatus.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(15, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 58);
            this.label18.TabIndex = 4;
            this.label18.Text = "Kết luận hướng điều trị";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(15, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 24);
            this.label17.TabIndex = 4;
            this.label17.Text = "Chuẩn đoán bệnh";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(875, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 24);
            this.label15.TabIndex = 4;
            this.label15.Text = "Bệnh kèm theo";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(15, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 24);
            this.label19.TabIndex = 4;
            this.label19.Text = "Dị ứng thuốc";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(15, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 24);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tình trạng";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label13);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1593, 34);
            this.panel9.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(12, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "KHÁM LÂM SÀN";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KhamLamSang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "KhamLamSang";
            this.Size = new System.Drawing.Size(1599, 420);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxDrugAllergy;
        private System.Windows.Forms.TextBox tbxTreatmentDirection;
        private System.Windows.Forms.TextBox tbxDiagnostic;
        private System.Windows.Forms.TextBox tbxOtherDiseases;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.Button btnSave;
    }
}
