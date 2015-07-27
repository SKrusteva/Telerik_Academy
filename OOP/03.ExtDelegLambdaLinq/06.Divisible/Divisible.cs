using System;
using System.Linq;

namespace ExtDelegatesLambdaLinq
{
    /* 06. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
     * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/

    class Divisible
    {
        public static int[] DivBy7And3(int[] numbers) // lambda
        {
            var div = numbers.Where(x => x % 3 == 0 && x % 7 == 0);
            return div.ToArray<int>();
        }

        public static int[] DivBy7And3Query(int[] numbers)  //linq
        {
            var div = 
                from number in numbers
                where (number % 3 == 0) && (number % 7 == 0)
                select number;
            return div.ToArray<int>();
        }

        static void Main()
        {
            int[] numbers = { -45, 4, 3, 7, 21, 42, 126, 70 };
            int[] lambda = DivBy7And3(numbers);
            Console.WriteLine("Lambda expression: {0}", string.Join<int>(" ", lambda));
            int[] lnq = DivBy7And3Query(numbers);
            Console.WriteLine("LINQ: {0}", string.Join<int>(" ", lnq));
        }
    }
}
