using QLNhanSu.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu
{
    public class listDanhGia
    {
        List<danhGia> danhSachDanhGia;
        private static listDanhGia instance;

        public List<danhGia> DanhSachDanhGia { get => danhSachDanhGia; set => danhSachDanhGia = value; }
        public static listDanhGia Instance {
            get {
                if(instance == null)
                    instance = new listDanhGia();
                return instance;
            }
            set => instance = value; }

        public object ListHD { get; internal set; }

        private listDanhGia()
        {
            danhSachDanhGia = new List<danhGia>();
            //danhSachDanhGia.Add(new danhGia("001203", "Nguyen Minh Hieu", "Khen thưởng", "500000", "Làm việc tích cực"));
            //danhSachDanhGia.Add(new danhGia("001204", "Nguyen Duy Tuan", " Kỷ luật", "500000", "Đi làm muộn"));
            //danhSachDanhGia.Add(new danhGia("001205", "Nguyen Minh Tien", "Khen thưởng", "500000", "Làm việc tích cực"));


        }

    }
}
