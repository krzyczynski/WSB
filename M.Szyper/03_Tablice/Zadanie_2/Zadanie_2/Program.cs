using System;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 2
            //Napisz program rysujący poziomy histogram z gwiazdek ilustrujący rozkład wartości w podanym przez użytkownika
            //ciągu liczb z przedziału 1 – 5. Program powinien najpierw zapytać użytkownika o długość ciągu.

            int numberOfColumn;
           

            Console.WriteLine("Program buduje poziomy histogram wg wzoru z zadanie 2.\n");
            Console.Write("Podaj liczbę kolumn poziomych histogramu: ");
            string numberOfColumnIn = Console.ReadLine();
            if (int.TryParse(numberOfColumnIn, out numberOfColumn) == false) Console.WriteLine("Błąd danych wejścia");
            int[] columnSize = new int[numberOfColumn];

            for (int i=0; i<numberOfColumn; i++)
            {
                if (int.TryParse(Console.ReadLine(), out columnSize[i]) == false) Console.WriteLine("Liczba nie jest całkowita!");
            }

            Console.WriteLine("\nHistagram wygląda następująco: ");

            for (int i = 0; i < numberOfColumn; i++)
            {
                for(int j = 0; j<columnSize[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
