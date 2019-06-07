using System;

namespace walka
{
    class Bitwa
    {
        public void Pojedynek(Wojownik PierwszyWojownik, Wojownik DrugiWojownik)
        {
            for (;;)
            {
                if(PierwszyWojownik.ZdrowieWojownika<=0 || DrugiWojownik.ZdrowieWojownika<=0)
                {
                    break;
                }
                PierwszyWojownik.AtakWojownika = PierwszyWojownik.Atak();

                int zadaneObrazenia = PierwszyWojownik.AtakWojownika - DrugiWojownik.Tarcza();

                if (zadaneObrazenia<=0)
                {
                    zadaneObrazenia = 0;
                }
                DrugiWojownik.ZdrowieWojownika -= zadaneObrazenia;

                Console.WriteLine(PierwszyWojownik.NazwaWojownika + " atakuje!");
                Console.WriteLine("Zadane obrażenia: " +zadaneObrazenia);
                Console.WriteLine("Stan zdrowia " + DrugiWojownik.NazwaWojownika + ": " + DrugiWojownik.ZdrowieWojownika);

                if (DrugiWojownik.ZdrowieWojownika <= 0)
                {
                    Console.WriteLine("Wygrywa pierwszy wojownik: " + PierwszyWojownik.NazwaWojownika);
                    break;
                }

                DrugiWojownik.AtakWojownika = DrugiWojownik.Atak();

                zadaneObrazenia = DrugiWojownik.AtakWojownika - PierwszyWojownik.Tarcza();

                if (zadaneObrazenia <= 0)
                {
                    zadaneObrazenia = 0;
                }
                PierwszyWojownik.ZdrowieWojownika -= zadaneObrazenia;

                Console.WriteLine(DrugiWojownik.NazwaWojownika + " atakuje!");
                Console.WriteLine("Zadane obrażenia: " + zadaneObrazenia);
                Console.WriteLine("Stan zdrowia " + PierwszyWojownik.NazwaWojownika + ": " + PierwszyWojownik.ZdrowieWojownika);

                if (PierwszyWojownik.ZdrowieWojownika<=0)
                {
                    Console.WriteLine("Wygrywa drugi z wojowników: " + DrugiWojownik.NazwaWojownika);
                    break;
                }
                
            }
        }
    }
}
