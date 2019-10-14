using System;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający wartość wyrażenia (a*b)/(a+b), gdzie a i b to parametry podane przez
            //użytkownika.

            int numberA = 0, numberB= 0, numberOut = 0;


            Console.WriteLine("Zadanie 2\n");
            Console.Write("Podaj a: ");
            string numberInA = Console.ReadLine();
            Console.Write("Podaj b: ");
            string numberInB = Console.ReadLine();

            if (int.TryParse(numberInA, out numberA) == false || int.TryParse(numberInB, out numberB) == false) Console.WriteLine("Błędne dane wejścia!");

            numberOut = numberA * numberB;
            numberA += numberB;
            numberOut /= numberA;

            Console.Write("Wynikiem działania jest: "+numberOut);






        }
    }
}
