using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1. Napisz program sprawdzający, czy podana liczba jest parzysta czy nie.

            int number;

            Console.WriteLine("Program sprawdza czy liczba jest parzysta!\n");
            Console.Write("Podaj liczbę: ");
            string numberIn = Console.ReadLine();
            if (int.TryParse(numberIn, out number) == false) Console.WriteLine("Błędne dane wjeścia!");

            if(number%2==0) Console.WriteLine("Liczba jest parzysta!");
            else Console.WriteLine("Liczba NIE jest parzysta!");
            

        }
    }
}
