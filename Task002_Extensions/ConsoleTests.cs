using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task002_Extensions
{
    public class ConsoleTests
    {
        static void Main(string[] args)
        {
            IEnumerable<double> myCollection = new List<double> { 4, 6.7, 1, -2 };

            IEnumerable<int> myNewNumbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(); Console.WriteLine("My IEnumerable collection of numbers");
            foreach (var num in myCollection)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("[{0}] ", num);
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("The sum : {0}", myCollection.SumEnumerable());  // should return 9.7
            Console.WriteLine("The product : {0}", myCollection.ProductRnumerable()); // -53.6
            Console.WriteLine("The MIN value in the collection : {0}", myCollection.MinIEnumerable()); // min
            Console.WriteLine("The MAX value in the collection : {0}", myCollection.MaxIEnumerable()); // max
            Console.WriteLine("The AVERAGE in the collection : {0}", myCollection.AverageIEnumerable()); // average

            Console.WriteLine(); Console.WriteLine("My array of numbers");
            foreach (var num in myNewNumbers)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("[{0}] ", num);
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("The average value of this array is {0}", myNewNumbers.AverageIEnumerable()); // average on the array elemnts
        }
    }
}
