namespace TestVerDoAn
{
    partial class frmQuanLyHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHopDong));
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.rounded1 = new khanhtoan.rounded();
            this.label1 = new System.Windows.Forms.Label();
            this.rounded2 = new khanhtoan.rounded();
            this.rounded3 = new khanhtoan.rounded();
            this.btnTim1 = new TestVerDoAn.VBButton();
            this.btnThem1 = new TestVerDoAn.VBButton();
            this.btnXoa1 = new TestVerDoAn.VBButton();
            this.btnLMoi1 = new TestVerDoAn.VBButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHome = new TestVerDoAn.VBButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(3, 16);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(317, 265);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hợp Đồng";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Khách Hàng";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Lập";
            this.columnHeader3.Width = 114;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvDanhSach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 284);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hợp Đồng";
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.BackColor = System.Drawing.SystemColors.Window;
            this.rtbNoiDung.Location = new System.Drawing.Point(453, 123);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.ReadOnly = true;
            this.rtbNoiDung.Size = new System.Drawing.Size(241, 277);
            this.rtbNoiDung.TabIndex = 16;
            this.rtbNoiDung.Text = "";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.BackColor = System.Drawing.SystemColors.Window;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(123, 60);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(78, 15);
            this.lblMaHD.TabIndex = 19;
            this.lblMaHD.Text = "Mã Hợp Đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHD.Location = new System.Drawing.Point(213, 62);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(113, 13);
            this.txtMaHD.TabIndex = 21;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKH.Location = new System.Drawing.Point(433, 61);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(113, 13);
            this.txtMaKH.TabIndex = 22;
            // 
            // rounded1
            // 
            this.rounded1.BackColor = System.Drawing.SystemColors.Window;
            this.rounded1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded1.BorderRadius = 15;
            this.rounded1.BorderSize = 2;
            this.rounded1.Location = new System.Drawing.Point(75, 11);
            this.rounded1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded1.Name = "rounded1";
            this.rounded1.PasswordChar = false;
            this.rounded1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded1.PlaceholderText = "";
            this.rounded1.Size = new System.Drawing.Size(623, 85);
            this.rounded1.TabIndex = 23;
            this.rounded1.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "          Quản Lý Hợp Đồng";
            // 
            // rounded2
            // 
            this.rounded2.BackColor = System.Drawing.SystemColors.Window;
            this.rounded2.BorderColor = System.Drawing.SystemColors.InfoText;
            this.rounded2.BorderFocusColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded2.BorderRadius = 10;
            this.rounded2.BorderSize = 1;
            this.rounded2.Location = new System.Drawing.Point(206, 54);
            this.rounded2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded2.Name = "rounded2";
            this.rounded2.PasswordChar = false;
            this.rounded2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded2.PlaceholderText = "";
            this.rounded2.Size = new System.Drawing.Size(126, 28);
            this.rounded2.TabIndex = 25;
            this.rounded2.UnderlinedStyle = false;
            // 
            // rounded3
            // 
            this.rounded3.BackColor = System.Drawing.SystemColors.Window;
            this.rounded3.BorderColor = System.Drawing.SystemColors.InfoText;
            this.rounded3.BorderFocusColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded3.BorderRadius = 10;
            this.rounded3.BorderSize = 1;
            this.rounded3.Location = new System.Drawing.Point(426, 54);
            this.rounded3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded3.Name = "rounded3";
            this.rounded3.PasswordChar = false;
            this.rounded3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded3.PlaceholderText = "";
            this.rounded3.Size = new System.Drawing.Size(126, 28);
            this.rounded3.TabIndex = 26;
            this.rounded3.UnderlinedStyle = false;
            // 
            // btnTim1
            // 
            this.btnTim1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTim1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnTim1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim1.BorderRadius = 10;
            this.btnTim1.BorderSize = 1;
            this.btnTim1.FlatAppearance.BorderSize = 0;
            this.btnTim1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim1.ForeColor = System.Drawing.Color.Black;
            this.btnTim1.Image = ((System.Drawing.Image)(resources.GetObject("btnTim1.Image")));
            this.btnTim1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim1.Location = new System.Drawing.Point(566, 53);
            this.btnTim1.Name = "btnTim1";
            this.btnTim1.Size = new System.Drawing.Size(102, 29);
            this.btnTim1.TabIndex = 27;
            this.btnTim1.Text = "     Tìm Hợp Đồng";
            this.btnTim1.TextColor = System.Drawing.Color.Black;
            this.btnTim1.UseVisualStyleBackColor = false;
            this.btnTim1.Click += new System.EventHandler(this.btnTim1_Click);
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
            this.btnThem1.Location = new System.Drawing.Point(342, 415);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(96, 29);
            this.btnThem1.TabIndex = 28;
            this.btnThem1.Text = "Thêm Hợp Đồng";
            this.btnThem1.TextColor = System.Drawing.Color.Black;
            this.btnThem1.UseVisualStyleBackColor = false;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
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
            this.btnXoa1.Location = new System.Drawing.Point(552, 415);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(87, 29);
            this.btnXoa1.TabIndex = 29;
            this.btnXoa1.Text = "Xóa Hợp Đồng";
            this.btnXoa1.TextColor = System.Drawing.Color.Black;
            this.btnXoa1.UseVisualStyleBackColor = false;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
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
            this.btnLMoi1.Location = new System.Drawing.Point(126, 415);
            this.btnLMoi1.Name = "btnLMoi1";
            this.btnLMoi1.Size = new System.Drawing.Size(87, 29);
            this.btnLMoi1.TabIndex = 30;
            this.btnLMoi1.Text = "Làm Mới";
            this.btnLMoi1.TextColor = System.Drawing.Color.Black;
            this.btnLMoi1.UseVisualStyleBackColor = false;
            this.btnLMoi1.Click += new System.EventHandler(this.btnLMoi1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Thông Tin Hợp Đồng";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Window;
            this.btnHome.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnHome.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 1;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::TestVerDoAn.Properties.Resources.logo1;
            this.btnHome.Location = new System.Drawing.Point(3, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(67, 53);
            this.btnHome.TabIndex = 32;
            this.btnHome.TextColor = System.Drawing.Color.Black;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmQuanLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLMoi1);
            this.Controls.Add(this.btnXoa1);
            this.Controls.Add(this.btnThem1);
            this.Controls.Add(this.btnTim1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.rtbNoiDung);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rounded3);
            this.Controls.Add(this.rounded2);
            this.Controls.Add(this.rounded1);
            this.Name = "frmQuanLyHopDong";
            this.Text = "frmQuanLyHopDong";
            this.Load += new System.EventHandler(this.frmQuanLyHopDong_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private khanhtoan.rounded rounded1;
        private System.Windows.Forms.Label label1;
        private khanhtoan.rounded rounded2;
        private khanhtoan.rounded rounded3;
        private VBButton btnTim1;
        private VBButton btnThem1;
        private VBButton btnXoa1;
        private VBButton btnLMoi1;
        private System.Windows.Forms.Label label3;
        private VBButton btnHome;
    }
}