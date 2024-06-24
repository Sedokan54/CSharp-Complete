using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] 
            {
                new Customer{Id = 0}, new Student{Id = 1}, new Person{Id = 100} 
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.Id);
            }

            Console.ReadLine();
        }

        class Person // Interface'lerde tek basina bi anlam ifade etmezken inheritance'da eder.
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public int CustomerId { get; set; }
        }

        class Student : Person
        {
            public int StudentIs { get; set; }
        }
    }
}
