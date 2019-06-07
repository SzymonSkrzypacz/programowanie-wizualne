using System;

namespace walka
{
    class Menu
    {
       public Menu()
        {
            Wojownik PierwszyWojownik = new Wojownik("Leonidas I", 150);
            Wojownik DrugiWojownik = new Wojownik("Aleksander Wielki", 150);
            Start(PierwszyWojownik,DrugiWojownik);
        }
        public void Akcja()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Nazwa pierwszego wojownika;");
            Console.WriteLine("2 - Nazwa drugiego wojownika;");
            Console.WriteLine("3 - Max zdrowie pierwszego;");
            Console.WriteLine("4 - Max zdrowie drugiego;");
            Console.WriteLine("5 - Rozpocznij pojedynek;");
            Console.WriteLine("6 - Koniec;");
        }

        public void MaxZdrowieWojownika(Wojownik wojownik)
        {
            Console.Write("Podaj zdrowie wojownika: ");
            int zdrowie = int.Parse(Console.ReadLine());
            wojownik.ZdrowieWojownika = zdrowie;
        }

        public void Nazwa(Wojownik wojownik)
        {
            Console.Write("Podaj imię wojownika: ");
            string imie = Console.ReadLine();
            wojownik.NazwaWojownika = imie;
        }

        public void StartBitwy(Wojownik PierwszyWojownik, Wojownik DrugiWojownik)
        {
            Bitwa bitwa = new Bitwa();
            bitwa.Pojedynek(PierwszyWojownik, DrugiWojownik);
        }

        public void Start(Wojownik PierwszyWojownik, Wojownik DrugiWojownik)
        {
            int akcja;
            do
            {
                Akcja();
                akcja = int.Parse(Console.ReadLine());

                switch(akcja)
                {
                    case 1:
                        {
                            Nazwa(PierwszyWojownik);
                            break; }
                    case 2:
                        {
                            Nazwa(DrugiWojownik);
                            break;
                        }
                    case 3:
                        {
                            MaxZdrowieWojownika(PierwszyWojownik);
                            break;
                        }
                    case 4:
                        {
                            MaxZdrowieWojownika(DrugiWojownik);
                            break;
                        }
                    case 5:
                        {
                            StartBitwy(PierwszyWojownik, DrugiWojownik);
                            break;
                        }
                    default:
                        { break; }
                }
            } while (akcja >= 1 && akcja <= 5);
        }
    }
}
