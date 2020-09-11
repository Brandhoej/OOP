using System;

namespace Lecture01 {
    public class Person {
        private static int _personCounter = int.MinValue;
        private string _fornavn, _efternavn;
        private int _alder, _personId;
        private Person _mor, _far;

        public int PersonId { get; }

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

        public Person() {
            PersonId = _personCounter++;
        }

        public Person(Person mor, Person far)
            : this() {
            Mor = mor;
            Far = far;
        }
    }
}