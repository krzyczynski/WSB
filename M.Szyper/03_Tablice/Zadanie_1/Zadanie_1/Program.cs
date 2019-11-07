using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1 Tablice
            //Napisz program, który wczyta 5 liczb podanych przez użytkownika i wypisze je w odwrotnej kolejności.


            const int size = 5;
            string[] tab = new string[size];

            Console.WriteLine("Program wczytuje {0} liczb i wypisuje je od tyłu!\n", size);
            for (int i = 0; i < size; i++)
            {
                Console.Write("Podaj liczbe {0}: ", i+1);
                tab[i] = Console.ReadLine();
            }

            Console.WriteLine("Twoje liczby to: ");
            for (int i = size-1; i>=0; i--)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}
