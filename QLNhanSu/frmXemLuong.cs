using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QLNhanSu.Properties;

namespace QLNhanSu
{
    public partial class frmXemLuong : Form
    {
        public frmXemLuong()
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
        private float TinhLuongPhuCap(luongNhanVien employeeSalary)
        {
            if (employeeSalary != null)
            {
                // Tính toán tổng lương phụ cấp
                float tongLuongPhuCap = employeeSalary.PhuCapAnTrua + employeeSalary.PhuCapTrachNhiem;
                return tongLuongPhuCap;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin lương của bạn.");
                return 0f; // Trả về giá trị mặc định nếu không tìm thấy thông tin lương
            }
        }
        private float TinhTongLuong(luongNhanVien employeeSalary)
        {
            if (employeeSalary != null)
            {
                // Tính toán tổng lương (ví dụ: lương cơ bản + lương phụ cấp) nhân với hệ số lương
                float tongLuong = (employeeSalary.LuongCoban + (employeeSalary.PhuCapAnTrua + employeeSalary.PhuCapTrachNhiem)) * employeeSalary.HeSoLuong;

                return tongLuong;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin lương của bạn.");
                return 0f; // Trả về giá trị mặc định nếu không tìm thấy thông tin lương
            }
        }

        private void XemThongTinLuong()
        {
            string tenTaiKhoan = Const.TaiKhoan.TenTaiKhoan;


            luongNhanVien employeeSalary = listLuongNhanVien.Instance.ListLuong.FirstOrDefault(emp => emp.Code == tenTaiKhoan);

            if (employeeSalary != null)
            {
                float luongPhuCap = TinhLuongPhuCap(employeeSalary);
                txbLuongPhuCap.Text = luongPhuCap.ToString();
                txbMaNhanVien.Text = employeeSalary.Code;
                txbTenNhanVien.Text = employeeSalary.Name;
                txbLuongCoBan.Text = employeeSalary.LuongCoban.ToString();
                txbNgayCong.Text = employeeSalary.NgayCong.ToString();
                txbHeSoLuong.Text = employeeSalary.HeSoLuong.ToString();
                txbPCAnTrua.Text = employeeSalary.PhuCapAnTrua.ToString();
                txbPCTrachNhiem.Text = employeeSalary.PhuCapTrachNhiem.ToString();
                float tongLuong = TinhTongLuong(employeeSalary);
                txbTongLuong.Text = tongLuong.ToString();
            }
            //else
            //{
            //    // Không tìm thấy thông tin lương cho người dùng hiện tại
            //    MessageBox.Show("Không tìm thấy thông tin lương của bạn.");
            //}
        }

        private void frmXemLuong_Load(object sender, EventArgs e)
        {

            XemThongTinLuong();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

