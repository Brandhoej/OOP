using System;
using System.Linq;

namespace Lecture01 {
    public static class GroupMaker {
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

        public static string[] GetGroupNames() {
            Console.Write("Input group names, space seperated> ");
            string input = Console.ReadLine();
            // int.MaxValue is used such that group sizes are not restricted.
            return input.Split(' ', int.MaxValue, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] GetGroupNames(int amount) {
            string[] names = new string[amount];
            Console.WriteLine($"Please input a name and press enter");
            for(int i = 0; i < amount; i++) {
                Console.Write($"{i + 1, 3}> ");
                string name = Console.ReadLine();
                names[i] = name;
            }
            return names;
        }

        public static void PrintGroupNames(string[] names) {
            Console.WriteLine(string.Join(' ', names));
        }
    }
}