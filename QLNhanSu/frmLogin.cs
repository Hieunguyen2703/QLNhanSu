using QLNhanSu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QLNhanSu
{
    public partial class frmLogin : Form
    {
        List<taiKhoan> listtaikhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            


            if (kiemTraDangNhap(txtTaikhoan.Text, txtMatkhau.Text))
            {
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Thông tin hoặc mật khẩu không chính xác");

        }

        private void F_DangXuat(object? sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        bool kiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0; i < listtaikhoan.Count; i++)
            {
                if(tentaikhoan == listtaikhoan[i].TenTaiKhoan && matkhau ==listtaikhoan[i].MatKhau)
                {
                    Const.TaiKhoan = listtaikhoan[i];
                    return true;
                }
                    
            }
            return false;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }



}
