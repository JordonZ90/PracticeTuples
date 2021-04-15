using System;

namespace PracticeTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            AnnonTuple();
            ExplicitTuple();
            NestedTuple();
        }
        public static void AnnonTuple()
        {
            // Tuples hold max eight elements
            // .Rest is reserved for nested tuples typically but can be used to access the 8th element
            var numbers = Tuple.Create("four", 7, 2, "six", 5, "nine", 0, 9);

            Console.WriteLine($"{numbers.Item1}");
            Console.WriteLine($"{numbers.Item2}");
            Console.WriteLine($"{numbers.Item3}");
            Console.WriteLine($"{numbers.Item4}");
            Console.WriteLine($"{numbers.Item5}");
            Console.WriteLine($"{numbers.Item6}");
            Console.WriteLine($"{numbers.Item7}");
            Console.WriteLine($"{numbers.Rest.Item1}");

        }
        public static void ExplicitTuple()
        {
            var namesNumbers = new Tuple<string, int, int, double, string>("victor", 12, 0, 2.2, "charlie");

            Console.WriteLine($"{namesNumbers.Item1}");
            Console.WriteLine($"{namesNumbers.Item2}");
            Console.WriteLine($"{namesNumbers.Item3}");
            Console.WriteLine($"{namesNumbers.Item4}");
            Console.WriteLine($"{namesNumbers.Item5}");
        }
        public static void NestedTuple()
        {
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine($"{numbers.Item1}");
            Console.WriteLine($"{numbers.Item2}");
            Console.WriteLine($"{numbers.Item3}");
            Console.WriteLine($"{numbers.Rest.Item1}"); // 8
            Console.WriteLine($"{numbers.Rest.Item1.Item2}"); // 9
        }
    }
}
