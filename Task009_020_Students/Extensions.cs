using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task009_020_Students
{
    public static class Extensions
    {
        //extension methods
        public static IEnumerable<Student> GroupOrder(this IEnumerable<Student> collection)
        {
            IEnumerable<Student> result = collection.Where(x => x.Group == 2).OrderBy(x => x.FirstName);

            return result;
        }
        public static IEnumerable<Student> ExtractMail(this IEnumerable<Student> collection, string prefix)
        {
            IEnumerable<Student> result = collection.Where(x => x.Email.Contains(prefix));

            return result;
        }
        public static IEnumerable<Student> PhoneChecker(this IEnumerable<Student> collection, string prefix)
        {
            IEnumerable<Student> result = collection.Where(x => x.PhoneNumber.StartsWith(prefix));

            return result;
        }
        public static bool TwoFailMarks(this Student student, double searched, int times)
        {
            int result = 0;
            foreach (var mark in student.Marks)
            {
                if (mark == searched)
                {
                    result++;
                }
            }

            if ((int)result == times)
            {
                return true;
            }
            return false;

        }
    }
}
