using System;
using System.Linq;

namespace ExtDelegatesLambdaLinq
{ // [3],[4],[5]
    static class Queries
    {
        internal static Student[] studentsArray = 
        {
            new Student("Angel", "Borisov", new DateTime(1997, 3, 20)),
            new Student("Angel", "Atanasov", new DateTime(1996, 12, 20)),
            new Student("Vasilena", "Georgieva", new DateTime(1994, 1, 2)),
            new Student("Elena", "Antonova", new DateTime(1993, 5, 31)),
            new Student("Marin", "Kirilov", new DateTime(1992, 9, 22)),
            new Student("Stefan", "Evgeniev", new DateTime(1991, 4, 7)),
            new Student("Nicolae", "Grigorescu", new DateTime(1996, 2, 1)),
            new Student("Demetria", "Panagiotis", new DateTime(1990, 11, 3)),
            new Student("Luka", "Zekic", new DateTime(1989, 6, 28)),
            new Student("Klara", "Markovska", new DateTime(1997, 10, 19))
        };

        public static Student[] FirstBeforeLastName(Student[] list) //[3]
        {
            var firstLastName =
                from person in list
                where string.Compare(person.FirstName, person.LastName) < 0
                select person;

            return firstLastName.ToArray<Student>();
        }

        public static Student[] Between18And24(Student[] list) //[4]
        {
            var from18To24 =
                from person in list
                where ((person.Age() >= 18) && (person.Age() <= 24))
                select person;

            return from18To24.ToArray<Student>();
        }

        public static Student[] SortDesc(Student[] list) //[5.1]
        {
            var Sort = list.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);
            return Sort.ToArray<Student>();
        }

        public static Student[] DescendingSort(Student[] list) //[5.2]
        {
            var Desc =
                from person in list
                orderby person.FirstName descending, person.LastName descending
                select person;

            return Desc.ToArray<Student>();
        }
    }
}