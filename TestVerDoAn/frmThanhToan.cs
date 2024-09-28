using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestVerDoAn
{
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        private void hienthidanhsach()
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM TOUR_DA_DK";//lấy thông tin từ bảng

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            lsvDanhSach.Items.Clear();//dọn list view

            while (reader.Read())//thực hiện đọc
            {
                String DD = reader.GetString(0);//lấy cột 0 tức mã 
                String DV = reader.GetString(1);// lấy cột 1 phần ten
                String CMon = reader.GetString(2);
                String SNg = Convert.ToString(reader.GetInt32(3));
                String MTa = reader.GetString(4);
                String MaKH = "";
                try
                {
                    MaKH = reader.GetString(5);
                }catch (Exception)
                {
                    MaKH = "Null";
                }
                
                ListViewItem lvi = new ListViewItem(DD); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(DV);
                lvi.SubItems.Add(CMon);
                lvi.SubItems.Add(SNg);
                lvi.SubItems.Add(MTa);
                lvi.SubItems.Add(MaKH);

                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }
        String DD = "";
        String DV = "";
        String CMon = "";
        int SNg = 0;
        String MTa = "";
        String MKH = "";
        DateTime Time = DateTime.Now;
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;//nếu chưa chọn j thì không làm j cả

            //lấy phần tử được chọn trên list view
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];

            //lấy mã  để thực hiện xóa
            DD = lvi.SubItems[0].Text.Trim();
            DV = lvi.SubItems[1].Text.Trim();
            CMon = lvi.SubItems[2].Text.Trim();
            SNg = Convert.ToInt32( lvi.SubItems[3].Text.Trim());
            MTa = lvi.SubItems[4].Text.Trim();
            MKH = lvi.SubItems[5].Text.Trim();

            hienthiGiaTien(DD, DV, CMon, SNg, MTa,MKH);
        }
        int TinhTong = 0;
        private void hienthiGiaTien(String DD, String DV,String CMon,int SNg,String MTa,String MKH)
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }

            //lấy địa diểm + giá địa điểm
            SqlCommand sqlCmdDD = new SqlCommand();
            sqlCmdDD.CommandType = CommandType.Text;
            sqlCmdDD.CommandText = "SELECT * FROM GiaDiaDiem WHERE TenDD LIKE N'%"+DD+"%'";

            
            sqlCmdDD.Connection = sqlCon;
            SqlDataReader readerDD = sqlCmdDD.ExecuteReader();
            int GiaDD = 0;
            String TenDD = "";
            while (readerDD.Read())
            {
                TenDD = readerDD.GetString(0); // vị trí 0 là ten 
                GiaDD = readerDD.GetInt32(1);

                String LineDD = TenDD.Trim()+"/"+Convert.ToString(GiaDD) + " VND";

                txtDiaDiem.Text = LineDD;
            }
            readerDD.Close();

            //lấy dịch vụ + giá dịch vụ
            SqlCommand sqlCmdDV = new SqlCommand();
            sqlCmdDV.CommandType = CommandType.Text;
            sqlCmdDV.CommandText = "SELECT * FROM GiaDichVu WHERE TenDV LIKE N'%" + DV + "%'";

            sqlCmdDV.Connection = sqlCon;
            SqlDataReader readerDV = sqlCmdDV.ExecuteReader();
            int GiaDV = 0;
            while (readerDV.Read())
            {
                String TenDV = readerDV.GetString(0); // vị trí 0 là ten 
                GiaDV = readerDV.GetInt32(1);

                String LineDV = TenDV.Trim() + "/" + Convert.ToString(GiaDV) + " VND";

                txtDichVu.Text =LineDV;
            }
            readerDV.Close();

            //lấy Chuyên Môn NV + giá thuê
            SqlCommand sqlCmdNV = new SqlCommand();
            sqlCmdNV.CommandType = CommandType.Text;
            sqlCmdNV.CommandText = "SELECT * FROM GiaThueNV WHERE ChuyenMon LIKE N'%" + CMon + "%'";

            sqlCmdNV.Connection = sqlCon;
            SqlDataReader readerNV = sqlCmdNV.ExecuteReader();
            int GiaTNV = 0;
            while (readerNV.Read())
            {
                String TenNV = readerNV.GetString(0); // vị trí 0 là ten 
                GiaTNV = readerNV.GetInt32(1);

                String LineNV = TenNV.Trim() + "/" + Convert.ToString(GiaTNV) + " VND";

                txtChuyenMon.Text = LineNV;
            }
            readerNV.Close();

            //lấy số ngày 
            txtSoNgay.Text = Convert.ToString(SNg) + " Ngày";

            //Tính Tổng
            TinhTong = (GiaTNV + GiaDD + GiaDV)*SNg;
            txtTongTien.Text = Convert.ToString((int)TinhTong) + " VND";

            //lấy ngày tháng hiện tại
            
            int Ngay = Time.Day;
            int Thang = Time.Month;
            int Nam = Time.Year;
            int Gio = Time.Hour;
            int Milli = Time.Second;

            //lấy chữ cái đầu của địa điểm
            String DDVT = "" ;
            string text =TenDD;
            String firtChar = ""; 
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                try {
                    DDVT = Convert.ToString(word.First());
                    firtChar = Convert.ToString(text.First());
                }
                catch(Exception)
                {
                    DDVT = "";
                    firtChar = "";
                }
                
            }

            //mã hợp đồng được tạo từ HD + ngày tháng năm + giờ + Giây hiện tại(không lấy phút đâu :>)
            String HD = "HD" + Convert.ToString(SNg)+firtChar + DDVT + Convert.ToString(Ngay)+ Convert.ToString(Thang)+ Convert.ToString(Nam)+Convert.ToString(Gio)+Convert.ToString(Milli) ;
            txtMaHD.Text = HD;
            
            txtMaKH.Text = MKH;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaKiTu();
        }

        private void XoaKiTu()
        {
            txtDiaDiem.Text = "";
            txtDichVu.Text = "";
            txtChuyenMon.Text = "";
            txtSoNgay.Text = "";
            txtTongTien.Text = "";
            txtMaHD.Text = "";
            txtCM.Text = "";
            txtDD.Text = "";
            txtDV.Text = "";
            txtMaKH.Text = "";
        }
         
        private void inHoaDon()
        {
            string filePath = "C:\\Users\\Admin\\OneDrive\\Máy tính\\đồ án 1\\"+txtMaHD.Text+".txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(txtMaHD.Text + "\n");
                writer.Write(txtMaKH.Text + "\n");
                writer.Write(txtDiaDiem.Text + "\n");
                writer.Write(txtDichVu.Text + "\n");
                writer.Write(txtChuyenMon.Text + "\n");
                writer.Write(txtSoNgay.Text + "\n");
                writer.Write(txtTongTien.Text);
            }    
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Bạn Đã Thanh Toán Hóa Đơn Thành Công Bạn có muôn in hóa đơn ???","Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ms == DialogResult.OK)
            {
                inHoaDon();
                this.Close();

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
        }
            

        //Khai báo biến thời Gian để lấy Thời Gian
        String TG = "";
        //lấy SDT,ten
        String SDT = "";
        String tenKH = "";
        private void taoHoaDon()
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }

            //lấy tên KH thông qua mã
            SqlCommand sqlCmdkh = new SqlCommand();
            sqlCmdkh.CommandType = CommandType.Text;
            sqlCmdkh.CommandText = "SELECT * FROM KHACHHANG WHERE MaKH = '" + MKH + "'";//lấy thông tin từ bảng kh

            //khai báo tên Khách Hàng để lấy tên
            
            sqlCmdkh.Connection = sqlCon;
            SqlDataReader readerkh = sqlCmdkh.ExecuteReader();  //tạo đầu đọc
            while (readerkh.Read())//thực hiện đọc
            {
                //String maKH = readerkh.GetString(0);//lấy cột 0 tức mã kh
                tenKH = readerkh.GetString(1);// lấy cột 1 phần ten
                //String QuocTich = readerkh.GetString(2);// lấy cột 2 phần qtich
                //String DiaChi = readerkh.GetString(3);
                SDT = readerkh.GetString(4);
                //String GT = readerkh.GetString(5);
            }
            readerkh.Close();//đóng đầu đọc (không có lỗi luôn)

            //Lấy dữ liệu từ các ô textbox
            String mHD = txtMaHD.Text.Trim();
            String mKH = txtMaKH.Text.Trim();
            int STien = TinhTong;

            //Khai báo để định dạng thời Gian
            String Nam = Time.Year.ToString();
            String Thang = Time.Month.ToString();
            String Ngay = Time.Day.ToString();
            String Gio = Time.Hour.ToString();
            String Phut = Time.Minute.ToString();
            String Giay = Time.Second.ToString();
            //định Dạng Thời Gian
            TG = Nam + "/" + Thang + "/" + Ngay + " " + Gio + ":" + Phut + ":" + Giay; 
            //Thêm các dữ liệu vào bảng Hóa Đơn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO HOADON(MaHDON,MaKH,TenKH,SoTien,NgayLap) VALUES('" + mHD + "','" + mKH + "',N'"+tenKH+"'," + STien + ",'" + TG + "')";//thực hiện lệnh thêm vào cột
                                                                                                                                                                                  //Thêm N vào chỗ gõ TV không nó lỗi tiếng việt
            sqlCmd.Connection = sqlCon;
            
            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    //MessageBox.Show("Tạo Hóa Đơn thành công", "Thông báo");
                    
                }
                else
                {
                    MessageBox.Show("Tạo Hóa Đơn Thất bại ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo Hóa Đơn Thất bại, lý do:  " + ex.Message, "Thông báo");
            }
            
        }

        //loại bỏ tour đã đã đăng ký và tạo hợp đông để tránh lập lại hóa đơn vs Hợp đồng
        private void xoaTour_Da_DK()
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM TOUR_DA_DK WHERE TenDD LIKE N'%"+DD+ "%' AND TenDV LIKE N'%" + DV+ "%' AND ChuyenMon LIKE N'%" + CMon+ "%' AND MaKH LIKE '%" + MKH+"%'";

            sqlCmd.Connection = sqlCon;

            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    //MessageBox.Show("Xóa TOUR_DA_DK thành công");
                    hienthidanhsach();
                }
                else
                {
                    MessageBox.Show("Xóa TOUR_DA_DK Thất bại ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa TOUR_DA_DK Thất bại, lý do:  " + ex.Message, "Thông báo");
            }
        }

        private void taoHopDong()
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }
            //lấy ngày tháng năm hiện tại
            String y = Time.Year.ToString();
            String M = Time.Month.ToString();
            String D = Time.Day.ToString();
            //lấy số đt cuối của KH
            string layBaSoCuoi(string chuoiSo)
            {
                if (chuoiSo.Length < 3)
                {
                    return chuoiSo;
                }

                return chuoiSo.Substring(chuoiSo.Length - 3);
            }

            String SDTT = "";
            SDTT = layBaSoCuoi(SDT);
            //Tạo Mã HD
            String mHD = "HOPD"+D+M+y+SDTT;

            // Tạo Ghi chú Nội Dung
            String MHDD = txtMaHD.Text;
            //String MKHh = txtMaKH.Text;
            String DDD = txtDiaDiem.Text;
            String DVV = txtDichVu.Text;
            String CMo = txtChuyenMon.Text;
            String SNG = txtSoNgay.Text;
            String TT = txtTongTien.Text;

            String ND = "\t Nội Dung Hợp Đồng \nMã Hợp Đồng: "+MHDD + "mã Khách Hàng: "+MKH + "\nTên Khách Hàng: "+tenKH+"\n\n \t Các Khoản Thu \n"+
                "\nĐịa Điểm: " + DDD + "\nDịch Vụ: " + DVV + "\nChuyên Môn NV: " + CMo + "\nSố Ngày: " + SNG + "\nTổng Tiền: " + TT + "\n\n" + "\tĐã Thanh Toán Thành Công";

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO HOPDONG(MaHD,MaKH,NgayLap,NoiDung) VALUES('" + mHD + "','" + MKH + "','" + TG + "',N'" + ND + "')";
                                                                                                                                             
            sqlCmd.Connection = sqlCon;


            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    //MessageBox.Show("tạo Hợp Đồng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tạo Hợp Đồng Thất bại ", "Thông báo");
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Tạo Hợp Đồng Thất bại,lý do: "+ex, "Thông báo");
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }


            //Thưc hiện thêm dữ liệu vào
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            String DD = "";
            String DV = "";
            String CMon = "";
            DD = txtDD.Text.Trim();
            DV = txtDV.Text.Trim();
            CMon = txtCM.Text.Trim();

            sqlCmd.CommandText = "SELECT * FROM TOUR_DA_DK WHERE TenDD LIKE N'%" + DD + "%' AND TenDV LIKE N'%" + DV + "%' AND ChuyenMon LIKE N'%" + CMon + "%' ;";//lấy thông tin từ bảng 

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc

            lsvDanhSach.Items.Clear();//dọn list view cũ
            while (reader.Read())//thực hiện đọc
            {

                String DDiem = reader.GetString(0);//lấy cột 0 tức đia điểm
                String DVu = reader.GetString(1);// lấy cột 1 phần 
                String ChMon = reader.GetString(2);
                String SNg = Convert.ToString(reader.GetInt32(3));
                String MTa = reader.GetString(4);
                String MaKH = reader.GetString(5);

                ListViewItem lvi = new ListViewItem(DDiem); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(DVu);
                lvi.SubItems.Add(ChMon);
                lvi.SubItems.Add(SNg);
                lvi.SubItems.Add(MTa);
                lvi.SubItems.Add(MaKH);

                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {

            DialogResult kq = MessageBox.Show(" Bạn Đã Hoàn Thành Thanh Toán\n Hợp Đồng đã được tạo Thành Công !!!\n Vui Lòng Vào Phần Hợp Đồng để Xem Chi Tiết Hợp Đồng\n Bạn Có Muốn In Hóa Đơn", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            taoHoaDon();
            xoaTour_Da_DK();
            taoHopDong();
            if (kq == DialogResult.OK)
            {
                inHoaDon();
            }
            XoaKiTu();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {

        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rounded9_Load(object sender, EventArgs e)
        {

        }

        private void txtDiaDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
