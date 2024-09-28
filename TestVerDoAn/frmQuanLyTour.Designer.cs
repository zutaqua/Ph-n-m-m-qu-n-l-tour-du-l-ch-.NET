namespace TestVerDoAn
{
    partial class frmQuanLyTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTour));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim1 = new TestVerDoAn.VBButton();
            this.btnSua1 = new TestVerDoAn.VBButton();
            this.btnXoa1 = new TestVerDoAn.VBButton();
            this.btnThem1 = new TestVerDoAn.VBButton();
            this.btnLMoi1 = new TestVerDoAn.VBButton();
            this.rounded3 = new khanhtoan.rounded();
            this.rounded1 = new khanhtoan.rounded();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new TestVerDoAn.VBButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Tour";
            this.columnHeader1.Width = 76;
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
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
            this.lsvDanhSach.Size = new System.Drawing.Size(752, 239);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên Tour";
            this.columnHeader7.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Địa Điểm";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Ngày";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Dịch Vụ";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Chuyên Môn NV";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mô Tả";
            this.columnHeader6.Width = 189;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(21, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 258);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Địa Điểm";
            // 
            // txtTim
            // 
            this.txtTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTim.Location = new System.Drawing.Point(313, 72);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(265, 13);
            this.txtTim.TabIndex = 25;
            // 
            // btnTim1
            // 
            this.btnTim1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTim1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnTim1.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnTim1.BorderRadius = 10;
            this.btnTim1.BorderSize = 1;
            this.btnTim1.FlatAppearance.BorderSize = 0;
            this.btnTim1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim1.ForeColor = System.Drawing.Color.Black;
            this.btnTim1.Location = new System.Drawing.Point(600, 64);
            this.btnTim1.Name = "btnTim1";
            this.btnTim1.Size = new System.Drawing.Size(87, 29);
            this.btnTim1.TabIndex = 39;
            this.btnTim1.Text = "Tìm Tour";
            this.btnTim1.TextColor = System.Drawing.Color.Black;
            this.btnTim1.UseVisualStyleBackColor = false;
            this.btnTim1.Click += new System.EventHandler(this.btnTim1_Click);
            // 
            // btnSua1
            // 
            this.btnSua1.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSua1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua1.BorderRadius = 10;
            this.btnSua1.BorderSize = 1;
            this.btnSua1.FlatAppearance.BorderSize = 0;
            this.btnSua1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua1.ForeColor = System.Drawing.Color.Black;
            this.btnSua1.Location = new System.Drawing.Point(688, 397);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(87, 29);
            this.btnSua1.TabIndex = 38;
            this.btnSua1.Text = "Sửa Tour";
            this.btnSua1.TextColor = System.Drawing.Color.Black;
            this.btnSua1.UseVisualStyleBackColor = false;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnXoa1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa1.BorderRadius = 10;
            this.btnXoa1.BorderSize = 1;
            this.btnXoa1.FlatAppearance.BorderSize = 0;
            this.btnXoa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa1.ForeColor = System.Drawing.Color.Black;
            this.btnXoa1.Location = new System.Drawing.Point(466, 397);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(87, 29);
            this.btnXoa1.TabIndex = 37;
            this.btnXoa1.Text = "Xóa Tour";
            this.btnXoa1.TextColor = System.Drawing.Color.Black;
            this.btnXoa1.UseVisualStyleBackColor = false;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnThem1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem1.BorderRadius = 10;
            this.btnThem1.BorderSize = 1;
            this.btnThem1.FlatAppearance.BorderSize = 0;
            this.btnThem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem1.ForeColor = System.Drawing.Color.Black;
            this.btnThem1.Location = new System.Drawing.Point(244, 397);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(87, 29);
            this.btnThem1.TabIndex = 36;
            this.btnThem1.Text = "Thêm Tour";
            this.btnThem1.TextColor = System.Drawing.Color.Black;
            this.btnThem1.UseVisualStyleBackColor = false;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnLMoi1
            // 
            this.btnLMoi1.BackColor = System.Drawing.SystemColors.Control;
            this.btnLMoi1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnLMoi1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLMoi1.BorderRadius = 10;
            this.btnLMoi1.BorderSize = 1;
            this.btnLMoi1.FlatAppearance.BorderSize = 0;
            this.btnLMoi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLMoi1.ForeColor = System.Drawing.Color.Black;
            this.btnLMoi1.Location = new System.Drawing.Point(22, 397);
            this.btnLMoi1.Name = "btnLMoi1";
            this.btnLMoi1.Size = new System.Drawing.Size(87, 29);
            this.btnLMoi1.TabIndex = 33;
            this.btnLMoi1.Text = "Làm Mới";
            this.btnLMoi1.TextColor = System.Drawing.Color.Black;
            this.btnLMoi1.UseVisualStyleBackColor = false;
            this.btnLMoi1.Click += new System.EventHandler(this.btnLMoi1_Click);
            // 
            // rounded3
            // 
            this.rounded3.BackColor = System.Drawing.SystemColors.Window;
            this.rounded3.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded3.BorderRadius = 10;
            this.rounded3.BorderSize = 1;
            this.rounded3.Location = new System.Drawing.Point(306, 66);
            this.rounded3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded3.Name = "rounded3";
            this.rounded3.PasswordChar = false;
            this.rounded3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded3.PlaceholderText = "";
            this.rounded3.Size = new System.Drawing.Size(281, 25);
            this.rounded3.TabIndex = 40;
            this.rounded3.UnderlinedStyle = false;
            // 
            // rounded1
            // 
            this.rounded1.BackColor = System.Drawing.SystemColors.Window;
            this.rounded1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded1.BorderRadius = 15;
            this.rounded1.BorderSize = 2;
            this.rounded1.Location = new System.Drawing.Point(75, 23);
            this.rounded1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded1.Name = "rounded1";
            this.rounded1.PasswordChar = false;
            this.rounded1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded1.PlaceholderText = "";
            this.rounded1.Size = new System.Drawing.Size(658, 83);
            this.rounded1.TabIndex = 28;
            this.rounded1.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(103, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "    Quản Lý Tour";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Window;
            this.btnHome.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnHome.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 1;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::TestVerDoAn.Properties.Resources.logo1;
            this.btnHome.Location = new System.Drawing.Point(1, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(69, 54);
            this.btnHome.TabIndex = 42;
            this.btnHome.TextColor = System.Drawing.Color.Black;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmQuanLyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTim1);
            this.Controls.Add(this.btnSua1);
            this.Controls.Add(this.btnXoa1);
            this.Controls.Add(this.btnThem1);
            this.Controls.Add(this.btnLMoi1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rounded3);
            this.Controls.Add(this.rounded1);
            this.Name = "frmQuanLyTour";
            this.Text = "frmQuanLyTour";
            this.Load += new System.EventHandler(this.frmQuanLyTour_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtTim;
        private khanhtoan.rounded rounded1;
        private VBButton btnLMoi1;
        private VBButton btnThem1;
        private VBButton btnXoa1;
        private VBButton btnSua1;
        private VBButton btnTim1;
        private khanhtoan.rounded rounded3;
        private System.Windows.Forms.Label label2;
        private VBButton btnHome;
    }
}