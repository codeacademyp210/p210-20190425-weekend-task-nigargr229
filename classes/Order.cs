using System;


namespace ConsoleApp5.classes
{
    class Order : Person
    {
        Client Client = new Client();
        Product Product = new Product();
        public int Count { get; set; }
        public int Amount { get; set; }
        public string Position { get; set; }

        
        public static int Id { get; set; }
        public int GetId(int pId)
        {
            pId = Id;
            return Id++;
        }

    }
}
