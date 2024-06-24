using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            ProductManager productManager = new ProductManager();
            productManager.Add();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Address = "Block 9";
            customer.Name = "Kaan";
            customer.Id = 01;

            Customer customer2 = new Customer 
            { 
                Id = 2, Name = "Kaan", Address = "Block 9", City = "Ankara"
            };

            Console.WriteLine(customer2.Name);

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added");
        }
        public void Remove()
        {
            Console.WriteLine("Customer Removed");
        }

    }
   
}