using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osoby = new List<Osoba>();
            List<Zwierzaki> zwierzaki = new List<Zwierzaki>();

            osoby.Add(new Osoba(1, "Adam", "Abacki", 21, "12345", 'M'));
            osoby.Add(new Osoba(2, "Ewa", "Ebacka", 17, "12346", 'K'));
            osoby.Add(new Osoba(3, "Karol", "Kabacki", 23, "12347", 'M'));
            osoby.Add(new Osoba(4, "Magda", "Mabacka", 25, "12348", 'K'));
            osoby.Add(new Osoba(5, "Karolina", "Kabacka", 25, "12349", 'K'));

            zwierzaki.Add(new Zwierzaki(1, "Alfa", 10));
            zwierzaki.Add(new Zwierzaki(3, "Beta", 3));
            zwierzaki.Add(new Zwierzaki(5, "Gamma", 3));

            var result = from osoba in osoby
                         join zwierzak in zwierzaki on osoba.Id equals zwierzak.Id
                         select new { osoba.imie, osoba.wiek, zwierzak.Imie };
            foreach (var dane in result)
            {
                System.Console.WriteLine(
                    $"{dane.imie}, wiek {dane.wiek} ma zwierzaka: {dane.Imie}"
                    );
            }
            System.Console.ReadKey();
        }
    }
}
