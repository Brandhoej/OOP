using System;
using System.IO;

namespace Lecture01 {
    public class Library {
        public FileInfo[] GetFileInfosInDirectory(string path) => new DirectoryInfo(path).GetFiles();

        public void PrintFileInfosInDirectory(string path) {
            foreach (FileInfo info in GetFileInfosInDirectory(path)) {
                Console.WriteLine($"{info.Name} :: {info.Length} Bytes");
            }
        }
    }
}