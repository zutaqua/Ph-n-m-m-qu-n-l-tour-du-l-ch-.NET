namespace TestVerDoAn
{
    partial class frmThanhToan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDD = new System.Windows.Forms.TextBox();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rounded1 = new khanhtoan.rounded();
            this.vbButton1 = new TestVerDoAn.VBButton();
            this.rounded4 = new khanhtoan.rounded();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtDichVu = new System.Windows.Forms.TextBox();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.vbButton2 = new TestVerDoAn.VBButton();
            this.vbButton3 = new TestVerDoAn.VBButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rounded5 = new khanhtoan.rounded();
            this.rounded7 = new khanhtoan.rounded();
            this.rounded6 = new khanhtoan.rounded();
            this.rounded8 = new khanhtoan.rounded();
            this.rounded9 = new khanhtoan.rounded();
            this.rounded10 = new khanhtoan.rounded();
            this.rounded2 = new khanhtoan.rounded();
            this.rounded3 = new khanhtoan.rounded();
            this.rounded11 = new khanhtoan.rounded();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHome = new TestVerDoAn.VBButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(4, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 378);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Tour Thanh Toán";
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(3, 16);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(514, 359);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Địa Điểm";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Dịch Vụ";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chuyên Môn NV";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Ngày";
            this.columnHeader4.Width = 57;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mô tả";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã KH";
            this.columnHeader6.Width = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tên Địa Điểm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tên Dịch Vụ";
            // 
            // txtDD
            // 
            this.txtDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDD.Location = new System.Drawing.Point(521, 84);
            this.txtDD.Name = "txtDD";
            this.txtDD.Size = new System.Drawing.Size(170, 14);
            this.txtDD.TabIndex = 24;
            // 
            // txtDV
            // 
            this.txtDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDV.Location = new System.Drawing.Point(326, 84);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(170, 14);
            this.txtDV.TabIndex = 25;
            // 
            // txtCM
            // 
            this.txtCM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCM.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCM.Location = new System.Drawing.Point(132, 82);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(170, 14);
            this.txtCM.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(129, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Chuyên Môn NV";
            // 
            // rounded1
            // 
            this.rounded1.BackColor = System.Drawing.Color.White;
            this.rounded1.BorderColor = System.Drawing.Color.Black;
            this.rounded1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded1.BorderRadius = 10;
            this.rounded1.BorderSize = 2;
            this.rounded1.Location = new System.Drawing.Point(510, 76);
            this.rounded1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded1.Name = "rounded1";
            this.rounded1.PasswordChar = false;
            this.rounded1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded1.PlaceholderText = "";
            this.rounded1.Size = new System.Drawing.Size(192, 34);
            this.rounded1.TabIndex = 30;
            this.rounded1.UnderlinedStyle = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.White;
            this.vbButton1.BackgroundColor = System.Drawing.Color.White;
            this.vbButton1.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.vbButton1.BorderRadius = 10;
            this.vbButton1.BorderSize = 1;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vbButton1.Location = new System.Drawing.Point(721, 76);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(82, 35);
            this.vbButton1.TabIndex = 33;
            this.vbButton1.Text = "Tìm Tour";
            this.vbButton1.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // rounded4
            // 
            this.rounded4.BackColor = System.Drawing.Color.White;
            this.rounded4.BorderColor = System.Drawing.Color.Black;
            this.rounded4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded4.BorderRadius = 20;
            this.rounded4.BorderSize = 2;
            this.rounded4.Location = new System.Drawing.Point(93, 22);
            this.rounded4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded4.Name = "rounded4";
            this.rounded4.PasswordChar = false;
            this.rounded4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded4.PlaceholderText = "";
            this.rounded4.Size = new System.Drawing.Size(231, 33);
            this.rounded4.TabIndex = 34;
            this.rounded4.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Địa Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Dịch Vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "C.Môn NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Số Ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tổng Tiền";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaDiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Location = new System.Drawing.Point(104, 114);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.ReadOnly = true;
            this.txtDiaDiem.Size = new System.Drawing.Size(211, 14);
            this.txtDiaDiem.TabIndex = 26;
            this.txtDiaDiem.TextChanged += new System.EventHandler(this.txtDiaDiem_TextChanged);
            // 
            // txtDichVu
            // 
            this.txtDichVu.BackColor = System.Drawing.SystemColors.Window;
            this.txtDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDichVu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDichVu.Location = new System.Drawing.Point(104, 154);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.ReadOnly = true;
            this.txtDichVu.Size = new System.Drawing.Size(211, 14);
            this.txtDichVu.TabIndex = 27;
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.BackColor = System.Drawing.SystemColors.Window;
            this.txtChuyenMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChuyenMon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuyenMon.Location = new System.Drawing.Point(104, 196);
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.ReadOnly = true;
            this.txtChuyenMon.Size = new System.Drawing.Size(211, 14);
            this.txtChuyenMon.TabIndex = 28;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoNgay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgay.Location = new System.Drawing.Point(104, 236);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.ReadOnly = true;
            this.txtSoNgay.Size = new System.Drawing.Size(211, 14);
            this.txtSoNgay.TabIndex = 29;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(104, 276);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(211, 14);
            this.txtTongTien.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(104, 33);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(211, 14);
            this.txtMaHD.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(104, 73);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(211, 14);
            this.txtMaKH.TabIndex = 36;
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.White;
            this.vbButton2.BackgroundColor = System.Drawing.Color.White;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 10;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vbButton2.Location = new System.Drawing.Point(93, 334);
            this.vbButton2.Margin = new System.Windows.Forms.Padding(2);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(87, 25);
            this.vbButton2.TabIndex = 37;
            this.vbButton2.Text = "Thanh Toán";
            this.vbButton2.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vbButton2.UseVisualStyleBackColor = false;
            this.vbButton2.Click += new System.EventHandler(this.vbButton2_Click);
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.White;
            this.vbButton3.BackgroundColor = System.Drawing.Color.White;
            this.vbButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton3.BorderRadius = 10;
            this.vbButton3.BorderSize = 0;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vbButton3.Location = new System.Drawing.Point(228, 334);
            this.vbButton3.Margin = new System.Windows.Forms.Padding(2);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(87, 25);
            this.vbButton3.TabIndex = 38;
            this.vbButton3.Text = "Hủy";
            this.vbButton3.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vbButton3.UseVisualStyleBackColor = false;
            this.vbButton3.Click += new System.EventHandler(this.vbButton3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vbButton3);
            this.groupBox2.Controls.Add(this.vbButton2);
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.txtSoNgay);
            this.groupBox2.Controls.Add(this.txtChuyenMon);
            this.groupBox2.Controls.Add(this.txtDichVu);
            this.groupBox2.Controls.Add(this.txtDiaDiem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rounded4);
            this.groupBox2.Controls.Add(this.rounded5);
            this.groupBox2.Controls.Add(this.rounded7);
            this.groupBox2.Controls.Add(this.rounded6);
            this.groupBox2.Controls.Add(this.rounded8);
            this.groupBox2.Controls.Add(this.rounded9);
            this.groupBox2.Controls.Add(this.rounded10);
            this.groupBox2.Location = new System.Drawing.Point(530, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 378);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng Tiền";
            // 
            // rounded5
            // 
            this.rounded5.BackColor = System.Drawing.Color.White;
            this.rounded5.BorderColor = System.Drawing.Color.Black;
            this.rounded5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded5.BorderRadius = 20;
            this.rounded5.BorderSize = 2;
            this.rounded5.Location = new System.Drawing.Point(93, 63);
            this.rounded5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded5.Name = "rounded5";
            this.rounded5.PasswordChar = false;
            this.rounded5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded5.PlaceholderText = "";
            this.rounded5.Size = new System.Drawing.Size(231, 33);
            this.rounded5.TabIndex = 39;
            this.rounded5.UnderlinedStyle = false;
            // 
            // rounded7
            // 
            this.rounded7.BackColor = System.Drawing.Color.White;
            this.rounded7.BorderColor = System.Drawing.Color.Black;
            this.rounded7.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded7.BorderRadius = 20;
            this.rounded7.BorderSize = 2;
            this.rounded7.Location = new System.Drawing.Point(93, 144);
            this.rounded7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded7.Name = "rounded7";
            this.rounded7.PasswordChar = false;
            this.rounded7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded7.PlaceholderText = "";
            this.rounded7.Size = new System.Drawing.Size(231, 33);
            this.rounded7.TabIndex = 41;
            this.rounded7.UnderlinedStyle = false;
            // 
            // rounded6
            // 
            this.rounded6.BackColor = System.Drawing.Color.White;
            this.rounded6.BorderColor = System.Drawing.Color.Black;
            this.rounded6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded6.BorderRadius = 20;
            this.rounded6.BorderSize = 2;
            this.rounded6.Location = new System.Drawing.Point(93, 103);
            this.rounded6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded6.Name = "rounded6";
            this.rounded6.PasswordChar = false;
            this.rounded6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded6.PlaceholderText = "";
            this.rounded6.Size = new System.Drawing.Size(231, 33);
            this.rounded6.TabIndex = 40;
            this.rounded6.UnderlinedStyle = false;
            // 
            // rounded8
            // 
            this.rounded8.BackColor = System.Drawing.Color.White;
            this.rounded8.BorderColor = System.Drawing.Color.Black;
            this.rounded8.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded8.BorderRadius = 20;
            this.rounded8.BorderSize = 2;
            this.rounded8.Location = new System.Drawing.Point(93, 184);
            this.rounded8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded8.Name = "rounded8";
            this.rounded8.PasswordChar = false;
            this.rounded8.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded8.PlaceholderText = "";
            this.rounded8.Size = new System.Drawing.Size(231, 33);
            this.rounded8.TabIndex = 42;
            this.rounded8.UnderlinedStyle = false;
            // 
            // rounded9
            // 
            this.rounded9.BackColor = System.Drawing.Color.White;
            this.rounded9.BorderColor = System.Drawing.Color.Black;
            this.rounded9.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded9.BorderRadius = 20;
            this.rounded9.BorderSize = 2;
            this.rounded9.Location = new System.Drawing.Point(93, 226);
            this.rounded9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded9.Name = "rounded9";
            this.rounded9.PasswordChar = false;
            this.rounded9.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded9.PlaceholderText = "";
            this.rounded9.Size = new System.Drawing.Size(231, 33);
            this.rounded9.TabIndex = 43;
            this.rounded9.UnderlinedStyle = false;
            // 
            // rounded10
            // 
            this.rounded10.BackColor = System.Drawing.Color.White;
            this.rounded10.BorderColor = System.Drawing.Color.Black;
            this.rounded10.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded10.BorderRadius = 20;
            this.rounded10.BorderSize = 2;
            this.rounded10.Location = new System.Drawing.Point(93, 266);
            this.rounded10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded10.Name = "rounded10";
            this.rounded10.PasswordChar = false;
            this.rounded10.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded10.PlaceholderText = "";
            this.rounded10.Size = new System.Drawing.Size(231, 33);
            this.rounded10.TabIndex = 44;
            this.rounded10.UnderlinedStyle = false;
            // 
            // rounded2
            // 
            this.rounded2.BackColor = System.Drawing.Color.White;
            this.rounded2.BorderColor = System.Drawing.Color.Black;
            this.rounded2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded2.BorderRadius = 10;
            this.rounded2.BorderSize = 2;
            this.rounded2.Location = new System.Drawing.Point(121, 75);
            this.rounded2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded2.Name = "rounded2";
            this.rounded2.PasswordChar = false;
            this.rounded2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded2.PlaceholderText = "";
            this.rounded2.Size = new System.Drawing.Size(192, 34);
            this.rounded2.TabIndex = 34;
            this.rounded2.UnderlinedStyle = false;
            // 
            // rounded3
            // 
            this.rounded3.BackColor = System.Drawing.Color.White;
            this.rounded3.BorderColor = System.Drawing.Color.Black;
            this.rounded3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded3.BorderRadius = 10;
            this.rounded3.BorderSize = 2;
            this.rounded3.Location = new System.Drawing.Point(315, 76);
            this.rounded3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded3.Name = "rounded3";
            this.rounded3.PasswordChar = false;
            this.rounded3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded3.PlaceholderText = "";
            this.rounded3.Size = new System.Drawing.Size(192, 34);
            this.rounded3.TabIndex = 35;
            this.rounded3.UnderlinedStyle = false;
            // 
            // rounded11
            // 
            this.rounded11.BackColor = System.Drawing.SystemColors.Window;
            this.rounded11.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded11.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded11.BorderRadius = 15;
            this.rounded11.BorderSize = 2;
            this.rounded11.Location = new System.Drawing.Point(78, 11);
            this.rounded11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded11.Name = "rounded11";
            this.rounded11.PasswordChar = false;
            this.rounded11.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded11.PlaceholderText = "";
            this.rounded11.Size = new System.Drawing.Size(767, 119);
            this.rounded11.TabIndex = 44;
            this.rounded11.UnderlinedStyle = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::TestVerDoAn.Properties.Resources.QLThanhT;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(115, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(357, 36);
            this.label11.TabIndex = 45;
            this.label11.Text = "      Quản Lý Thanh Toán";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundColor = System.Drawing.Color.White;
            this.btnHome.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 1;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Image = global::TestVerDoAn.Properties.Resources.logo1;
            this.btnHome.Location = new System.Drawing.Point(4, 22);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 54);
            this.btnHome.TabIndex = 46;
            this.btnHome.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(891, 528);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDD);
            this.Controls.Add(this.rounded3);
            this.Controls.Add(this.rounded2);
            this.Controls.Add(this.rounded1);
            this.Controls.Add(this.rounded11);
            this.Name = "frmThanhToan";
            this.Text = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDD;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.Label label10;
        private khanhtoan.rounded rounded1;
        private VBButton vbButton1;
        private khanhtoan.rounded rounded4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtDichVu;
        private System.Windows.Forms.TextBox txtChuyenMon;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private VBButton vbButton2;
        private VBButton vbButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private khanhtoan.rounded rounded5;
        private khanhtoan.rounded rounded7;
        private khanhtoan.rounded rounded6;
        private khanhtoan.rounded rounded8;
        private khanhtoan.rounded rounded9;
        private khanhtoan.rounded rounded10;
        private khanhtoan.rounded rounded2;
        private khanhtoan.rounded rounded3;
        private khanhtoan.rounded rounded11;
        private System.Windows.Forms.Label label11;
        private VBButton btnHome;
    }
}