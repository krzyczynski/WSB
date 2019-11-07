using System;
using System.Threading;


namespace Kalkulator_prosty
{
	class Program
	{
		static void Main(string[] args)
		{
            int x = 0;
            int y = 0;
			bool exitCondition = true;
            int choice = 6;

			while (exitCondition)
			{
                while (true)
                {
                    try
                    {
				        Console.WriteLine("Kalkulator prosty\n");
				       
				        Console.Write("Podaj pierwszą liczbę: ");
                        x = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Liczba jest za duża na możliwości tego programu");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wpisałeś znak który nie jest liczbą");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Wcisnąłeś cntrl z, zamiast wpisać liczbę");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Błąd danych wejścia, nieznany wyjątek");
                    }
                    Console.WriteLine("Spróbuj jeszcze raz...\n\n");
                }

                while (true)
                {
                    try
                    {
                        Console.Write("Podaj drugą liczbę: ");
                        y = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Liczba jest za duża na możliwości tego programu");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wpisałeś znak który nie jest liczbą");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Wcisnąłeś cntrl z, zamiast wpisać liczbę");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Błąd danych wejścia, nieznany wyjątek");
                    }
                    
                    Console.WriteLine("Spróbuj jeszcze raz...\n\n");

                }

                Console.Clear();

				Console.WriteLine("Kalkulator prosty\n");

				Console.WriteLine("MENU");
				Console.WriteLine("1.Dodawanie");
				Console.WriteLine("2.Odejmowanie");
				Console.WriteLine("3.Mnożenie");
				Console.WriteLine("4.Dzielenie");
				Console.WriteLine("5.Reszta z dzielenia");
				Console.WriteLine("6.WYJŚCIE\n");

				Console.Write("Wybierz działanie: ");

                while (true)
                {
                    try
                    {
                        Console.Write("Podaj drugą liczbę: ");
                        choice = int.Parse(Console.ReadLine());
                        if((choice>=1)&&(choice<=6))break;
                        else Console.WriteLine("Nie podałeś liczby z zakresu od 1 do 6");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Liczba jest za duża na możliwości tego programu");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wpisałeś znak który nie jest liczbą");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Wcisnąłeś cntrl z, zamiast wpisać liczbę");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Błąd danych wejścia, nieznany wyjątek");
                    }
                    Console.WriteLine("Spróbuj jeszcze raz...\n\n");

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
						exitCondition = false;
                        Console.WriteLine("KONIEC PROGRAMU");
						break;
				}
                Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
				Console.Clear();
			}
		}
	}
}
