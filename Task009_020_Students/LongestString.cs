namespace Task009_020_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LongestString
    {
        public static string Longest(ICollection<string> myString) // task 17
        {
            var sorted = from strings in myString
                         orderby strings.Length descending
                         select strings;

            string result = sorted.FirstOrDefault();
            return result;
        }
    }
}
