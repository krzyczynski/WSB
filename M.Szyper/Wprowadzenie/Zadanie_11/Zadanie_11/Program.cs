using System;

namespace Zadanie_11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double numberCheck;
            int number;
            Console.Write("Podaj liczbę typu Float: ");
            string numberIn = Console.ReadLine();
            numberCheck = float.Parse(numberIn);
            number = (int)numberCheck;
            
            Console.WriteLine("Liczba bez przecinka: " + number);

        }
    }
}
