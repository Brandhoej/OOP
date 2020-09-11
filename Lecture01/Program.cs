using System;

namespace Lecture01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person andreas = new Person {
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
            };
        }
    }
}
