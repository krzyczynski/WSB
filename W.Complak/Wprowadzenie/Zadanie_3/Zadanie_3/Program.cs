using System;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napisać program obliczania największego wspólnego dzielnika dwóch dodatnich liczb całkowity
             ch. Wykorzystać algorytm Euklidesa nie używając operacji dzieleni*/
            Console.WriteLine("Program do zadani 3");
            Console.WriteLine("Program wyznacza NWD");
            Console.WriteLine("");
            Console.Write("Podaj pierwszą liczbę: ");

            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");

            int b1 = int.Parse(Console.ReadLine());

            int a = a1, b = b1, c, d;


            while (true)
            {
                c = a % b;
                a = b;
                b = c;
                if (b == 0) break;
            }



            Console.Write("Największy wspólny dzielnik liczb ({0}, {1}) wynosi: {2} ", a1, b1, a);

            Console.ReadKey();


        }
    }
}
