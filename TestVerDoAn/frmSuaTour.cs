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
    public partial class frmSuaTour : Form
    {
        public frmSuaTour()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmSuaTour_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
        }

        internal void layTT(String maTour,String tenTour, String TenDD,int SoNgay,String TenDV,string CMon,String Mota)
        {
            txtMaTour.Text = maTour;
            txtTenTour.Text = tenTour;
            cboDiaDiem.Text = TenDD;
            txtSoNgay.Text = Convert.ToString(SoNgay);
            cboDichVu.Text = TenDV;
            cboNhanVien.Text = CMon;
            txtMota.Text = Mota;
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

        /*private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            //lấy phần tử được chọn trên list view
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];

            //Hiển Thị thông tin vào ô txt trong form suaTour
            txtMaTour.Text = lvi.SubItems[0].Text;
            txtTenTour.Text = lvi.SubItems[1].Text;
            txtTenDD.Text = lvi.SubItems[2].Text;
            txtSoNgay.Text = lvi.SubItems[3].Text;
            txtDichVu.Text = lvi.SubItems[4].Text;
            txtNhanVien.Text = lvi.SubItems[5].Text;
            txtMota.Text = lvi.SubItems[6].Text;
        }*/

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("bạn chắc muốn sửa chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                if (sqlCon == null)//rỗng thì tạo mới
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
                {
                    sqlCon.Open();
                }

                String maT = txtMaTour.Text.Trim();
                String tenT = txtTenTour.Text.Trim();
                String tenDD = cboDiaDiem.Text.Trim();
                String soNg = txtSoNgay.Text.Trim();
                String DV = cboDichVu.Text.Trim();
                String Nv = cboNhanVien.Text.Trim();
                String MoTa = txtMota.Text.Trim();


                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE TOUR SET MaTour = '" + maT + "',TenTour = N'" + tenT + "',TenDD = N'" + tenDD + "',SoNgay = '" + soNg + "',TenDV = N'" + DV + "' , ChuyenMon = N'" + Nv + "', MoTa = N'" + MoTa + "'  WHERE MaTour = '" + maT + "'";

                sqlCmd.Connection = sqlCon;

                try
                {
                    int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                    if (kq > 0)
                    {

                        DialogResult q = MessageBox.Show("Sửa Tour thành công,vui lòng bấm làm mới","Thông Báo",MessageBoxButtons.OK);
                        if(q == DialogResult.OK)
                        {
                            this.Close();
                        }
                        //hienthidanhsach();
                        //this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Tour Thất bại ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa Tour Thất Bại, lý do:  " + ex.Message, "Thông báo");
                }
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
