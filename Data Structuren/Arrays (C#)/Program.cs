using System;

namespace ArrayIntroduction {
    class Program {
        static void Main(string[] args) {
            string[] alphabet = new string[] { 
                "Alpha",    // Index: 0
                "Beta",     // Index: 1
                "Charlie",  // Index: 2
                "Delta",    // Index: 3
                "Echo"      // Index: 4
            };

            System.Console.WriteLine( alphabet[3] );
            System.Console.WriteLine( alphabet[0] );
        }
    }
}
