using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Properties
{
    public class danhGia
    {
        private string name;
        private string code;
        private string soTien;
        private string tenLoai;
        private string liDo;
        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public string SoTien { get => soTien; set => soTien = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string LiDo { get => liDo; set => liDo = value; }

        public danhGia() { }

        public danhGia(string code, string name, string tenLoai, string soTien,string liDo)
        {
            this.code = code;
            this.name = name;
            this.soTien = soTien;
            this.tenLoai = tenLoai;
            this.liDo = liDo;
        }
        public danhGia(DataRow row)
        {
            Code = row["Code"].ToString();
            Name = row["Name"].ToString();
            SoTien = row["SoTien"].ToString();
            //liDo = row["LiDo"].ToString();
            

            if (row.Table.Columns.Contains("LiDo"))
            {
                LiDo = row["LiDo"].ToString();
            }
            else
            {
                LiDo = ""; // Gán giá trị mặc định hoặc xử lý khác khi 'LiDo' không tồn tại
                Console.WriteLine("Cột 'LiDo' không tồn tại trong dữ liệu.");
            }
            tenLoai = row["TenLoai"].ToString();
        }

    }


}
