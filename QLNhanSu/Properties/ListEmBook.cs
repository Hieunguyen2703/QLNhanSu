using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu
{
    public class ListEmBook
    {
        private static ListEmBook instance;

        List<Embook> listNumEm;
        public List<Embook> listEm { get =>listNumEm;set => listNumEm = value; }

        public static ListEmBook Instance
        { 
            get 
            {
                if(instance == null)
                    instance = new ListEmBook();
                return instance; 
            }
            set => instance = value;
        }

        private ListEmBook()
        {
            listNumEm = new List<Embook>();
            //listNumEm.Add(new Embook("001203", "Nguyen Minh Hieu", "27/03/2003", "NVIT", "Ha Noi", "0372504006"));
            //listNumEm.Add(new Embook("001204", "Nguyen Duy Tuan", "04/12/2000", "NVHR", "Ha Noi", "0372504005"));
            //listNumEm.Add(new Embook("001205", "Nguyen Minh Tien", "30/12/2002", "NVSL", "Ha Noi", "0372504004"));
        }
    }
}
