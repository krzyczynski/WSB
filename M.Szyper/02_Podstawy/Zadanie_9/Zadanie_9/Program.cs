using System;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza czy liczba jest pierwsza\n");

            int number = 0;

            Console.Write("Podaj liczbę: ");
            string numberIn = Console.ReadLine();
            if (int.TryParse(numberIn, out number) == false) Console.WriteLine("Błędne dane wejścia");
            if (number < 2)
                Console.WriteLine("Liczba NIE jest pierwsza!"); //gdy liczba jest mniejsza niż 2 to nie jest pierwszą

            for (int i = 2; i * i <= number; i++)
                if (number % i == 0)
                    Console.WriteLine("Liczna NIE jest pierwsza!"); //gdy znajdziemy dzielnik, to dana liczba nie jest pierwsza
            Console.WriteLine("Liczna jest pierwsza!");

            //NOT WORKING!!!

        }
    }
}
