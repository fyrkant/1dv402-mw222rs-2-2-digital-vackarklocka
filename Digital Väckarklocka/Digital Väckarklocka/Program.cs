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
            ViewTestHeader("Test 1. \nTest av standardkonstruktorn.");
            AlarmClock test1 = new AlarmClock();
            Console.WriteLine(test1.ToString());

            ViewTestHeader("Test 2. \nTest av konstruktorn med två parametrar, (9, 42).");
            AlarmClock test2 = new AlarmClock(9, 42);
            Console.WriteLine(test2.ToString());

            ViewTestHeader("Test 3. \nTest av konstruktorn med fyra parametrar, (12, 24, 7, 35).");
            AlarmClock test3 = new AlarmClock(12, 24, 7, 35);
            Console.WriteLine(test3.ToString());

            ViewTestHeader("Test 4. \nStäller befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.");
            test3.Hour = 23;
            test3.Minute = 58;
            Run(test3, 13);

            ViewTestHeader("Test 5. \nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 och låt den gå 6 minuter.");
            test2.Hour = 6;
            test2.Minute = 12;
            test2.AlarmHour = 6;
            test2.AlarmMinute = 15;
            Run(test2, 6);





        }

        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                ac.TickTock();
                Console.WriteLine(ac.ToString());
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
