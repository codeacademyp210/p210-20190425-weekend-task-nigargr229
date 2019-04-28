using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.classes
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public static int Id { get; set; }
        public int GetId(int pId)
        {
            pId = Id;
            return Id++;
        }
    }
}
