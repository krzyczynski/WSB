using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Obliczyć wartość wyrażenia: (a^2+b)/((a+b)^2)
             dla zmiennych a i b typu float wczytywanych z klawiatury. Sprawdzić wykonalność obliczenia.
             */
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Program oblicza działanie zamieszczone w zadaniu 1.");
            Console.WriteLine("");

            Console.Write("Podaj a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            float b = float.Parse(Console.ReadLine());

            float m, n;

            m = a * a;
            m += b;
            n = a + b;
            n += n;

            if (n == 0) Console.WriteLine("W mianowniku jest zero!");
            else
            {
                Console.Write("Wynik to: ");
                Console.Write(m /= n);

            }

            Console.ReadKey();
        }
    }
}
