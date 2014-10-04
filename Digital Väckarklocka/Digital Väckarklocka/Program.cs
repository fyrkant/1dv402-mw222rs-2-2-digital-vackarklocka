using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Väckarklocka
{
    class Program
    {
        private static string HorizontalLine = "________________________________________________________________________________";

        static void Main(string[] args)
        {
            AlarmClock klocka = new AlarmClock(23, 59, 12, 56);
            AlarmClock klocka2 = new AlarmClock();

            Console.WriteLine(klocka.ToString());
            Console.WriteLine(klocka2.ToString());

            Run(klocka, 5);
            Run(klocka2, 5);

            Console.WriteLine(klocka.ToString());
            Console.WriteLine(klocka2.ToString());
        }

        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                ac.TickTock();                
            }
        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.Write(HorizontalLine);
            Console.WriteLine(header);
            Console.WriteLine();
        }
    }
}
