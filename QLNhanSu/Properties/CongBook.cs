using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Properties
{
    public class CongBook
    {
        private string code;
        private string name;
        private string tinhTrang;
        private string checkInTime;
        private string checkOutTime;
     
        public string Code { get; set; }
        public string Name { get; set; }
        public string TinhTrang { get; set; }
        public string CheckInTime { get; set; }
        public string CheckOutTime { get; set; }

        public CongBook(string code, string name, string tinhTrang, string checkInTime, string checkOutTime)
        {
            Code = code;
            Name = name;
            TinhTrang = tinhTrang;
            CheckInTime = checkInTime;
            CheckOutTime = checkOutTime;
        }



        public CongBook(DataRow row)
        {
            Code = row["Code"].ToString();
            Name = row["Name"].ToString();
            TinhTrang = row["Tình Trạng"].ToString();
            CheckInTime = row["CheckInTime"].ToString();
            CheckOutTime = row["CheckOutTime"].ToString();

        }
    }
}

