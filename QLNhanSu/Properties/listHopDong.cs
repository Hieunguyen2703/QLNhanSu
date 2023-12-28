using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Properties
{
    public class listHopDong
    {
        private static listHopDong instance;
        List<hopDongLaoDong> listHD;
        public List<hopDongLaoDong> ListHD { get => listHD; set => listHD = value; }

        public static listHopDong Instance
        {
            get
            {
                if(instance == null)
                    instance = new listHopDong();
                return instance;
            }
            set { instance = value; }
        }

        

        private listHopDong()
        {
            ListHD = new List<hopDongLaoDong>();


            //ListHD.Add(new hopDongLaoDong("HD1", "001203", "2022-10-12", "2022-10-12", "2022-10-11"));
            //ListHD.Add(new hopDongLaoDong("HD2", "001204", "2022-11-12", "2022-11-12", "2022-11-11"));
            //ListHD.Add(new hopDongLaoDong("HD3", "001205", "2022-05-05", "2022-05-05", "2022-05-04"));
        }

    }
}
