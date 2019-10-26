using System;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfColours;
            
            Console.WriteLine("Program z zajęć.\n");
            Console.Write("Podaj wielkść tablicy: ");
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out numberOfColours) == false) Console.WriteLine("Błąd danych wejścia");
                else break;
            }

            string[] arrayColours = new string[numberOfColours];

            for (int i = 0; i < numberOfColours; i++)
            {
                Console.Write("Podaj {0} kolor: ", i+1);
                arrayColours[i] = Console.ReadLine();
            }
            for (int i = 0; i < numberOfColours; i++)
            {
                Console.WriteLine("Twój {0} ulubiony: {1}", i + 1, arrayColours[i]);
            }

        }
    }
}
