using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestVerDoAn
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }
        private void dangnhap()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True;");
            try
            {
                conn.Open();
                String tk = txtTaiKhoan.Text;
                String mk = txtMatKhau.Text;
                String sql = "SELECT * FROM NguoiDung where TaiKhoan = '" + tk + "'and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    frmMenuChinh MenuChinh = new frmMenuChinh();
                    //MenuChinh.MdiParent = this;
                    MenuChinh.Show();
                    this.Hide();
                    MenuChinh.dangxuat += MenuChinh_dangxuat;

                    //xóa kí tự sau khi bấm đang nhập(thực ra là thay cũ bằng rỗng :>)
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Text = "";

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi,ket noi that bai do: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //viết event
        private void MenuChinh_dangxuat(object sender, EventArgs e)
        {
            (sender as frmMenuChinh).isthoat = false;
            (sender as frmMenuChinh).Close();
            this.Show();
        }


        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            dangnhap();
        }
        private void thoat()
        {
            //this.Close();
            DialogResult dl;
            dl = MessageBox.Show("Bạn có muốn thoát chương trình??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void rounded3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0' ;
            }else
            {
                txtMatKhau.PasswordChar = '*';
            }    
        }
    }
}
