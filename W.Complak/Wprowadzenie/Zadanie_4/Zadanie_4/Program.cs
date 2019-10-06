using System;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napisać program obliczania sumy cyfr rozwinięcia dziesiętnego dla zadanej liczby naturalnej.*/

            int sum = 0;
            int number = 0;
            char x;
           


            Console.WriteLine("Program do zadania 4");
            Console.WriteLine("Program oblicza sumę cyfr rozwinięcia dziesiętnego podanej liczby.");
            Console.WriteLine("");

            Console.Write("Podaj liczbe: ");

            string numberIn = Console.ReadLine();


            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine(numberIn[i]);
                x = numberIn[i];
                number = int.Parse(x) ;
                sum += number;

            }

            Console.WriteLine("Suma cyfr rozwinięcia dziesiętnego wynosi: {0}", sum);

            //NIE DZIAŁA ;-;

            

        }
    }
}
