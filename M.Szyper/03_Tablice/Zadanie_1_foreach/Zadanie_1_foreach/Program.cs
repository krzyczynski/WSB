using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1 Tablice
            //Napisz program, który wczyta 5 liczb podanych przez użytkownika i wypisze je w odwrotnej kolejności.
            //pętla foreach

            string[] tab = new string[5];
            int i = 0;

            Console.WriteLine("Program wczytuje 5 liczb i wypisuje je od tyłu!\n");
            foreach (string j in tab)
            {
                Console.Write("Podaj liczbe {0}: ", i + 1);
                tab[i] = Console.ReadLine();
                i++;
            }

            Console.WriteLine("Twoje liczby to: ");
            for (int k = 4; k >= 0; k--)
            {
                Console.WriteLine(tab[k]);
            }
        }
    }
}
