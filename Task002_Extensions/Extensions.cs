using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task002_Extensions
{

    public static class ExtensionsIEnumerable
    {
        /* Implement a set of extension methods for IEnumerable<T> that implement 
         * the following group functions: sum, product, min, max, average.
         */
        #region extension methods for IEnumerable
        public static decimal SumEnumerable<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable  // the collection can be only of type Convertible and Comparable
        {
            decimal result = 0;

            foreach (var item in collection)
            {
                result += Convert.ToDecimal(item); // as the collection is Convertible we can use ConvertTo
            }

            return result;
        }
        public static decimal ProductRnumerable<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            decimal result = 1;

            foreach (var item in collection)
            {
                result *= Convert.ToDecimal(item);
            }

            return result;
        }
        public static decimal MinIEnumerable<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            decimal min = decimal.MaxValue;

            foreach (var item in collection)
            {
                decimal temp = Convert.ToDecimal(item);
                if (temp < min)
                {
                    min = temp;
                }
            }

            return min;
        }
        public static decimal MaxIEnumerable<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            decimal max = decimal.MinValue;

            foreach (var item in collection)
            {
                decimal temp = Convert.ToDecimal(item);
                if (temp > max)
                {
                    max = temp;
                }
            }

            return max;

        }
        public static decimal AverageIEnumerable<T>(this IEnumerable<T> collection)
            where T : IComparable, IConvertible
        {
            decimal average = 0;

            average = collection.SumEnumerable();

            average = average / collection.Count();

            return average;
        }
        #endregion

    }

}
