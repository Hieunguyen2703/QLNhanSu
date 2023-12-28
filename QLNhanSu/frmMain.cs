using QLNhanSu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class frmMain : Form
    {
        public bool isThoat = true;
        bool isAdmin = Const.TaiKhoan.LoaiTaiKhoan;
        public frmMain()
        {
            InitializeComponent();
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khaiBáoThôngTinHĐLĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHopDongLaoDongcs chay = new frmHopDongLaoDongcs();
            chay.Show();
        }

        private void khaiBáoHồSơNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxbEmployeeCode bt = new TxbEmployeeCode();
            bt.ShowDialog();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isThoat)
            {
                frmLogin f = new frmLogin();
                f.Show();
                this.Hide();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            isThoat = false;
            Application.Exit();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void phanQuyen()
        {

        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            phanQuyen();

        }

        private void xemBảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemLuong f = new frmXemLuong();
            f.ShowDialog();

        }

        private void đánhGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                đánhGiáToolStripMenuItem.Visible = false;
            }
            else
            {
                frmDanhGia f = new frmDanhGia();
                f.ShowDialog();


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbChamcong f = new txbChamcong();
            f.Show();
            this.Hide();
        }
    }
}
