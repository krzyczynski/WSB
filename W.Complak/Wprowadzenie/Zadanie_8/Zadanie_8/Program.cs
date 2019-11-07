using System;

namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 8
            //Napisać program sortujący wprowadzane z klawiatury liczby całkowite rosnąco.Program powinien zapytać
            //użytkownika o liczbę elementów do wprowadzenia < 1,10 >, zweryfikować wprowadzoną liczbę, wczytać
            //liczby i wyprowadzić posortowane elementy. Obsłużyć wyjątki.

            int size = 0;
            bool condition = true;
            int secondary;

            Console.WriteLine("Program sortujący liczby do zadania 8.\n");

            //Wczytywanie zakresu tablicy
            while (condition)
            { 
                Console.Write("Wprowadź liczb elementów do posortowania <1 .. 10>: ");
                if ((int.TryParse(Console.ReadLine(), out size) == false) || size < 1 || size > 10) Console.WriteLine("Zła liczba, spróbuj ponownie ...");
                else condition = false;
            }

            int[] array = new int[size];

            //Wczytywanie tablicy
            for (int i = 0; i < size; i++)
            {
                condition = true;
                while (condition)
                {
                    Console.Write("Wprowadź liczbę [{0}]= ", i + 1);
                    if (int.TryParse(Console.ReadLine(), out array[i]) == false) Console.WriteLine("To nie jest liczba, spróbuj poniwnie ...");
                    else condition = false;
                }
            }

            //Sortowanie bąbelkowe
            int n = size;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        secondary = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = secondary;
                    }
                }
                n--;
            } while (n > 1);


            //Wypisywanie posortowanej tablicy
            Console.WriteLine("Wyprowadzanie posortowanych elementów:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Element [{0}]= {1}", i + 1, array[i]);
            }

        }
    }
}
