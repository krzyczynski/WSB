using System;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Zadanie 5
            //Napisać program badania czy zadana liczba jest liczbą pierwszą. Zminimalizować liczbę operacji dzielenia.

            Console.WriteLine("Program sprawdza, czy liczba jest pierwsza.\n");

                int number;
                int numberCheck = 2;
                int exit = 0;

                Console.Write("Podaj liczbę: ");
                string numberIn = Console.ReadLine();
                if (int.TryParse(numberIn, out number) == false) Console.WriteLine("Błąd danych wejścia!");

                while (exit == 0)
                {
                    if(number < 2) { Console.WriteLine("Liczba NIE jest pierwsza."); exit++; }
                    else if (number == numberCheck) { Console.WriteLine("Liczba jest pierwsza."); exit++; }
                    else if (number % numberCheck == 0) { Console.WriteLine("Liczba NIE jest pierwsza."); exit++; }
                    else numberCheck++;
                }

        }
    }
}
