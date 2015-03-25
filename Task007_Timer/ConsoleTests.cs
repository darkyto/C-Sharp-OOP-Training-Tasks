namespace Task007_Timer
{
    using System;

    public class ConsoleTests
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program will use custom timer to invoke some methods every three seconds");

            Timer tm = new Timer(3);

            tm.Method += PrintCustomStart;
            tm.Method = tm.Method + PrintCustomEnd;

            tm.Start("Eastern Bunnny");

        }
        public static void PrintCustomStart(string a)
        {
            Console.WriteLine("Printed at {0}th second of the current minute", DateTime.Now.Second);
            if (DateTime.Now.Second % 15 == 0)
            {
                Console.WriteLine(a);
            }
        }
        public static void PrintCustomEnd(string a)
        {
            Console.WriteLine("CALABUNGA At The Same {0} ", DateTime.Now);
            if (DateTime.Now.Second % 10 == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("[{0}] Welcome to Tihuana! Tequila!", a);
                Console.ResetColor();
            }
        }
    }
}
