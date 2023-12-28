namespace QLNhanSu.Properties
{
    public class listLuongNhanVien
    {
        private static listLuongNhanVien instance;
        List<luongNhanVien> listLuong;

        public static listLuongNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new listLuongNhanVien();
                return instance;
            }
            set => instance = value;
        }

        public List<luongNhanVien> ListLuong { get => listLuong; set => listLuong = value; }

        // Đổi từ private thành public hoặc protected
        private listLuongNhanVien()
        {
            listLuong = new List<luongNhanVien>();
            listLuong.Add(new luongNhanVien("001203", "Nguyen Minh Hieu", 5.5f, 1000000f, 26, 500000f, 300000f));
            listLuong.Add(new luongNhanVien("001204", "Nguyen Duy Tuan", 3.5f, 1000000f, 26, 500000f, 300000f));
            listLuong.Add(new luongNhanVien("001205", "Nguyen Minh Tien", 2.5f, 1000000f, 27, 500000f, 300000f));
        }

    }

}
