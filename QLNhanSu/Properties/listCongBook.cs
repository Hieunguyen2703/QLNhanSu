using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Properties
{
    public class listCongBook
    {
        private static listCongBook instance;

        List<CongBook> listNumCNV;
        public List<CongBook> listCNV { get => listNumCNV; set => listNumCNV = value; }

        public static listCongBook Instance
        {
            get
            {
                if (instance == null)
                    instance = new listCongBook();
                return instance;
            }
            set => instance = value;
        }

        private listCongBook()
        {
            listNumCNV = new List<CongBook>();
            //listNumCNV.Add(new CongBook("001203", "Nguyen Minh Hieu", "Đi lam", "8h00", "17h00"));
            //listNumCNV.Add(new CongBook("001204", "Nguyen Duy Tuan", "Nghi om", "", ""));
            //listNumCNV.Add(new CongBook("001205", "Nguyen Minh Tien", "Đi lam", "8h30", ""));
        }
    }
}

