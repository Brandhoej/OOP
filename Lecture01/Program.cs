using System;

namespace Lecture01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person andreas = new Person {
                Fornavn = "Andreas",
                Efternavn = "Brandhøj",
                Mor = new Person {
                    Fornavn = "Birgitte",
                    Efternavn = "Brandhøj",
                    Mor = new Person {
                        Fornavn = "Elin",
                        Efternavn = "Brandhøj"
                    },
                    Far = new Person {
                        Fornavn = "Henning",
                        Efternavn = "Brandhøj"
                    }
                },
                Far = new Person {
                    Fornavn = "Lars",
                    Efternavn = "Kjeldgaard",
                    Mor = new Person {
                        Fornavn = "Nanny",
                        Efternavn = "Kjeldgaard"
                    },
                    Far = new Person {
                        Fornavn = "Jørgen",
                        Efternavn = "Kjeldgaard"
                    }
                }
            };*/
            Library library1 = new Library();
            Library library2 = new Library();
            Console.WriteLine(library1 == library2); // → false
            Library library3 = library2;
            Console.WriteLine(library2 == library3); // → true
            library1.PrintFileInfoAtPath(@"/home/andreas/Git/Brandhoej/OOP/Lecture01");
            library1.PrintDirectoryInfosAtPath(@"/home/andreas/Git/Brandhoej/");
        }
    }
}
