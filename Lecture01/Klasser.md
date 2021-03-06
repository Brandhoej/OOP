1. **Herunder har jeg skrevet en simpel klasse Person**
    ```csharp
    class Person{
        string Fornavn;
        string Efternavn;
        int Alder;
    }
    ```

   * **Omskriv de to private instansvariable til offentlige properties med validering. Find selv på valideringskriterie.**
       ```csharp
        public class Person {
            private string _fornavn, _efternavn;
            private int _alder;

        public string Fornavn {
            get => _fornavn;
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("Fornavn kan ikke være null eller udelukkende whitespace");
                }
                _efternavn = value;
            }
        }

        public string Efternavn {
            get => _efternavn;
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("Efternavn kan ikke være null eller udelukkende whitespace");
                }
                _efternavn = value;
            }
        }

        public int Alder {
            get => _alder;
            set {
                if (value < 0) {
                    throw new ArgumentException("Alder kan ikke være mindre end 0");
                }
                _alder = value;
            }
        }
        ```
   * **Tilføj to properties, Far og Mor på denne klasse. Hvilken type vælger du til Far og Mor? – tænk på, din mor og din far har samme egenskaber som dig, og har også forældre.**  
   Jeg vælger typen Person.
       * **Tilføj validering til disse properties.**
            ```csharp
                    public Person Mor {
                        get => _mor;
                        set {
                            if (value == null) {
                                throw new ArgumentNullException("Mor skal være defineret");
                            }
                            _mor = value;
                        }
                    }

                    public Person Far {
                        get => _far;
                        set {
                            if (value == null) {
                                throw new ArgumentNullException("Far skal være defineret");
                            }
                            _far = value;
                        }
                    }
            ```
   * **I din Main, lav en person, med dit navn, dine forældre, og deres forældre.**
        ```csharp
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
        ```
   * **Lav en ny klasse PersonPrinter**
        ```csharp
        public class PersonPrinter {
            public void PrintFamilyTree(Person root) {
                if (root == null) {
                    throw new ArgumentNullException("Roden for printning af familitræet skal være defineret");
                }
                PrintPerson(root);
                if (root.Mor != null) {
                    PrintPerson(root.Mor);
                }
                if (root.Far != null) {
                    PrintPerson(root.Far);
                }
            }

            public void PrintPerson(Person person) {
                Console.WriteLine($"{person.Fornavn} {person.Efternavn}, {person.Alder}");
            }
        }
        ```
       * **Tilføj en metode til at printe en person**
            ```csharp
                public void PrintPerson(Person person) {
                    Console.WriteLine($"{person.Fornavn} {person.Efternavn}, {person.Alder}");
                }
            ```
       * **Tilføj en metode, der printer alle navnene i stamtræet ud.**
            ```csharp
                public void PrintFamilyTree(Person root) {
                    if (root == null) {
                        throw new ArgumentNullException("Roden for printning af familitræet skal være defineret");
                    }
                    PrintPerson(root);
                    if (root.Mor != null) {
                        PrintPerson(root.Mor);
                    }
                    if (root.Far != null) {
                        PrintPerson(root.Far);
                    }
                }
            ```

2. **Tilføj en ekstra constructor til klassen Person fra opgave 1, så man kan vælge at angive forældre når man konstruerer en instans af Person.**
    ```csharp
    public Person(Person mor, Person far) {
        Mor = mor;
        Far = far;
    }
    ```

3. **Tilføj en offentlig property PersonID til klassen Person fra opgave 1. PersonID er et ID der unikt identificerer personer. Brug din viden omkring statiske medlemmer til at implementere PersonID for Person-klassen, så alle instanser af Person har et unikt ID.**  
    Jeg vil bruge en statisk counter, hvor default constructoren forøger den med en. Alle constructor vil så kalde this() for the default.
    ```csharp
    private static int _personCounter = int.MinValue;
    private int _personId;
    public int PersonId { get; }

    public Person() {
        PersonId = _personCounter++;
    }
    ```

4. **Lav et program der, for et bibliotek (folder/mappe) på din computer (f.eks. c:\\)**  
   * **Udskriver alle filers navne og deres størrelser**  
        ```csharp
        public FileInfo[] GetFileInfosInDirectory(string path) => new DirectoryInfo(path).GetFiles();

        public void PrintFileInfosInDirectory(string path) {
            foreach (FileInfo info in GetFileInfosInDirectory(path)) {
                Console.WriteLine($"{info.Name} :: {info.Length} Bytes");
            }
        }
        ```
   * **Udskriver navnene på alle mapper og antal filer og mapper, de indeholderBrug klassen DirectoryInfo. Den ligger i namespacet ```System.IO```. Der findes en tilsvarende FileInfo for filer.**
        ```csharp
        public FileInfo[] GetFileInfosInDirectory(string path) => new DirectoryInfo(path).GetFiles();

        public void PrintFileInfoAtPath(string path) {
            FileInfo[] infos = GetFileInfosAtPath(path);
            Console.WriteLine($"{path}: {infos.Length} files");
            foreach (FileInfo info in infos) {
                Console.WriteLine($"{info.Name} ({info.Length} Bytes)");
            }
        }
        ```
   * **Udskriver navnene på alle mapper og antal filer og mapper, de indeholderBrug klassen ```DirectoryInfo```. Den ligger i namespacet ```System.IO```. Der findes en tilsvarende ```FileInfo``` for filer.**
        ```csharp
        public DirectoryInfo[] GetDirectoryInfosAtPath(string path) => new DirectoryInfo(path).GetDirectories();

        public void PrintDirectoryInfosAtPath(string path) {
            foreach (DirectoryInfo info in GetDirectoryInfosAtPath(path)) {
                Console.WriteLine($"{info.Name}: {info.GetFiles().Length} files");
            }
        }
        ```
5. **I C# sammenligner vi værdier med ==. For de simple typer sammenligner vi værdier:**
   * **1 == 1 giver true**
   * **1 == 2 giver false**
   * **true == true giver true**
   * **true == false giver false**
**Når vi sammenligner referencetyper, er det, måske overraskende, ikke de data der refereres til der sammenlignes, men selve referencen!**
   * **Skriv et lille program der kan bekræfte dette. Lav ny klasse til formålet.**
        ```csharp
        Library library1 = new Library();
        Library library2 = new Library();
        Console.WriteLine(library1 == library2); // → false
        Library library3 = library2;
        Console.WriteLine(library2 == library3); // → true
        ```
6. **Definer en vektortype, om det er 2D eller 3D, er op til dig.**
   * **Implementér metoder for addition og subtraktion**
        ```csharp
        public class Vec2 {
            private double[] coords = new double[2];

            public double X { get => coords[0]; set => coords[0] = value; }

            public double Y { get => coords[1]; set => coords[1] = value; }

            public Vec2(double x, double y) {
                coords[0] = x;
                coords[1] = y;
            }

            public void Add(Vec2 other) {
                X += other.X;
                Y += other.Y;
            }

            public void Subtract(Vec2 other) {
                X -= other.X;
                Y -= other.Y;
            }
        }
        ```
   * **Implementér skalering og evt. andre som f.eks. krydsprodukt.**
        ```csharp
        public void Scalar(double scalar) {
                X *= scalar;
                Y *= scalar;
            }

        public double Dot(Vec2 other) {
                return X * other.X + Y * other.Y;
            }
        }
        ```
   * **Valgte du at mutere dine objekter for vektorfunktionerne?**
      * **Hvis dine vektorer muterer, implementer da en ikkemuterende version(returner altid nye vektorer). Og omvendt.**
        ```csharp
        public static Vec2 operator +(Vec2 a, Vec2 b) {
            return new Vec2(a.X + b.X, a.Y + b.Y);
        }

        public static Vec2 operator -(Vec2 a, Vec2 b) {
            return new Vec2(a.X - b.X, a.Y - b.Y);
        }

        public static Vec2 operator *(Vec2 vec, double scalar) {
            return new Vec2(vec.X * scalar, vec.Y * scalar);
        }
        ```