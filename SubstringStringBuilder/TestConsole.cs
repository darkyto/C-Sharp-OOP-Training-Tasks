
namespace SubstringStringBuilder
{
    using System;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("abra ca dabra");
            var test = sb.Substring(0, 4);  // will return abra
            var test2 = sb.Substring(5, 8); // this will return ca dabra
            Console.WriteLine(test);
            Console.WriteLine(test2);
        }
    }
}
