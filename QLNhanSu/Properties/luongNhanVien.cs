using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Properties
{
    public class luongNhanVien
    {
        private string code;
        private string name;
        private float heSoLuong;
        private float luongCoban;
        private int ngayCong;
        private float phuCapAnTrua;
        private float phuCapTrachNhiem;
        

        public float LuongCoban { get => luongCoban; set => luongCoban = value; }
        public int NgayCong { get => ngayCong; set => ngayCong = value; }
        public float PhuCapAnTrua { get => phuCapAnTrua; set => phuCapAnTrua = value; }
        public float PhuCapTrachNhiem { get => phuCapTrachNhiem; set => phuCapTrachNhiem = value; }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
      

        public luongNhanVien(string code, string name, float heSoLuong, float luongCoban, int ngayCong, float phuCapAnTrua, float phuCapTrachNhiem)
        {
            this.code = code;
            this.name = name;
            this.heSoLuong = heSoLuong;
            this.luongCoban = luongCoban;
            this.ngayCong = ngayCong;
            this.phuCapAnTrua = phuCapAnTrua;
            this.phuCapTrachNhiem = phuCapTrachNhiem;
        }
        public luongNhanVien(DataRow row)
        {
            Code = row["Code"].ToString();
            Name = row["Name"].ToString();
            HeSoLuong = Convert.ToSingle(row["HeSoLuong"]);
            NgayCong = Convert.ToInt32(row["NgayCong"]);
            PhuCapAnTrua = Convert.ToSingle(row["PhuCapAnTrua"]);
            PhuCapTrachNhiem = Convert.ToSingle(row["PhuCapTrachNhiem"]);
        }
    }
}
