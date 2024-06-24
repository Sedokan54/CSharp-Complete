using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "A";
            students[1] = "B";
            students[2] = "C";

            string[] students2 = {"A", "B","C"};

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[3, 3]
            {
                {"Isatnbul","Sakarya","Edirne"},
                {"Ankara","Konya","Kayseri"},
                {"Antalya","Adana","Mersin"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) 
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**********");
            }      


            Console.ReadLine();
        }
    }
}
