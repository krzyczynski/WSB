using System;

namespace _10._10._19
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            float bmi;
            Console.WriteLine("Kalkulator BMI\n");
            Console.Write("Podaj wagę[kg]: ");
            string xIn  = Console.ReadLine();
            Console.Write("Podaj wzrost[cm]: ");
            string yIn = Console.ReadLine();


            if (float.TryParse(xIn, out x)&&float.TryParse(yIn, out y))
            //Obliczenia
            {
                y /= 100;
                y *= y;
                bmi = x / y;

                Console.WriteLine("Twoje BMI wynosi: " + bmi);

                if (bmi <= 18) Console.WriteLine("Masz niedowagę!");
                if (bmi <= 24 && bmi > 18) Console.WriteLine("Waga w normie!");
                if (bmi <= 29 && bmi > 24) Console.WriteLine("Masz nadwagę!");
                if (bmi <= 39 && bmi > 29) Console.WriteLine("Jesteś otyły!");
                if (bmi > 39) Console.WriteLine("Jesteś poważnie otyły!");




            }
            else
            //error
            {
                Console.WriteLine("Złe dane na wejściu");
            }

        }
    }
}
