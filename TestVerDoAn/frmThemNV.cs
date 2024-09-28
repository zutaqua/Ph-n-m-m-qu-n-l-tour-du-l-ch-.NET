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
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmThemNV_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void hienthi()
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmdNV = new SqlCommand();
            sqlCmdNV.CommandType = CommandType.Text;
            sqlCmdNV.CommandText = "SELECT * FROM GiaThueNV";//lấy thông tin từ bảng

            sqlCmdNV.Connection = sqlCon;
            SqlDataReader readerNV = sqlCmdNV.ExecuteReader();
            cboChuyenMon.Items.Clear();
            while (readerNV.Read())
            {
                String Cmon = readerNV.GetString(0);
                cboChuyenMon.Items.Add(Cmon);
            }
            readerNV.Close();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rounded2_Load(object sender, EventArgs e)
        {

        }

        private void txtChuyenMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void rounded4_Load(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void vbButton2_Click(object sender, EventArgs e)
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
            String maNV = "";// cái Trim() sẽ loại bỏ khoảng trắng ở đầu và cuối
            String tenNV = txtTenNV.Text.Trim();
            String GTinh = txtGioiTinh.Text.Trim();
            String SDT = txtSDT.Text.Trim();
            String CMon = cboChuyenMon.Text.Trim();

            //tạo mã tự động
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

            //lấy chữ cái đầu của cmon
            String CMVT = "";
            string text = CMon;
            string[] words = text.Split(' ');
            foreach (string word in words)
            {

                try
                {
                    if (word.Length > 0)
                    {
                        CMVT += word[0];
                    }
                }
                catch (Exception)
                {
                    CMVT = "";
                }
            }
            maNV = "NV" + sodt + CMVT;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO NHANVIEN(MaNV,TenNV,GioiTinh,SDT,ChuyenMon) VALUES('" + maNV + "',N'" + tenNV + "',N'" + GTinh + "','" + SDT + "',N'" + CMon + "')";//thực hiện lệnh thêm vào cột
                                                                                                                                                                                  //Thêm N vào chỗ gõ TV không nó lỗi tiếng việt
            sqlCmd.Connection = sqlCon;


            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    MessageBox.Show("thêm nhân viên thành công", "Thông báo");
                    maNV = "";
                    frmQuanLyKH QuanLyKH = new frmQuanLyKH();
                    QuanLyKH.Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên Thất bại ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhân viên Thất bại, lý do:  " + ex.Message, "Thông báo");
            }
        }

        private void cboChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
