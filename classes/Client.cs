using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.classes
{
    class Client :Person
    {
      
        public int Card_Id { get; set; }
        public int Client_Id { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}
