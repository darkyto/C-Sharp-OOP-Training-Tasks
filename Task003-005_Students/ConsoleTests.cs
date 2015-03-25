namespace Task003_005_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ConsoleTests
    {
        static void Main(string[] args)
        {
            #region Task 3 TESTS for Console
            //Student testStudent = new Student("Georg" , "Washington" , 25); // consturctor with age added
            List<Student> students = new List<Student>
            {
                new Student("Divided", "Zero" , 34),
                new Student("Maria" , "Versache" , 19),
                new Student("Maria" , "Paganini" , 25),
                new Student("Maria" , "Albenova" , 19),
                new Student("Paun" , "Paunev" , 25),
                new Student("Durto" , "Bonev" , 21),
                new Student("Gele" , "Karagolemanov" , 24),
                new Student("Luchia" , "DeMaria" , 27),
                new Student("John" , "Smith" , 22),
            };

            var sortedByFirstName = students
                .OrderByDescending(x => x.Firstname)
                .ThenBy(y => y.LastName);
            Line(50);
            Console.Write(new string('=', 20)); Console.Write(" TEST TASK 3 "); Line(17);
            Console.WriteLine("by First name and then by Second name DESCENDING");
            Line(50);
            Print(sortedByFirstName);
            Line(50); Console.WriteLine(); Console.WriteLine();

            var sortedByFirstSecondName =
                from student in students
                where student.Firstname.CompareTo(student.LastName) < 0
                select student;
            Line(50);
            Console.WriteLine("SECOND Scenario : First Name before Last name ONLY");
            Line(50);
            Print(sortedByFirstSecondName);
            Line(50); Console.WriteLine(); Console.WriteLine();


            var orderStudents = from student in students
                                orderby student.Firstname ascending, student.LastName ascending
                                select student;
            Line(50);
            Console.WriteLine("by First name and then by Second name ASCENDING");
            Line(50);
            Print(orderStudents);

            Console.Write(new string('=', 20)); Console.Write("  END TASK 3 "); Line(17);
            Line(50);

            Console.WriteLine(); Console.WriteLine();
            #endregion

            #region Task 4 TESTS for Console

            Line(50);
            Console.Write(new string('=', 20)); Console.Write(" TEST TASK 4 "); Line(17);

            var filteredByAge = from student in students
                                where student.Age > 17 && student.Age < 25       
                                orderby student.Age descending
                                select student;
            PrintAge(filteredByAge);

            var newFilerAge = students.Where(x => x.Age > 17 && x.Age < 25).OrderBy(x => x.Age); // another working way with some LINQ 
            Line(50);
            #endregion

            #region Task 5 TEST for Console
            Line(50);
            Console.Write(new string('=', 20)); Console.Write(" TEST TASK 5 "); Line(17);

            var orderDescending = from student in students
                                  orderby student.LastName descending
                                  orderby student.Firstname descending
                                  select student;

            Console.WriteLine("Descending order (First name then Last name) LINQ");
            Print(orderDescending);

            var orderDescendingLambda = students
                                     .OrderByDescending(x => x.Firstname)
                                     .ThenByDescending(x => x.LastName);
            Console.WriteLine("Descending order (First name then Last name) LAMBDA");
            Print(orderDescendingLambda);

            Console.Write(new string('=', 20)); Console.Write("  END TASK 5 "); Line(17);
            Line(50);
                                          //  orderby student.LastName descending 
                               // orderby student.Firstname descending
            #endregion
        }
        public static void Line(int count)
        {
            Console.WriteLine(new string('=', count));
        }
        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public static void PrintAge(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToStringAge());
            }
        }
    }
}
