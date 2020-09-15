using System;

namespace Lecture01 {
    public class PersonPrinter {
        public void PrintFamilyTree(Person root) {
            if (root == null) {
                throw new ArgumentNullException("Roden for printning af familitræet skal være defineret");
            }
            PrintPerson(root);
            if (root.Mor != null) {
                PrintFamilyTree(root.Mor);
            }
            if (root.Far != null) {
                PrintFamilyTree(root.Far);
            }
        }

        public void PrintPerson(Person person) {
            Console.WriteLine($"{person.Fornavn} {person.Efternavn}, {person.Alder}");
        }
    }
}
