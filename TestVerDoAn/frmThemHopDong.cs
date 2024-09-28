using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestVerDoAn
{
    public partial class frmThemHopDong : Form
    {
        public frmThemHopDong()
        {
            InitializeComponent();
        }

        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmThemHopDong_Load(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void hienthiKH()
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
            sqlCmd.CommandText = "SELECT * FROM KHACHHANG";//lấy thông tin từ bảng

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            cboMaKH.Items.Clear();
            while (reader.Read())//thực hiện đọc
            {
                String maKH= reader.GetString(0);//lấy cột 0 tức mã 
                
                cboMaKH.Items.Add(maKH);

            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
          
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

            //Lấy dữ liệu từ các ô textbox
            String maHD = txtMaHD.Text.Trim();// cái Trim() sẽ loại bỏ khoảng trắng ở đầu và cuối
            String maKH = cboMaKH.Text.Trim();
            String ngayLap = txtNgayLap.Text.Trim();
            String ND = rtbNoiDung.Text.Trim();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO HOPDONG(MaHD,MaKH,NgayLap,NoiDung) VALUES('" + maHD + "',N'" + maKH + "','" + ngayLap + "',N'" + ND + "')";//thực hiện lệnh thêm vào cột
                                                                                                                                                         //Thêm N vào chỗ gõ TV không nó lỗi tiếng việt
            sqlCmd.Connection = sqlCon;


            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    MessageBox.Show("thêm Hợp Đồng thành công", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Thêm Hợp Đồng Thất bại ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Hợp Đồng Thất bại, lý do:  " + ex.Message, "Thông báo");
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rounded5_Load(object sender, EventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
