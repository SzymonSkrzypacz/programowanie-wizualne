using System;

namespace walka
{
    class Wojownik : InterfejsDlaWalki
    {
        Random losuj = new Random();

        public int AtakWojownika { get; set; }
        public int ZdrowieWojownika { get; set; }
        public string NazwaWojownika { get; set; }

        public int Atak()
        {
            return losuj.Next(1, 101);
        }

        public int Tarcza()
        {
            return losuj.Next(41);
        }

       public Wojownik(string NazwaWojownika, int ZdrowieWojownika)
        {
            this.NazwaWojownika = NazwaWojownika;
            this.ZdrowieWojownika = ZdrowieWojownika;
            
        }

    }
}
