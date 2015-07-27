using System.Collections.Generic;
using System.Linq;

namespace ExtDelegatesLambdaLinq
{
    /* 02. Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
     * sum, product, min, max, average. */

    public static class IEnumerableExtension
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            T sum = (dynamic)0;
            foreach (dynamic item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            T product = (dynamic)1;
            foreach (dynamic item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Min(); //stackoverflow?
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            return collection.Max(); //stackoverflow?
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            T average = (dynamic)collection.Sum() / collection.Count();
            return average;
        }
    }
}