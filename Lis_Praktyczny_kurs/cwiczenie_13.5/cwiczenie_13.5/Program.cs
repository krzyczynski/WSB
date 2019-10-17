using System;

namespace cwiczenie_13._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] tab = new int[3,3,3];

            int x = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        tab[i, j, k] = x;
                        x++;
                    }
                }
            }
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("tab: "+tab[i, j, k]); 
                        
                    }
                }
            }
        }
    }
}
