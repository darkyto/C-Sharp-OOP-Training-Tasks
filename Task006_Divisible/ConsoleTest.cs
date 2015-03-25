namespace Task006_Divisible
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ConsoleTest
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int> { 2, 5, 6, 7, 8, 12, 14, 21, 27, 42, 63, 71, 90, 114 };

            Console.WriteLine("Original number sequence :");
            Print(numbers);
            Console.WriteLine("Now we are going to print only numbers divisible by 3 and 7 using LINQ");
            var resultLinq = from number in numbers
                             where number % 3 == 0 && number % 7 == 0
                             select number;
            Print(resultLinq);

            var resultLambda = numbers.Where(x => x % 3 == 0 && x % 7 == 0);
            Console.WriteLine("And the same operationusing LAMBDA");
            Print(resultLambda);
        }
        public static void Print<T>(IEnumerable<T> collection)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var num in collection)
            {
                sb.Append(num + " ");
            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(sb.ToString());
            Console.ResetColor();
        }
    }
}
