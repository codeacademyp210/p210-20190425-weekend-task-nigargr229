using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.classes
{
    class Employee : Person
    {        
        public int Card_Id { get; set; }
        public string Position { get; set; }
        public int Birthday { get; set; }
        public int Salary { get; set; }
    }
}
