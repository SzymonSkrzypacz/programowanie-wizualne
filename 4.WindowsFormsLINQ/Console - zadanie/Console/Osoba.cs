using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Osoba
    {
        public int Id { get; private set; }
        public String imie { get; private set; }
        public String nazwisko { get; private set; }
        public int wiek { get; private set; }
        public String nr_telefonu { get; private set; }
        public char plec { get; private set; }


        public Osoba(int Id, String imie, String nazwisko, int wiek, String nr_telefonu, char plec)
        {
            this.Id = Id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.nr_telefonu = nr_telefonu;
            this.plec = plec;
        }
    }
}
