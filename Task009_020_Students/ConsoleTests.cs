namespace Task009_020_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ConsoleTests
    {
        static void Main(string[] args)
        {
            Line(50);
            List<Student> sampleStudents = new List<Student>
            { 
                new Student("Gosho" , "Ivanov", "124506","00129998888","testMails@gmail.com",new List<double> {3 , 5 ,6 ,4 ,6 ,6}, 5),
                new Student("Maria" , "Petrova","124506","029998888","testMails@gmail.com",  new List<double> {5 , 5 ,2 ,4 ,2 ,4}, 2),
                new Student("Stamatka" , "Liov","124506","0299987777","testMails@gmail.com", new List<double> {3 , 5 ,5 },         3),
                new Student("Gabriel" , "Peiov","124506","0266666666","testMails@abv.bg",    new List<double> {3 , 2 ,2 ,2 ,6 ,6}, 5),
                new Student("Sasha" , "Masheva","124507","7589998888","testMails@abv.bg",    new List<double> {4  ,4 ,2 ,5 ,2},    8),
                new Student("Asparuh" , "Dimov","124516","3599998888","testMails@yahoo.com", new List<double> {6 ,4 ,4},           5)
            };
            Console.WriteLine("This is the unsorted grup of students"); Line(50);
            Print(sampleStudents); Console.WriteLine(); Line(50);

            var sortedByGroup = sampleStudents.Where(x => x.Group == 2).OrderBy(x => x.FirstName);
            Console.WriteLine("NOW this is the Filtered and Sorted group"); Line(50);
            Print(sortedByGroup); Console.WriteLine(); Line(50);

            //task 10
            Console.WriteLine("Now the same funcitonaality using Extension method"); Line(50);
            var orderExtensions = sampleStudents.GroupOrder(); // calling the extension methods from Extensions.cs
            Print(orderExtensions); Console.WriteLine(); Line(50);

            //task 11
            Console.WriteLine("Now extracting all students with e-mail in ABV"); Line(50);
            var extractByMail = sampleStudents.ExtractMail("@abv.bg"); // can change the prefix fo other serach for example @yahoo.com
            Print(extractByMail); Line(50);

            //task 12
            Console.WriteLine("Now extracting all students with phone in Sofia"); Line(50);
            var extractByPhone = sampleStudents.PhoneChecker("02"); // can use custom prefix to find for example ++359
            Print(extractByPhone); Line(50);

            //task 13
            Console.WriteLine("Now selecting all stidents with at least one Exvellent Mark(6) "); Line(50);
            var markExcellent = sampleStudents
                                .Where(x => x.Marks.Contains(6))
                                .Select(x => new
                                {
                                    FullName = x.FirstName + " " + x.LastName, // anonomious class
                                    Marks = x.Marks
                                });
            foreach (var student in markExcellent)
            {
                Console.WriteLine(student.FullName + " has the following marks " + string.Join(", ", student.Marks));
            }
            Console.WriteLine(); Line(50);

            //task 14
            Console.WriteLine("Extracting studetn with exactly two marks (2)"); Line(50);
            var markTwoTwos = sampleStudents
                              .Where(x => x.TwoFailMarks(2, 2) == true)  // my extension method enter two additional paramets (searched mark - and exact times of repeating the mark)
                              .Select(x => new
                              {
                                  FullName = x.FirstName + " " + x.LastName, // anonomious class
                                  Marks = x.Marks
                              });

            foreach (var student in markTwoTwos)
            {
                Console.WriteLine(student.FullName + " has the following marks " + string.Join(", ", student.Marks));
            }
            Line(50); Console.WriteLine(); Console.WriteLine("Task 15"); Line(50);  
            //task 15
            var allMarksFromYear = sampleStudents.Where(x => x.StudentID.EndsWith("06"))
                                              .Select(x => new
                                              {
                                                  FullName = x.FirstName + " " + x.LastName, // anonomious class
                                                  Marks = x.Marks
                                              });

            foreach (var student in allMarksFromYear)
            {
                Console.WriteLine(student.FullName + " has the following marks " + string.Join(", ", student.Marks));
            }
            Line(50); Console.WriteLine();
            // task 17 - LongestString
            var arrWithNames = sampleStudents.Select(x => x.LastName).ToArray(); // creating array with Last names
            var longestResult = LongestString.Longest(arrWithNames); Line(50); 
            Console.WriteLine("Task 17 This will return the longest LastName : \n{0}", longestResult);


            Console.WriteLine("other test with array for task 17");
            string[] stringArr = new[] {"abv", "dc", "cadabra", "abradac"};
            string newLongest = LongestString.Longest(stringArr);
            Console.WriteLine(newLongest); Line(50);  


            // task18 group bu Group
            /*
             * Create a program that extracts all students grouped by GroupNumber and then prints them to the console.Use LINQ.
             */
            Group firstGroup = new Group(1, "C# Part One");
            Group ssecondGroup = new Group(2, "C# Part Two");
            Group thirdGoup = new Group(3, "C# Part OOP - Part One");
            Group forthGroup = new Group(4, "Java Script Next");
            Group fifthGoup = new Group(5, "Mathemathics");

            List<Group> allGorups = new List<Group> { firstGroup, ssecondGroup, thirdGoup  , forthGroup , fifthGoup};

            var mathStudentsResult = from xGroup in allGorups
                                     where xGroup == fifthGoup // allGorups[4]  or allGroups. or xGropu.GroupNumber == 4
                                     join students in sampleStudents on xGroup.GroupNumber equals students.Group
                                     select new
                                     {
                                         Name = students.FirstName + " " + students.LastName,
                                         Department = fifthGoup.DepartmentName
                                     };
            Console.WriteLine(); Line(50); Console.WriteLine("task 16"); Line(50);  
            Print(mathStudentsResult); Line(50);  

            //task 19
            Console.WriteLine(); Line(50); Console.WriteLine("Task 18-19 - Extract all students and  Order by GroupNumber"); Line(50);  
            var sortByGroups = GroupedByGroupNumber.SortByGroups(sampleStudents);
            Print(sortByGroups); Line(50);


            Console.WriteLine(); Line(50); Console.WriteLine("Task 19 - order by groups with extensions");
            var sortByGroupExtension = sampleStudents
                .OrderBy(x => x.Group)
                .GroupBy(x => x.Group, (groupNumber, student) => new { Group = groupNumber, Student = student }); 
            foreach (var item in sortByGroupExtension)
            {
                Console.WriteLine("GROUP {0}",item.Group); 
                foreach (var st in item.Student)
                {
                    Console.WriteLine(st.FirstName + " " + st.LastName);
                }
                Line(30);
            }
        }

        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void Line(int count)
        {
            Console.WriteLine(new string('=', count));
        }
    }
}
