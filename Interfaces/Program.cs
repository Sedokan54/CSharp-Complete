using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Kaan",
                LastName = "Kaya",
                CustomerId = 01
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Kaan",
                LastName = "Kaya",
                StudentId = 01
            };

            manager.Add(student);
            manager.Add(customer);
        }
    }

    interface IPerson //soyut nesne
    { 
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson // somut nesne // IPerson'da tanimlanmis her seyi eslestirilmis classlarda da gorebiliriz.
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerId { get; set; }


    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public int StudentId { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}
