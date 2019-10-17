using System;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Choinka v2");
            Console.Write("Podaj wysokość choinki: ");
            string xIn = Console.ReadLine();
            if (int.TryParse(xIn, out x) == false) Console.WriteLine("Błędne dane wejścia");

            int w = x;
            for (int i = 1; i <= x; i++)
            {

                for (int k = w; k >1; k--)
                {
                    Console.Write(" ");
                    
                    
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    
                }
                for (int d = 1; d <= i; d++)
                {
                    if(d!=1)Console.Write("*");

                }
                w--;
                Console.WriteLine("");
            }

        }
    }
}