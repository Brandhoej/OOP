1. **Typer. Find, og forklar, fejlene i nedenstående: (du kan evt. få VS til at fortælle dig hvad fejlen er!). Det er vigtigt du forstår hvorfor nedenstående giver fejl.**  
 * char a = "a";  
   Forkert fordi deklarationen af en char-type skal bruge 'a'.  
 * bool b = 0;  
   I modsætning til C så er bool ikke int-typen. Det er true/false literals.  
 * int c = 8.0;  
   int er heltal og derfor kan man ikke sætte decimaler på. Ligemeget om det er ".0".
 * decimal d = 6.7;  
   Når et tal med decimaler bliver sat uden brug af et suffix så antages det at være en double. decimal-typen skal bruge usffix M/m. Store bogstaver er anbefalet som konvention.  
 * string e = "Har du set "Holger"?";  
   De " som er inde i strengen skal escapes med \\.  

2. **Skriv to metoder. En der konverterer fra radian til grader, og en, der konverterer den anden vej. Vi vælger her, at output fra disse metoder altid ligger imellem 0 og 359.99+ grader og mellem 0 and 2 × π radian. Vi observerer nemlig, at på en cirkel, er 2 π radian er det samme som 0, og 360 grader er det samme som 0 grader.**  
   * radians = degrees * (pi/180)  
        ```csharp
        public static double DegreesToRadians(double degrees) => degrees * (Math.PI / 180.0);
        ```  
   * degrees = radians * (180/pi)  
        ```csharp
        public static double RadiansToDegrees(double radians) => radians * (180.0 / Math.PI);
        ```

3. **Skriv en metode, der tager et heltal som argument, og printer følgende: (her kaldt med 5) \* \*\* \*\*\* \*\*\*\* \*\*\*\*\***
    ```csharp
    public static void PrintTriangle(int maxSize, char character = '*') {
        if (maxSize <= 0) {
            throw new ArgumentException("Maxsize must be greater than zero");
        }

        for (int i = 1; i <= maxSize; i++) {
            System.Console.WriteLine(new string(character, i));
        }
    }
    ```

4. **Lav metoden der skriver det ud i omvendt rækkefølge, f.eks. fra 5 og ned til 1 stjerne.**
    ```diff
    -public static void PrintTriangle(int maxSize, char character = '*') {
    +public static void PrintTriangle(int maxSize, char character = '*', bool reversed = false) {
        if (maxSize <= 0) {
            throw new ArgumentException("Maxsize must be greater than zero");
        }

        for (int i = 1; i <= maxSize; i++) {
    -       System.Console.WriteLine(new string(character, i));
    +       System.Console.WriteLine(new string(character, reversed ? maxSize - i : i));
        }
    }
    ```

5. **Math er en klasse, der indeholder en masse metoder og konstanter til matematiske beregninger. Det er en speciel klasse, der ikke skal instantieres, lidt ligesom System.Console, som indeholder metoder til at styre terminalen. Her under ser du én måde at lave strenge om til tal:**
    ```csharp
    string input = Console.ReadLine();
    int tal = int.Parse(input);
    ```
    * **Spørg brugeren om et tal, og beregn, via. en af System.Math’s metoder, kvadratroden af dette tal (hint: sqrt)**  
      ```csharp
      public static void SqrtInput() {
          Console.Write("Input a number> ");
          string input = Console.ReadLine();
          if (double.TryParse(input, out double number)) {
              double sqrt = Math.Sqrt(number);
              Console.WriteLine($"sqrt({input}) = {sqrt}");
          } else {
              Console.WriteLine($"'{input}' i not a number!");
          }
      }
      ```
   * **Prøv at skrive noget andet end et tal, når programmet forventer et tal. Dette er C#s fejlmekanisme, det dækkes senere i kurset.**  
   Jeg har ikke dette problem med min implementation. Jeg havde lige overset at man kun skulle bruge Parse...
6. **Skriv et program der gør følgende:**
   * Spørger om antallet af medlemmer i din gruppe.  
        ```csharp
            public static int GetGroupSize() {
                Console.Write("Input group size> ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int size)) {
                    if (size <= 0) {
                        Console.WriteLine("Group size must be greater than 0");
                    }
                } else {
                    Console.WriteLine($"{input} is not an integer");
                }
                return size;
            }
        ```
   * Beder om navn på hvert medlem af din gruppe. Efter hvert navn, trykkes enter.  
        ```csharp
            public static string[] GetGroupNames(int amount) {
                string[] names = new string[amount];
                Console.WriteLine($"Please input a name and press enter");
                for(int i = 0; i < amount; i++) {
                    Console.Write($"{i, 3}> ");
                    string name = Console.ReadLine();
                    names[i] = name;
                }
                return names;
            }
        ```
   * Når alle medlemmers navne er blevet indtastet, skal alle navnene skrives ud til skærmen.  
        ```csharp
            public static void PrintGroupNames(string[] names) {
                Console.WriteLine(string.Join(' ', names));
            }
        ```
   * Lav nu samme program, bare uden punkt-a, indtastningen af antal medlemmer. Når der ikke er flere gruppemedlemmer, trykkes der bare enter.  
        ```csharp
            public static string[] GetGroupNames() {
                Console.Write("Input group names, space seperated> ");
                string input = Console.ReadLine();
                return input.Split(' ', int.MaxValue, StringSplitOptions.RemoveEmptyEntries);
            }
        ```

