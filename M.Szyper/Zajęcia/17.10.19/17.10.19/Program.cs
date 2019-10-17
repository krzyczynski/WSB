using System;

namespace _17._10._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 4;
            int k = 10;
            int[] check;
            check = new int[4];
            int[][] tab;
            tab = new int[4][];

            for(int i=0; i<4; i++)
            {
                tab[i] = new int[j];
                check[i] = j;
                j--;
            }
            for(int i=0; i<4; i++)
            {
                for (j=0; j < check[i]; j++)
                {
                    tab[i][j] = k;
                    k--;
                    Console.WriteLine("tab[{0}][{1}]: {2}",i+1,j+1, tab[i][j]);
                }
            }
        }
    }
}
