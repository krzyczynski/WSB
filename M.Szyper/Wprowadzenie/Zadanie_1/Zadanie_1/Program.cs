using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza pole prostokąta.");
            Console.WriteLine("");

            int test0=0, test1=0;
            float a=0, b=0;

            Console.Write("Podaj bok a: ");
            string str = Console.ReadLine();

            if (float.TryParse(str, out a) == false)
                Console.WriteLine("zły format liczby");
            else
                test0=1;
            
            if (test0 == 1)
            {
                Console.Write("Podaj bok b: ");
                str = Console.ReadLine();

                    if (float.TryParse(str, out b) == false)
                    Console.WriteLine("zły format liczby");
                else
                    test1 = 1;
            }


            if ( (test0 == 1)&&(test1 == 1))
               Console.WriteLine("Pole prostokąta wynosi: " + a * b + " cm/kw");
           
        }
    }
}
