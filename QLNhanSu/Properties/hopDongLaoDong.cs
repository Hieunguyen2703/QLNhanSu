using QLNhanSu;
using System.Data;
using System.Drawing.Text;
using System.Net;
using System.Xml.Linq;

namespace QLNhanSu
{
    public class hopDongLaoDong
    {
        private string maHD;
        private string ngayBatDau;
        private string ngayKetTHuc;
        private string ngayKy;
        private string code;



        public string MaHD { get => maHD; set => maHD = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetTHuc { get => ngayKetTHuc; set => ngayKetTHuc = value; }
        public string NgayKy { get => ngayKy; set => ngayKy = value; }
        public string Code { get => code; set => code = value; }

        public hopDongLaoDong(string maHD, string maNhanVien, string ngayBatDau, string ngayKetTHuc, string ngayKy)
        {
            this.maHD = maHD;
            this.Code = maNhanVien;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetTHuc = ngayKetTHuc;
            this.ngayKy = ngayKy;

        }

        public hopDongLaoDong(DataRow row)
        {
            MaHD = row["MaHD"].ToString();
            Code = row["Code"].ToString();
            NgayBatDau = row["NgayBatDau"].ToString();
            NgayKetTHuc = row["NgayKetTHuc"].ToString();
            ngayKy = row["ngayKy"].ToString();

        }

    }
}
