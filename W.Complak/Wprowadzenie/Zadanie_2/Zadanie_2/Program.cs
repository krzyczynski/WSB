using System;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Wykorzystując zmienne typu double obliczyć wartość wyrażenia wynoszącą:
            a^2+b dla c > 0
            a-b^2 dla c < 0
            1/(a-b) dla c = 0
            Sprawdzić wykonalność obliczenia.*/
            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Program wykonuje instrukcje z zadania 2");
            Console.WriteLine("");




            Console.Write("Podaj a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Podaj c: ");
            double c = double.Parse(Console.ReadLine());

            if (c == 0)
            {
                if (a - b == 0) Console.WriteLine("Próba dzielenia przez 0!");
                else
                {
                    Console.Write("Wartość wyrażenia wynosi: ");
                    Console.Write(1 / a - b);
                }
            }
            else if (c < 0)
            {
                Console.Write("Wartość wyrażenia wynosi: ");
                b *= b;
                Console.Write(a - b);
            }
            else if (c > 0)
            {
                Console.Write("Wartość wyrażenia wynosi: ");
                a *= a;
                Console.Write(a + b);
            }

            Console.ReadKey();




        }
    }
}
