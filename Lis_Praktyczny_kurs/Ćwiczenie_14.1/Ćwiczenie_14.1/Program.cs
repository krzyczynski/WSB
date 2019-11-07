using System;

namespace Ćwiczenie_14._1
{
    class LiczbaCalkowita
    {
        int number=69;
        public void WyswietlLiczbe()
        {
            Console.WriteLine("Liczba całkowita: "+number);
        }
        public int PobierzLiczbe ()
        {
            return number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LiczbaCalkowita objectOne = new LiczbaCalkowita();
            objectOne.WyswietlLiczbe();

            int number = objectOne.PobierzLiczbe();
            Console.WriteLine("Pobrana liczba: "+number);

        }
    }
}
