using System;
using ConsoleApp5.classes;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i-Create employee");
            Console.WriteLine("m-Create customer");
            Console.WriteLine("p-Create product");
            Console.WriteLine("o-Create order");


            string other = Console.ReadLine();
            if (other == "i")
            {
                Employee emp = new Employee();                
                Console.WriteLine("Name :");
                emp.Name = Console.ReadLine();
                Console.WriteLine("Surname :");
                emp.Surname = Console.ReadLine();
                Console.WriteLine("Birthday");
                emp.Birthday = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Card ID :");
                emp.Card_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Position :");
                emp.Position = Console.ReadLine();
                Console.WriteLine("Salary : ");
                emp.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} - Worker created - {1} {2}", Employee.Id, emp.Name, emp.Surname);
                Console.ReadLine();

            }
            if (other == "m")
            {
                Client client = new Client();             
                Console.WriteLine("Name :");
                client.Name = Console.ReadLine();
                Console.WriteLine("Surname :");
                client.Surname = Console.ReadLine();
                Console.WriteLine("Birthday:");
                client.Date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Card ID :");
                client.Client_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Client ID :");
                client.Client_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Address :");
                client.Address = Console.ReadLine();
                Console.WriteLine("Telephone number :");
                client.Phone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} - Client created - {1} {2}", Client.Id, client.Name, client.Surname);
                Console.ReadLine();

            }
            if (other == "p")
            {
                Product Product = new Product();
                Console.WriteLine("Name :");
                Product.Name = Console.ReadLine();
                Console.WriteLine("Color:");
                Product.Color = Console.ReadLine();
                Console.WriteLine("Price :");
                Product.Price = Convert.ToInt32(Console.ReadLine());                
                Console.WriteLine("{0} - Product created : {1} {2} {3}$", Product.Id, Product.Name, Product.Color, Product.Price);
                Console.ReadLine();
            }
            if (other == "o")
            {
                Console.WriteLine("Order created");
                Order order = new Order();
                Console.WriteLine("Count :");
                order.Count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Amount :");
                order.Count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} - Count:{1}. General amount to be paid :{2}",Order.Id,order.Count,order.Amount);
                Console.ReadLine();
               
            }
        }
    }
}
