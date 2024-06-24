using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parametreleri gir");            
            int result = Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(result);

            Console.WriteLine(Add2(2,3,4,5,6));
            Console.ReadLine();

        }

        static int Add(int num1, int num2=20) // default olarak fonksiyonu kullanirken ilk aprametreyi girersek 2. 20 olur ancak 2 tane gireresek girdiklerimiz olur.
        {
            var result = num1 + num2;
            return result;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Multiply(int num1, int num2, int num3)  // Bu isleme de method overloading deniyor. 
        {
            return num1 * num2 * num3;
        }

        static int Add2(params int[] numbers) // Method Overloading kolaylik saglamiyorsa, daha cok overload gerekiyorsa params keywordu kullanilir. Dizi mantiginda
        { 
            return numbers.Sum();
        
        
        }


    }
}

// num = 1 gibi bir parametre belirleyip onu bir fonksiyon icinde degistirip islem yaptirdiktan sonra num degeri yine 1 olarak kalir.
// Ancak hazirladigimiz fonksiyonun icinde num degerinin degismesini istiyorsak 'ref' keywordunu kullanmamiz gerekir.

// out keywordu de ayni ancak num = 1 olarak deger atamamiza gerek yok. int num out'u kullanabilmemiz icin kafi. int num = 1 olmadan da ref olmaz.




//static int IntRead()
//{
//    return Convert.ToInt32(Console.ReadLine()); //Neden calismiyor bu????
//}