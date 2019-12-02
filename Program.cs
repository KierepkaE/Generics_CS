using System;

namespace generics {

    class Program {
        static void Main (string[] args) {
            // Lambda
            // number => number * number

            Func<int, int> square = Square;
        }
    }
}