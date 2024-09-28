namespace TestVerDoAn
{
    partial class frmThemHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemHopDong));
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.rounded4 = new khanhtoan.rounded();
            this.vbButton1 = new TestVerDoAn.VBButton();
            this.vbButton2 = new TestVerDoAn.VBButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rounded5 = new khanhtoan.rounded();
            this.SuspendLayout();
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.BackColor = System.Drawing.Color.White;
            this.rtbNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNoiDung.Location = new System.Drawing.Point(332, 126);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(241, 207);
            this.rtbNoiDung.TabIndex = 18;
            this.rtbNoiDung.Text = resources.GetString("rtbNoiDung.Text");
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(144, 156);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(155, 22);
            this.txtMaHD.TabIndex = 19;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLap.Location = new System.Drawing.Point(143, 256);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(155, 22);
            this.txtNgayLap.TabIndex = 21;
            this.txtNgayLap.Text = "yyyy/mm/dd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày Lập";
            // 
            // cboMaKH
            // 
            this.cboMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(144, 201);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(155, 23);
            this.cboMaKH.TabIndex = 29;
            // 
            // rounded4
            // 
            this.rounded4.BackColor = System.Drawing.SystemColors.Window;
            this.rounded4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded4.BorderRadius = 15;
            this.rounded4.BorderSize = 2;
            this.rounded4.Location = new System.Drawing.Point(92, 11);
            this.rounded4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded4.Name = "rounded4";
            this.rounded4.PasswordChar = false;
            this.rounded4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded4.PlaceholderText = "";
            this.rounded4.Size = new System.Drawing.Size(448, 85);
            this.rounded4.TabIndex = 33;
            this.rounded4.UnderlinedStyle = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.White;
            this.vbButton1.BackgroundColor = System.Drawing.Color.White;
            this.vbButton1.BorderColor = System.Drawing.Color.Black;
            this.vbButton1.BorderRadius = 10;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.Color.Black;
            this.vbButton1.Location = new System.Drawing.Point(162, 386);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(136, 31);
            this.vbButton1.TabIndex = 34;
            this.vbButton1.Text = "Thêm";
            this.vbButton1.TextColor = System.Drawing.Color.Black;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
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
            this.vbButton2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton2.ForeColor = System.Drawing.Color.Black;
            this.vbButton2.Location = new System.Drawing.Point(324, 386);
            this.vbButton2.Margin = new System.Windows.Forms.Padding(2);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(136, 31);
            this.vbButton2.TabIndex = 35;
            this.vbButton2.Text = "Hủy";
            this.vbButton2.TextColor = System.Drawing.Color.Black;
            this.vbButton2.UseVisualStyleBackColor = false;
            this.vbButton2.Click += new System.EventHandler(this.vbButton2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::TestVerDoAn.Properties.Resources.QLHDong;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(170, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 36);
            this.label11.TabIndex = 46;
            this.label11.Text = "      Thêm Hợp Đồng";
            // 
            // rounded5
            // 
            this.rounded5.BackColor = System.Drawing.Color.Black;
            this.rounded5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded5.BorderRadius = 0;
            this.rounded5.BorderSize = 2;
            this.rounded5.Location = new System.Drawing.Point(325, 119);
            this.rounded5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded5.Name = "rounded5";
            this.rounded5.PasswordChar = false;
            this.rounded5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded5.PlaceholderText = "";
            this.rounded5.Size = new System.Drawing.Size(255, 224);
            this.rounded5.TabIndex = 36;
            this.rounded5.UnderlinedStyle = false;
            this.rounded5.Load += new System.EventHandler(this.rounded5_Load);
            // 
            // frmThemHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.vbButton2);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.rtbNoiDung);
            this.Controls.Add(this.rounded4);
            this.Controls.Add(this.rounded5);
            this.Name = "frmThemHopDong";
            this.Text = "frmThemHopDong";
            this.Load += new System.EventHandler(this.frmThemHopDong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaKH;
        private khanhtoan.rounded rounded4;
        private VBButton vbButton1;
        private VBButton vbButton2;
        private System.Windows.Forms.Label label11;
        private khanhtoan.rounded rounded5;
    }
}