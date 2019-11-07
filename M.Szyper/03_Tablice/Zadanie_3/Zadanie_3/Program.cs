using System;

namespace Zadanie_3
{
    class Program
    {
        public static void Swap(int[] ar, int first)//Zamiana miejscami
        {
            int hold = ar[first];
            ar[first] = ar[first + 1];
            ar[first + 1] = hold;
        }

        public static void BubbleSort(int[] ar) //bubblesort ;v
        {
            for (int i = 0; i < ar.Length-1; i++)
                for (int j = 0; j < ar.Length - 1; j++)
                    if (ar[j] > ar[j + 1])
                        Swap(ar, j);
        }
        static void Main(string[] args)
        {
            //Zadanie 3 Tablice
            //Napisz program, który posortuje podany przez użytkownika ciąg liczb. Program powinien najpierw zapytać
            //użytkownika o długość ciągu. Wykorzystaj algorytm sortowania bąbelkowego.

            int numberOfNumbersToSort;
            

            Console.WriteLine("Program sortuje(bąbelkowo) liczby podane przez użytkownika.\n");

            Console.Write("Podaj liczbę liczb do posortowania: ");

            while (int.TryParse(Console.ReadLine(), out numberOfNumbersToSort)==false) { Console.WriteLine("Błąd danych, spróbuj ponownie..."); }
            //do
            //{
            //    try
            //    {

            //        numberOfNumbersToSort = int.Parse(Console.ReadLine());
            //        x = false;
            //    }
            //    catch (OverflowException e)
            //    {
            //        Console.WriteLine("Przepełniona zmienna");
            //        //Console.WriteLine(e.Message);
            //        x = true;

            //    }
            //} while (x);
        

            int[] numberToSort = new int[numberOfNumbersToSort];

            for (int i= 0 ; i<numberOfNumbersToSort; i++)
            {
                Console.Write("Podaj {0} liczbę: ", i + 1);
                if (int.TryParse(Console.ReadLine(), out numberToSort[i]) == false) Console.WriteLine("Błąd danych wejścia");
            }

            BubbleSort(numberToSort);


            Console.Write("Liczby posortowane: ");
            for (int i = 0; i < numberOfNumbersToSort; i++)
            {
                Console.Write(numberToSort[i]+"; ");
               
            }

        }
    }
}




