using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Properties
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        List<taiKhoan> listtaikhoan;

        public List<taiKhoan> ListTaiKhoan { get => listtaikhoan; set => listtaikhoan = value; }
        public static DanhSachTaiKhoan Instance { 
            get
            {
                if(instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            } 
            set => instance = value; }

        DanhSachTaiKhoan()
        {
            listtaikhoan = new List<taiKhoan>();
            listtaikhoan.Add(new taiKhoan("admin", "admin", true));
            listtaikhoan.Add(new taiKhoan("001202","123",false));
            listtaikhoan.Add(new taiKhoan("001203", "123",false));
            listtaikhoan.Add(new taiKhoan("001204", "123", false));
        }
    }
    
}
