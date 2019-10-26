using System;

namespace Tablice_wielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie dodatkowe z użyciem pętli Foreach
            //Wykonał Robert Krzyczyński

            const int arrayX = 3;
            const int arrayY = 3;



            int[,] array = new int[arrayX, arrayY];



            for (int i = 0; i < array.GetLength(0); i++) //wypełnianie tablicy
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i * 3 + j;
                }
            }

            int k = 0;
            foreach (int value in array) //Wypisywanie foreach
            {
                if (k != 0 && k % array.GetLength(1) == 0) Console.WriteLine();
                Console.Write(value + "\t");
                k++;
            }
        }
    }
}
