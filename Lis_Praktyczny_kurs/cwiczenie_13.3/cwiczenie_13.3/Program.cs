using System;

namespace _17._10._19
{
	class Program
	{
		static void Main(string[] args)
		{
			int j = 1;
			int k = 10;
			int[][] tab;
			tab = new int[4][];

            //deklarowanie tablicy tablic
			for (int i = 0; i < 4; i++)
			{
				tab[i] = new int[i+1];
			}

            //wypełnianie tablic i wyświetlanie
			for (int i = 0; i < 4; i++)
			{
                for (j = 0; j < i+1; j++)
				{
					tab[i][j] = k--;
					
					Console.Write("["+tab[i][j]+"]\t");
				}
                Console.WriteLine();
			}
		}
	}
}
