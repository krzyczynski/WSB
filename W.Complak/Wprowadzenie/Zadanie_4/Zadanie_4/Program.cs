using System;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 4
            //Napisać program obliczania sumy cyfr rozwinięcia dziesiętnego dla zadanej liczby naturalnej.

            int number;
            int count = 0;

            Console.WriteLine("Program oblicza sume cyfr podanej liczby.\n");
            Console.Write("Podaj liczbę: ");
            if (int.TryParse(Console.ReadLine(), out number) == false) Console.WriteLine("błąd danych wejścia");

            while (number != 0)
            {
                count += number % 10;
                number /= 10;
            }

            Console.WriteLine("Suma cyfr rozinięcia dziesiętnego liczby wynosi: " + count);
            

        }
    }
}
