using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Properties
{
    public class taiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        private bool loaiTaiKhoan;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public bool LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }

        
       
        public taiKhoan(string tentaikhoan, string matkhau,bool loaitaikhoan)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }
    }
}
