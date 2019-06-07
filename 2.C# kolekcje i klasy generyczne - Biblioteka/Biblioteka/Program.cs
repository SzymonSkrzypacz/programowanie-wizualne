using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> bookLibrary = new SortedDictionary<string, string>() {
                { "Amerykaana", "Adichie" },
                { "Genialna przyjaciółka", "Ferrante" },
                { "Nieodnaleziona", "Mróz" },
                { "Hasztag", "Mróz" },
                { "Zanim dopadnie nas czas", "Egan" },

        };
            Menu menu = new Menu();
            for (; ; )
            {
                menu.showMenu();
                int choose = Int32.Parse(Console.ReadLine());



                while (!(0 < choose && choose <=8))
                {
                    Console.WriteLine("Podaj liczbę z zakresu 1-8");
                    choose = Int32.Parse(Console.ReadLine());
                }

                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Podaj tytuł i autora po enterze ");

                            string ksiazka = Console.ReadLine();
                            string autor = Console.ReadLine();
                            if (bookLibrary.ContainsKey(ksiazka))
                            {
                                
                                Console.WriteLine("\nKsiążka o takim tytule istnieje już w Twojej bibliotece.\n");
                                
                                
                            }
                            else
                            {
                                bookLibrary.Add(ksiazka,autor);
                                Console.WriteLine("Książka została dodana do biblioteki!");
                                Console.WriteLine(); 
                            }
                            break;
                        }

                    case 2:

                        Console.WriteLine("Podaj tytuł który chcesz usunąć: ");
                        string name = Console.ReadLine();
                        if (bookLibrary.ContainsKey(name))
                        {
                            bookLibrary.Remove(name);
                            Console.WriteLine();
                            Console.WriteLine("Książka " + name + " została usunięta z biblioteki!");
                            Console.WriteLine();
                        }
                        else Console.WriteLine("Brak tytułu o podanej nazwie.");
                        Console.WriteLine();


                        break;

                    case 3:
                        {
                            foreach (KeyValuePair<string, string> book in bookLibrary.OrderBy(key => key.Value))

                            {
                                Console.WriteLine("Tytuł: " + book.Key + ", autor: " + book.Value);
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 4:

                        foreach (KeyValuePair<string, string> book in bookLibrary)
                        {
                            Console.WriteLine("{0}, autor {1}", book.Key, book.Value);
                        }
                        Console.WriteLine();

                        break;

                    case 5:
                        Console.WriteLine("Podaj tytuł który chcesz wyszukać: ");
                        string name1 = Console.ReadLine();
                        if (bookLibrary.ContainsKey(name1))
                        {
                            Console.WriteLine('"' + name1 + '"' + " autor: " + bookLibrary[name1]);
                            Console.WriteLine();
                        }
                        else Console.WriteLine("Brak tytułu o podanej nazwie.");
                        Console.WriteLine();
                        break;

                    case 6:
                        {
                            Console.WriteLine("Podaj autora, aby wyświetlić wszystkie książki, które zostały przez niego napisane. ");
                            string author = Console.ReadLine();

                            if (bookLibrary.ContainsValue(author))
                            {
                                foreach (KeyValuePair<string, string> book in bookLibrary)
                                {
                                    if (book.Value == author)
                                        Console.WriteLine("Tytuł: " + book.Key);
                                }
                            }

                            else
                            {
                                Console.WriteLine("Nie ma takiego autora w bibliotece.");
                            }
                            break;
                        }

                    case 7:
                        bookLibrary.Clear();
                        Console.WriteLine("Twoja biblioteka została wyczyszczona!");
                        Console.WriteLine();
                        break;

                    case 8: return;


                }

            }
        }
    }
}
