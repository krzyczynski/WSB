using System;

namespace Zadanie_1
{
    class Program
    {
        static int Factorial(int i)
        {
            if (i < 1)
                return 1;
            else
                return i * Factorial(i - 1);
        }
        static void Main(string[] args)
        {
            //Zadanie 1 Funkcje
            //1. Napisz program, który wyświetli silnię liczb z przedziału <1-10>. Silnia ma być obliczana przez
            //osobną funkcję. Umieść breakpoint wewnątrz funkcji obliczającej silnię i uruchom program w trybie debug,
            //a następnie obejrzyj zawartość okna Call Stack
            int number = 0;

            Console.WriteLine("Program obliczający silnię do zadania 1\n");

            while (true)
            {
                try
                {
                    Console.Write("Podaj liczbę <1-10> której program ma wyświetlić silnię: ");
                    number = int.Parse(Console.ReadLine());
                    if (number >= 1 && number <= 10) break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Spróbuj jeszcze raz...");
            }

            Console.WriteLine("Silnia = "+Factorial(number)); 
        }
    }
}
