using System;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 4 Tablice
            //Napisz program, który wypisze wszystkie liczby pierwsze z przedziału podanego przez użytkownika.Wykorzystaj sito Eratostenesa.

            int size;
            int stopArg;
            int j = 0;


            Console.WriteLine("Program wypisuje liczby pierwsze z zakresu przy pomocy sita Eratostenesa.\n");
            Console.Write("Podaj górny zakres tablicy: ");
            if (int.TryParse(Console.ReadLine(), out size) == false) Console.WriteLine("Błąd danych wejścia");
            stopArg = (int)Math.Floor(Math.Sqrt(size));

            int[] tab = new int[size+1];

            for (int i = 1; i <= size; i++) tab[i] = i;

            for (int i = 2; i <= stopArg; i++)
            {
                if (tab[i] != 0)
                {
                    j += i;
                    while (j <= size)
                    {
                        tab[j] = 0;
                        j += i;
                    }
                }
            }

            Console.WriteLine("Liczby pierwsze z zakresu od 1 do {0}:",size);
            for (int i = 2; i <= size; i++)
            {
                if (tab[i] != 0)
                    Console.Write(i + ", ");
            }
        }
    }
}
