using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1 Tablice
            //Napisz program, który wczyta 5 liczb podanych przez użytkownika i wypisze je w odwrotnej kolejności.

            string[] tab = new string[5];

            Console.WriteLine("Program wczytuje 5 liczb i wypisuje je od tyłu!\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj liczbe {0}: ", i+1);
                tab[i] = Console.ReadLine();
            }

            Console.WriteLine("Twoje liczby to: ");
            for (int i = 4; i>=0; i--)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}
