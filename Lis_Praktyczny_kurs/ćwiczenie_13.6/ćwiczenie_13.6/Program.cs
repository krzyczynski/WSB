using System;

namespace ćwiczenie_13._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibb =new int [10];
         
            int[][] array = new int[10][];

            for (int i = 0; i < 10; i++)
            {
                if (i == 0) fibb[i] = 1;
                else if (i == 1) fibb[i] = 1;
                else fibb[i] = fibb[i - 1] + fibb[i - 2];

                array[i] = new int[fibb[i]];
            }

            for(int i = 0; i < 10; i++)
            {
                for (int j = fibb[i] - 1; j >= 0; j--)
                {
                    array[i][j] = j + 1;
                    Console.WriteLine("[" + array[i][j] + "]");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
