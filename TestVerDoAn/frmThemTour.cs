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
    public partial class frmThemTour : Form
    {
        public frmThemTour()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmThemTour_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        private void hienthidanhsach()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmdDD = new SqlCommand();
            sqlCmdDD.CommandType = CommandType.Text;
            sqlCmdDD.CommandText = "SELECT * FROM GiaDiaDiem";

            SqlCommand sqlCmdDV = new SqlCommand();
            sqlCmdDV.CommandType = CommandType.Text;
            sqlCmdDV.CommandText = "SELECT * FROM GiaDichVu";

            SqlCommand sqlCmdNV = new SqlCommand();
            sqlCmdNV.CommandType = CommandType.Text;
            sqlCmdNV.CommandText = "SELECT * FROM GiaThueNV";


            sqlCmdDD.Connection = sqlCon;
            sqlCmdDV.Connection = sqlCon;
            sqlCmdNV.Connection = sqlCon;

            SqlDataReader readerDD = sqlCmdDD.ExecuteReader();
            cboDiaDiem.Items.Clear();
            while (readerDD.Read())
            {
                String TenDD = readerDD.GetString(0);
                cboDiaDiem.Items.Add(TenDD);
            }
            readerDD.Close();

            SqlDataReader readerDV = sqlCmdDV.ExecuteReader();
            cboDichVu.Items.Clear();
            while (readerDV.Read())
            {
                String TenDV = readerDV.GetString(0);
                cboDichVu.Items.Add(TenDV);
            }
            readerDV.Close();

            SqlDataReader readerNV = sqlCmdNV.ExecuteReader();
            cboNhanVien.Items.Clear();
            while (readerNV.Read())
            {
                String TenNV = readerNV.GetString(0);
                cboNhanVien.Items.Add(TenNV);
            }
            readerNV.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           
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
            String maT = txtMaTour.Text.Trim();
            String tenT = txtTenTour.Text.Trim();
            String tenDD = cboDiaDiem.Text.Trim();
            String soNg = txtSoNgay.Text.Trim();
            String DV = cboDichVu.Text.Trim();
            String Nv = cboNhanVien.Text.Trim();
            String MoTa = txtMota.Text.Trim();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO TOUR(MaTour,TenTour,TenDD,SoNgay,TenDV,ChuyenMon,MoTa) VALUES('" + maT + "',N'" + tenT + "',N'" + tenDD + "','" + soNg + "',N'" + DV + "',N'" + Nv + "',N'" + MoTa + "')";//thực hiện lệnh thêm vào cột
                                                                                                                                                                                                                        //Thêm N vào chỗ gõ TV không nó lỗi tiếng việt
            sqlCmd.Connection = sqlCon;


            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    MessageBox.Show("thêm Tour thành công", "Thông báo");
                    frmQuanLyKH QuanLyKH = new frmQuanLyKH();
                    QuanLyKH.Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm Tour Thất bại ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Tour Thất bại, lý do:  " + ex.Message, "Thông báo");
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
