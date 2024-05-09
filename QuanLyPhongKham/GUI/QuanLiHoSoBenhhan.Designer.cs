using System.Drawing;

namespace QuanLyPhongKham.GUI {
     partial class QuanLiHoSoBenhhan {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabThongTinHanhChinh = new System.Windows.Forms.TabPage();
            this.clbListTreatmentNeeds = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxIsOldPatient = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.cbbQueue = new System.Windows.Forms.ComboBox();
            this.btnBirthYear = new System.Windows.Forms.Button();
            this.btnCCCD = new System.Windows.Forms.Button();
            this.btnYearOld = new System.Windows.Forms.Button();
            this.btnPhoneNumber = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnPatientID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddQueue = new System.Windows.Forms.Button();
            this.tabDanhSachBenhNhan = new System.Windows.Forms.TabPage();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.lvwListPatient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabThongTinHanhChinh.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabDanhSachBenhNhan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 697);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDanhSachBenhNhan);
            this.tabControl1.Controls.Add(this.tabThongTinHanhChinh);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1305, 691);
            this.tabControl1.TabIndex = 18;
            // 
            // tabThongTinHanhChinh
            // 
            this.tabThongTinHanhChinh.Controls.Add(this.clbListTreatmentNeeds);
            this.tabThongTinHanhChinh.Controls.Add(this.label3);
            this.tabThongTinHanhChinh.Controls.Add(this.cbxIsOldPatient);
            this.tabThongTinHanhChinh.Controls.Add(this.label1);
            this.tabThongTinHanhChinh.Controls.Add(this.panel4);
            this.tabThongTinHanhChinh.Controls.Add(this.btnUpdatePatient);
            this.tabThongTinHanhChinh.Controls.Add(this.cbbQueue);
            this.tabThongTinHanhChinh.Controls.Add(this.btnBirthYear);
            this.tabThongTinHanhChinh.Controls.Add(this.btnCCCD);
            this.tabThongTinHanhChinh.Controls.Add(this.btnYearOld);
            this.tabThongTinHanhChinh.Controls.Add(this.btnPhoneNumber);
            this.tabThongTinHanhChinh.Controls.Add(this.btnAddress);
            this.tabThongTinHanhChinh.Controls.Add(this.btnName);
            this.tabThongTinHanhChinh.Controls.Add(this.btnPatientID);
            this.tabThongTinHanhChinh.Controls.Add(this.label7);
            this.tabThongTinHanhChinh.Controls.Add(this.label2);
            this.tabThongTinHanhChinh.Controls.Add(this.label17);
            this.tabThongTinHanhChinh.Controls.Add(this.label15);
            this.tabThongTinHanhChinh.Controls.Add(this.label14);
            this.tabThongTinHanhChinh.Controls.Add(this.label12);
            this.tabThongTinHanhChinh.Controls.Add(this.label5);
            this.tabThongTinHanhChinh.Controls.Add(this.label4);
            this.tabThongTinHanhChinh.Controls.Add(this.btnAddQueue);
            this.tabThongTinHanhChinh.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabThongTinHanhChinh.Location = new System.Drawing.Point(4, 37);
            this.tabThongTinHanhChinh.Name = "tabThongTinHanhChinh";
            this.tabThongTinHanhChinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongTinHanhChinh.Size = new System.Drawing.Size(1297, 650);
            this.tabThongTinHanhChinh.TabIndex = 1;
            this.tabThongTinHanhChinh.Text = "Thông tin hành chính";
            this.tabThongTinHanhChinh.UseVisualStyleBackColor = true;
            // 
            // clbListTreatmentNeeds
            // 
            this.clbListTreatmentNeeds.CheckOnClick = true;
            this.clbListTreatmentNeeds.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbListTreatmentNeeds.FormattingEnabled = true;
            this.clbListTreatmentNeeds.Location = new System.Drawing.Point(19, 408);
            this.clbListTreatmentNeeds.Name = "clbListTreatmentNeeds";
            this.clbListTreatmentNeeds.Size = new System.Drawing.Size(645, 179);
            this.clbListTreatmentNeeds.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(15, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nhu cầu điều trị";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxIsOldPatient
            // 
            this.cbxIsOldPatient.AutoSize = true;
            this.cbxIsOldPatient.Enabled = false;
            this.cbxIsOldPatient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIsOldPatient.Location = new System.Drawing.Point(673, 297);
            this.cbxIsOldPatient.Name = "cbxIsOldPatient";
            this.cbxIsOldPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxIsOldPatient.Size = new System.Drawing.Size(141, 28);
            this.cbxIsOldPatient.TabIndex = 38;
            this.cbxIsOldPatient.Text = "Bệnh nhân cũ";
            this.cbxIsOldPatient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(673, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbMale);
            this.panel4.Controls.Add(this.rdbFemale);
            this.panel4.Location = new System.Drawing.Point(156, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 50);
            this.panel4.TabIndex = 35;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Enabled = false;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(3, 13);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(68, 26);
            this.rdbMale.TabIndex = 15;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Enabled = false;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(101, 13);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(54, 26);
            this.rdbFemale.TabIndex = 16;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Nữ";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdatePatient.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdatePatient.Location = new System.Drawing.Point(776, 538);
            this.btnUpdatePatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(250, 49);
            this.btnUpdatePatient.TabIndex = 9;
            this.btnUpdatePatient.Text = "Sửa thông tin";
            this.btnUpdatePatient.UseVisualStyleBackColor = false;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // cbbQueue
            // 
            this.cbbQueue.FormattingEnabled = true;
            this.cbbQueue.Location = new System.Drawing.Point(769, 368);
            this.cbbQueue.Margin = new System.Windows.Forms.Padding(4);
            this.cbbQueue.Name = "cbbQueue";
            this.cbbQueue.Size = new System.Drawing.Size(250, 39);
            this.cbbQueue.TabIndex = 34;
            // 
            // btnBirthYear
            // 
            this.btnBirthYear.Location = new System.Drawing.Point(156, 124);
            this.btnBirthYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBirthYear.Name = "btnBirthYear";
            this.btnBirthYear.Size = new System.Drawing.Size(267, 50);
            this.btnBirthYear.TabIndex = 32;
            this.btnBirthYear.UseVisualStyleBackColor = true;
            // 
            // btnCCCD
            // 
            this.btnCCCD.Location = new System.Drawing.Point(769, 204);
            this.btnCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCCCD.Name = "btnCCCD";
            this.btnCCCD.Size = new System.Drawing.Size(519, 50);
            this.btnCCCD.TabIndex = 31;
            this.btnCCCD.UseVisualStyleBackColor = true;
            // 
            // btnYearOld
            // 
            this.btnYearOld.Location = new System.Drawing.Point(493, 124);
            this.btnYearOld.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYearOld.Name = "btnYearOld";
            this.btnYearOld.Size = new System.Drawing.Size(171, 50);
            this.btnYearOld.TabIndex = 30;
            this.btnYearOld.UseVisualStyleBackColor = true;
            // 
            // btnPhoneNumber
            // 
            this.btnPhoneNumber.Location = new System.Drawing.Point(156, 204);
            this.btnPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhoneNumber.Name = "btnPhoneNumber";
            this.btnPhoneNumber.Size = new System.Drawing.Size(508, 50);
            this.btnPhoneNumber.TabIndex = 29;
            this.btnPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // btnAddress
            // 
            this.btnAddress.Location = new System.Drawing.Point(769, 124);
            this.btnAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(519, 48);
            this.btnAddress.TabIndex = 28;
            this.btnAddress.UseVisualStyleBackColor = true;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(769, 44);
            this.btnName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(519, 48);
            this.btnName.TabIndex = 33;
            this.btnName.UseVisualStyleBackColor = true;
            // 
            // btnPatientID
            // 
            this.btnPatientID.Location = new System.Drawing.Point(156, 44);
            this.btnPatientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatientID.Name = "btnPatientID";
            this.btnPatientID.Size = new System.Drawing.Size(508, 48);
            this.btnPatientID.TabIndex = 27;
            this.btnPatientID.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(15, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Điện thoại";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Giới tính";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(671, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 24);
            this.label17.TabIndex = 23;
            this.label17.Text = "CCCD";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(669, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "Địa chỉ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(671, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "Họ và Tên";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(429, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tuổi";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(15, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Năm sinh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(15, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã Bệnh Nhân";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddQueue
            // 
            this.btnAddQueue.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddQueue.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddQueue.Location = new System.Drawing.Point(1032, 538);
            this.btnAddQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddQueue.Name = "btnAddQueue";
            this.btnAddQueue.Size = new System.Drawing.Size(250, 49);
            this.btnAddQueue.TabIndex = 18;
            this.btnAddQueue.Text = "Thêm vào hàng chờ";
            this.btnAddQueue.UseVisualStyleBackColor = false;
            this.btnAddQueue.Click += new System.EventHandler(this.btnAddQueue_Click);
            // 
            // tabDanhSachBenhNhan
            // 
            this.tabDanhSachBenhNhan.Controls.Add(this.btnAddPatient);
            this.tabDanhSachBenhNhan.Controls.Add(this.lvwListPatient);
            this.tabDanhSachBenhNhan.Controls.Add(this.panel2);
            this.tabDanhSachBenhNhan.Location = new System.Drawing.Point(4, 37);
            this.tabDanhSachBenhNhan.Name = "tabDanhSachBenhNhan";
            this.tabDanhSachBenhNhan.Size = new System.Drawing.Size(1297, 650);
            this.tabDanhSachBenhNhan.TabIndex = 2;
            this.tabDanhSachBenhNhan.Text = "Danh sách bệnh nhân";
            this.tabDanhSachBenhNhan.UseVisualStyleBackColor = true;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddPatient.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddPatient.Location = new System.Drawing.Point(1096, 541);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(198, 49);
            this.btnAddPatient.TabIndex = 9;
            this.btnAddPatient.Text = "Thêm bệnh nhân";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // lvwListPatient
            // 
            this.lvwListPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwListPatient.FullRowSelect = true;
            this.lvwListPatient.GridLines = true;
            this.lvwListPatient.HideSelection = false;
            this.lvwListPatient.Location = new System.Drawing.Point(3, 85);
            this.lvwListPatient.MultiSelect = false;
            this.lvwListPatient.Name = "lvwListPatient";
            this.lvwListPatient.Size = new System.Drawing.Size(1288, 451);
            this.lvwListPatient.TabIndex = 0;
            this.lvwListPatient.UseCompatibleStateImageBehavior = false;
            this.lvwListPatient.View = System.Windows.Forms.View.Details;
            this.lvwListPatient.SelectedIndexChanged += new System.EventHandler(this.lvwListPatient_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã bệnh nhân";
            this.columnHeader1.Width = 365;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên bệnh nhân";
            this.columnHeader2.Width = 1115;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tbxSearch);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 78);
            this.panel2.TabIndex = 7;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.Azure;
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(329, 16);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearch.Multiline = true;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(603, 43);
            this.tbxSearch.TabIndex = 7;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuanLyPhongKham.Properties.Resources.N9_NiceNight__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(1837, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 47);
            this.panel3.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Cyan;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(939, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 44);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // QuanLiHoSoBenhhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLiHoSoBenhhan";
            this.Size = new System.Drawing.Size(1313, 702);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabThongTinHanhChinh.ResumeLayout(false);
            this.tabThongTinHanhChinh.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabDanhSachBenhNhan.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabThongTinHanhChinh;
        private System.Windows.Forms.TabPage tabDanhSachBenhNhan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.ComboBox cbbQueue;
        private System.Windows.Forms.Button btnBirthYear;
        private System.Windows.Forms.Button btnCCCD;
        private System.Windows.Forms.Button btnYearOld;
        private System.Windows.Forms.Button btnPhoneNumber;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnPatientID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddQueue;
        private System.Windows.Forms.ListView lvwListPatient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxIsOldPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbListTreatmentNeeds;
    }
}
