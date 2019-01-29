using System;

namespace HashTable {
    class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString() {
            return String.Format( "{0} {1} aged {2}", this.FirstName, this.LastName, this.Age );
        }
    }

    class Program {
        static void Main( string[] args ) {
            Person wesley = new Person() {
                FirstName = "Wesley",
                LastName = "van Schaijk",
                Age = 21
            };

            Person jimmy = new Person() {
                FirstName = "Jimmy",
                LastName = "Kijas",
                Age = 18
            };

            HashTable<string, Person> students = new HashTable<string, Person>( 2 );

            students.Insert( "0925379", wesley );
            students.Insert( "0940590", jimmy );

            Console.WriteLine( students.Get( "0925379" ) );

            students.print();
            students.Remove( "0925379" );
            students.print();
        }
    }
}
