using System;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 7
            //Dla macierzy kwadratowej wprowadzanej z klawiatury wierszami zbadać, czy suma elementów powyżej
            //głównej przekątnej jest większa od sumy elementów poniżej tej przekątnej.

            int degree;
            int bot=0;
            int top=0;
            string result = "";

            Console.WriteLine("Program do zadania 7, na macierzy kwadratowej.\n");

            //Wczytywanie stopnia macierzy
            Console.Write("Podaj stopień macierzy: ");
            if (int.TryParse(Console.ReadLine(), out degree) == false) Console.WriteLine("Błąd danych wejścia!");

            int[,] matrix = new int[degree, degree];

            //Wczytywanie liczb do macierzy i główna funkcja
            for (int i = 0; i < degree; i++) 
            {
                for (int j = 0; j < degree; j++)
                {
                    Console.Write("Podaj element [{0},{1}]: ",i+1,j+1);
                    if (int.TryParse(Console.ReadLine(), out matrix[i,j]) == false) Console.WriteLine("Błąd danych wejścia!");
                    if (j > i) top += matrix[i, j];
                    else if (j < i) bot += matrix[i, j];
                }
            }

            //Podumowanie
            if (bot > top) result = " nie";
            Console.WriteLine("Suma elementów powyżej głównej przekątnej (= {0}){1} jest większa od sumy elemntów poniżej głównej przekątnej (= {2}).", top, result, bot);

            //Pomocnicze wyświetlanie danych
            //for (int i = 0; i < degree; i++)
            //{
            //    for (int j = 0; j < degree; j++)
            //    {
            //        Console.Write(matrix[i,j]+" ");
                   
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("bot: "+ bot);
            //Console.WriteLine("top: "+ top);

        }
    }
}
