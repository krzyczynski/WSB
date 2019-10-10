using System;
using System.Threading;


namespace Kalkulator_prosty
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0, y = 0;
            int exitCondition = 0;
            while (exitCondition == 0)
            {
                Console.WriteLine("Kalkulator prosty\n");
                Console.Write("Podaj pierwszą liczbę: ");
                string firstNumber = Console.ReadLine();
                Console.Write("Podaj pierwszą liczbę: ");
                string secondNumber = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Kalkulator prosty\n");

                if (float.TryParse(firstNumber, out x) && float.TryParse(secondNumber, out y))
                {
                    Console.WriteLine("Twoje liczby to {0} i {1} \n", x, y);
                }
                else
                {
                    Console.WriteLine("Błędne dane na wejściu"); //DODAĆ FUNKCJĘ EXIT

                }
                Console.WriteLine("MENU");
                Console.WriteLine("1.Dodawanie");
                Console.WriteLine("2.Odejmowanie");
                Console.WriteLine("3.Mnożenie");
                Console.WriteLine("4.Dzielenie");
                Console.WriteLine("5.Reszta z dzielenia");
                Console.WriteLine("6.WYJŚCIE\n");

                Console.Write("Wybierz działanie: ");

                string choiceIn = Console.ReadLine();
                int choice;

                if (int.TryParse(choiceIn, out choice) == false)
                {
                    Console.WriteLine("Błędne dane na wejściu"); //DODAĆ FUNKCJĘ EXIT
                }

                switch (choice)
                {
                    case 1:
                        x += y;
                        Console.WriteLine("\n Wynik dodawania: " + x);

                        break;
                    case 2:
                        x -= y;
                        Console.WriteLine("\n Wynik odejmowania: " + x);

                        break;
                    case 3:
                        x *= y;
                        Console.WriteLine("\n Wynik mnożenia: " + x);

                        break;
                    case 4:
                        x /= y;
                        Console.WriteLine("\n Wynik dzielenia: " + x);

                        break;
                    case 5:
                        x %= y;
                        Console.WriteLine("\n Wynik reszty z dzielenia: " + x);
                        break;
                    case 6:
                        exitCondition = 1;
                        break;
                    default:
                        Console.WriteLine("\n Błędny numer działaniaw menu!");
                        break;
                }
                Thread.Sleep(1500);
                Console.Clear();
            }













        }
    }
}
