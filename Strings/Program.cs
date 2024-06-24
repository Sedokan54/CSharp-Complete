using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Strings aslinda bir char array'idir.
            //Intro();

            string sentence = "Kaandir adim";
            var length = sentence.Length;
            var clone = sentence.Clone(); // yeni bir referans olusturur
            var endwith = sentence.EndsWith("g");
            var startswith = sentence.StartsWith("Kaandir");
            var find = sentence.IndexOf("adim"); // Buldugu ilki sayar devam etmez.
            var findLast = sentence.LastIndexOf("adim"); // Sondan baslar.
            var insert = sentence.Insert(0, "Hello");
            var Subs = sentence.Substring(5,2);
            var lower = sentence.ToLower();
            var upper = sentence.ToUpper();
            var replace = sentence.Replace(" ", "-");
            var remove = sentence.Remove(0, 1);



            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            string city1 = "Istanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city1));
        }
    }
}
