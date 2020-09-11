using System;

namespace Lecture01 {
    public static class TrianglePrinter {
        public static void PrintTriangle(int maxSize, char character = '*', bool reversed = false) {
            if (maxSize <= 0) {
                throw new ArgumentException("Maxsize must be greater than zero");
            }

            for (int i = 1; i <= maxSize; i++) {
                System.Console.WriteLine(new string(character, reversed ? maxSize - i : i));
            }
        }
    }
}