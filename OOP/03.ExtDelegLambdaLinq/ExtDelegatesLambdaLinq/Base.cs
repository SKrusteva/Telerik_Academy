using System;
using System.Collections.Generic;
using System.Text;

namespace ExtDelegatesLambdaLinq
{
    class Base
    {
        static void Main(string[] args)
        {
            //[test 01]
            StringBuilder testSB = new StringBuilder("some random words...for testing");
            StringBuilder subStr = testSB.Substring(17, 14);
            Console.WriteLine(subStr);

            //[test 02]
            //IEnumerable<int> numbers = new List<int> { 3, 7, 9, 2, 0, 5 };
            //Console.WriteLine("Sum: {0}", numbers.Sum());
            //Console.WriteLine("Product: {0}", numbers.Product());
            //float minValue = numbers.Min(); // fail!!!
            //Console.WriteLine("Min: {0}", minValue);
            //Console.WriteLine("Max: {0}", numbers.Max());
            //Console.WriteLine("Average: {0}", numbers.Average());

            //[test 03]
            var firstLastName = Queries.FirstBeforeLastName(Queries.studentsArray);
            Console.WriteLine("\nList of students whose first name is before the last:");
            foreach (Student name in firstLastName)
            {
                Console.WriteLine(name);
            }
            
            //[test 04]
            var between18and24 = Queries.Between18And24(Queries.studentsArray);
            Console.WriteLine("\nStudents between the age of 18 and 24:");
            foreach (Student name in between18and24)
            {
                Console.WriteLine(name);
            }

            //[test 05.1]
            var byNameLambda = Queries.SortDesc(Queries.studentsArray);
            Console.WriteLine("\nStudents sorted by name (lambda expressions):");
            foreach (Student name in byNameLambda)
            {
                Console.WriteLine(name);
            }

            //[test 05.2]
            var byNameLinq = Queries.DescendingSort(Queries.studentsArray);
            Console.WriteLine("\nStudents sorted by name (LINQ):");
            foreach (Student name in byNameLinq)
            {
                Console.WriteLine(name);
            }
        }
    }
}
