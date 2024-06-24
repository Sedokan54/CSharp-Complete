using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1234567890; //32 bit
            long number2 = 1234567890123456789; //64 bit
            short number3 = 12345; //16 bit
            byte number4 = 255; //8 bit
            bool bool1 = true;
            char char1 = 'a';
            double double1 = 12.1;
            decimal decimal1 = 12.1m; //
            var number7 = 1;
            number7 = 'A'; // int olarak kaydetti var.

            if (Days.Friday == Days.Monday)
            {
                // gibi kullanilir.
            }


            Console.WriteLine("N1 AND N2 ARE {0} {1}",number1,number2);
            Console.WriteLine((int)Days.Wednesday);
            Console.WriteLine(number7);
            Console.ReadLine();
        }

        enum Days
        {
            Monday =1 , Tuesday, Wednesday, Thursday, Friday
        }
    }
}
