using System;
using System.IO;

namespace Lecture01 {
    public class Library {
        public FileInfo[] GetFileInfosAtPath(string path) => new DirectoryInfo(path).GetFiles();

        public DirectoryInfo[] GetDirectoryInfosAtPath(string path) => new DirectoryInfo(path).GetDirectories();

        public void PrintFileInfoAtPath(string path) {
            FileInfo[] infos = GetFileInfosAtPath(path);
            Console.WriteLine($"{path}: {infos.Length} files");
            foreach (FileInfo info in infos) {
                Console.WriteLine($"{info.Name} ({info.Length} Bytes)");
            }
        }

        public void PrintDirectoryInfosAtPath(string path) {
            foreach (DirectoryInfo info in GetDirectoryInfosAtPath(path)) {
                Console.WriteLine($"{info.Name}: {info.GetFiles().Length} files");
            }
        }
    }
}