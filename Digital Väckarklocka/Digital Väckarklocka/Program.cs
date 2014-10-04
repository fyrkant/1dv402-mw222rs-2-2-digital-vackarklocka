using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Väckarklocka
{
    class Program
    {
        private string HorizontalLine = "Hej en linje.";

        static void Main(string[] args)
        {
            AlarmClock klocka = new AlarmClock(22, 55, 21, 20);

            Console.WriteLine("{0} : {1}, {2} : {3}", klocka.Hour, klocka.Minute, klocka.AlarmHour, klocka.AlarmMinute);

        }

        private static void Run(AlarmClock ac, int minutes)
        {
            // VA?!
        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {            
            Console.WriteLine();
            Console.WriteLine(header);
            Console.WriteLine();
        }
    }
}
