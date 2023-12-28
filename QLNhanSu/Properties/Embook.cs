using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu
{
    public class Embook
    {
        private string nCode;
        private string name;
        private string dateOfBrith;
        private string position;
        private string address;
        private string numberPhone;

        public string Code { get => nCode; set => nCode = value; }
        public string Name { get => name;set => name = value; }
        public string DateOfBrith { get => dateOfBrith;set => dateOfBrith = value; }
        public string Position { get => position; set => position = value; }
        public string Address { get => address; set => address = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }


        public Embook(string nCode, string name, string dateOfBrith, string position, string address, string numberPhone)
        {
            Code = nCode;
            Name = name;    
            DateOfBrith = dateOfBrith;
            Position = position;
            Address = address;
            NumberPhone = numberPhone;
        }

        public Embook(DataRow row)
        {
            Code = row["Code"].ToString();
            Name = row["Name"].ToString();
            DateOfBrith = row["DateOfBrith"].ToString();
            Position = row["Position"].ToString();
            Address = row["Address"].ToString();
            NumberPhone = row["NumberPhone"].ToString();

        }

    }
}
