using System;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Choinka");
            Console.Write("Podaj wysokość choinki: ");
            string xIn = Console.ReadLine();
            if(int.TryParse(xIn, out x)==false) Console.WriteLine("Błędne dane wejścia");

            for(int i = 1 ; i<=x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("x");
                }

                Console.WriteLine("");
            }

        }
    }
}
