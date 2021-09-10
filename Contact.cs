using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Contact
    {
        public string name;
        public string address;
        public string city;
        public string state;

        public Contact(string name, string address,string city,string state)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
        }
    }
}

