using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Menu
    {
        ArrayList options = new ArrayList()
        {
            {"1. Dodaj nowy tytuł"},
            {"2. Usuń tytuł o podanej nazwie"},
            {"3. Wyświetl tytuły z mojej biblioteki wg autorów"},
            {"4. Wyświetl tytuły z biblioteki wg tytułów"},
            {"5. Wyszukaj tytuł" },
            {"6. Wyszukaj książki autora"},
            {"7. Wyczyść biblioteke"},
            {"8. Wyjdź z programu"},
        }
        ;


        public void showMenu()
        {
            foreach (string item in options)
            {
                Console.WriteLine(item);
            }
        }

    }
}
