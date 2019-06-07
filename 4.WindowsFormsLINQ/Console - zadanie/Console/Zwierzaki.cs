using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Zwierzaki
    {
        public int Id { get; private set; }
        public String Imie { get; private set; }
        public int wiek { get; private set; }


        public Zwierzaki(int Id, String imie, int wiek)
        {
            this.Id = Id;
            this.Imie = imie;
            this.wiek = wiek;
        }
    }
}
