using System;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KREATOR PROSTOKĄTA\n");

            int width = 0, hight = 0;

            Console.Write("Podaj wyosokość: ");
            string hightIn = Console.ReadLine();
            Console.Write("Podaj szerokość: ");
            string widthIn = Console.ReadLine();

            if(int.TryParse(hightIn, out hight) & int.TryParse(widthIn, out width) ==false) Console.WriteLine("Błędne dane wejścia");

            for(int i=1;i<=hight; i++)
            {
                Console.WriteLine(" ");
                for (int j = 1; j <= width; j++)
                {
                    Console.Write("X");
                }
            }
            Console.WriteLine("");


        }
    }
}
