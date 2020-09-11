using System;

namespace Lecture01 {
    public static class Calculator {
        public static void SqrtInput() {
            System.Console.Write("Input a number> ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number)) {
                double sqrt = Math.Sqrt(number);
                System.Console.WriteLine($"sqrt({input}) = {sqrt}");
            } else {
                System.Console.WriteLine($"'{input}' i not a number!");
            }
        }
    }
}