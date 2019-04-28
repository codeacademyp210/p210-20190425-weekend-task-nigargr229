using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.classes
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Card_Id { get; set; }

        public static int Id { get; set; }
        public int GetId(int pId)
        {
            pId = Id;
            return Id++;
        }
        public DateTime Date { get; set; }
       
    }
}
