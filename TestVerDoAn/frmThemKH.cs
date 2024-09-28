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
    public partial class frmThemKH : Form
    {
        
        public frmThemKH()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmThemKH_Load(object sender, EventArgs e)
        {
              
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            
            
        }
        public static int Taosongaunhien()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 1000); // Tạo số ngẫu nhiên từ 1 đến 999

            // Format số ngẫu nhiên thành chuỗi có 3 ký tự
            string formattedNumber = randomNumber.ToString("000");

            // Chuyển đổi chuỗi thành số nguyên
            return int.Parse(formattedNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void rounded2_Load(object sender, EventArgs e)
        {

        }

        private void rounded2_Load_1(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuocTich_TextChanged(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            //thêm khach hang
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }
            //Lấy dữ liệu từ các ô textbox
            String maKH = "";
            String tenKH = txtTenKH.Text.Trim();// cái Trim() sẽ loại bỏ khoảng trắng ở đầu và cuối
            String QTich = txtQuocTich.Text.Trim();
            String DChi = txtDiaChi.Text.Trim();
            String SDT = txtSDT.Text.Trim();
            String GTinh = txtGioiTinh.Text.Trim();

            //tạo mã Khách hàng tự động
            // lấy 3 số cuối của sdt
            string layBaSoCuoi(string chuoiSo)
            {
                if (chuoiSo.Length < 3)
                {
                    return chuoiSo;
                }

                return chuoiSo.Substring(chuoiSo.Length - 3);
            }
            String sodt = layBaSoCuoi(SDT);

            //lấy chữ cái đầu của địa chỉ
            String DDVT = "";
            string text = DChi;
            string[] words = text.Split(' ');
            foreach (string word in words)
            {

                try
                {
                    if (word.Length > 0)
                    {
                        DDVT += word[0];
                    }
                }
                catch (Exception)
                {
                    DDVT = "";
                }
            }

            int ranNum = Taosongaunhien(); // phòng khi thực sự cần đền cái j đó ngẫu nhiên :>

            maKH = "KH" + sodt + DDVT;


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO KHACHHANG(MaKH,TenKH,QuocTich,DiaChi,SDT,GioiTinh) VALUES(N'" + maKH + "',N'" + tenKH + "',N'" + QTich + "',N'" + DChi + "',N'" + SDT + "',N'" + GTinh + "')";//thực hiện lệnh thêm vào cột
            //Thêm N vào không nó lỗi tiếng việt
            sqlCmd.Connection = sqlCon;


            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    MessageBox.Show("thêm khách hàng thành công");
                    frmQuanLyKH QuanLyKH = new frmQuanLyKH();
                    QuanLyKH.Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng Thất bại ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm khách hàng Thất bại, lý do:  " + ex.Message, "Thông báo");
            }

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
