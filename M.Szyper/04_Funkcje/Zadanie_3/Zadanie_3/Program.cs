//Zadanie 3 Funkcje
//Napisz strukturę przedstawiającą dane kontaktowe znajomych (imię, nazwisko, numer telefonu, email). Następnie
//napisz program, który poprosi użytkownika o podanie danych kontaktowych, wypełni nimi strukturę i wypisze podane dane na ekran
//OSTRO ZMODYFIKOWANY
using System;


namespace Zadanie_3
{
    class Program
    {
        static void info()
        {
            MyClear();

            Console.WriteLine("Program jest w stanie przechować 100 kontaktów");
            Console.WriteLine("W przyszłości ilość kontaktów będzie ustawiana dynamicznie");
            Console.WriteLine("W przyszłości program będzie zapisywał dane na dysku");
            Console.WriteLine("Autor Robert Krzyczyński\n");
            Console.Write("Naciśnij dowolny klawisz aby kontynuować...");
            Console.ReadKey();

            MyClear();
        }
        static void MyClear()
        {
            Console.Clear();
            Console.WriteLine("KONTAKTS KIPER by rk\n");
        }
        struct Contact
        {
            public string name;
            public string lastname;
            public string email;
            public string phone;
        }

        static Contact[] contactsArray= new Contact[100];//Wiem, lepiej byłoby na innej kolkcji, np stosie IDGAF

        static int addContact(int index)
        {
            MyClear();

            Console.WriteLine("DODAWANIE KONTAKTU\n");

            Console.Write("Podaj swoje imię: ");
            contactsArray[index].name = Console.ReadLine();

            Console.Write("Podaj swoje nazwisko: ");
            contactsArray[index].lastname = Console.ReadLine();

            Console.Write("Podaj swój adres email: ");
            contactsArray[index].email = Console.ReadLine();

            Console.Write("Podaj swój numer telefonu: ");
            contactsArray[index].phone = Console.ReadLine();

            MyClear();

            index++;
            return index;
        }
        static void showContacts(int range)
        {
            MyClear();

            Console.WriteLine("WYŚWIETLANIE LISTY KONTAKTÓW\n");
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine("Kontakt nr: " + (i + 1));
                Console.WriteLine("-----------------------");
                Console.WriteLine("Imię: " + contactsArray[i].name);
                Console.WriteLine("Nazwisko: " + contactsArray[i].lastname);
                Console.WriteLine("Email: " + contactsArray[i].email);
                Console.WriteLine("Numer telefonu: " + contactsArray[i].phone);
                Console.WriteLine("-----------------------\n");

            }
            Console.Write("Naciśnij dowolny klawisz aby kontynuować...");
                Console.ReadKey();
            MyClear();
        }
        static void Main(string[] args)
        {
            int contactIndex = 0;
            int switchChoice = 3;
            bool condition = true;

            Console.WriteLine("KONTAKTS KIPER by rk\n");

            while (condition)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("MENU\n");
                        Console.WriteLine("1. Dodaj nową osobę");
                        Console.WriteLine("2. Wyswietl istniejace osoby oraz dane kontaktowe\n");
                        Console.WriteLine("3. Informacje dodatkowe");
                        Console.WriteLine("4. Zakończ działanie programu\n");
                        Console.Write("Twój wybór: ");
                        switchChoice = int.Parse(Console.ReadLine());
                        if (switchChoice >= 1 && switchChoice <= 4) break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n"+ex.Message);
                    }
                    Console.WriteLine("Spróbuj jeszcze raz...\n");
                }
                switch (switchChoice)
                {
                    case 1:
                        {
                            contactIndex = addContact(contactIndex);
                            break;
                        }
                    case 2:
                        {
                            showContacts(contactIndex);
                            break;
                        }
                    case 3:
                        {
                            info();
                            break;
                        }
                    case 4:
                        {
                            condition = false;
                            break;
                        }
                }
            }
        }
    }
}
