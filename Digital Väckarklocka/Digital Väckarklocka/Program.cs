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

            ViewTestHeader("Test 5. \nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 \noch låt den gå 6 minuter.");
            test2.Hour = 6;
            test2.Minute = 12;
            test2.AlarmHour = 6;
            test2.AlarmMinute = 15;
            Run(test2, 6);

            ViewTestHeader("Test 6. \nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas \nfelaktiga värden.");
            try
            {
                test3.Hour = -6;
                test3.Minute = -12;
                test3.AlarmHour = 56;
                test3.AlarmMinute = 115;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {                
                test3.Minute = -12;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                test3.AlarmHour = 56;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                test3.AlarmMinute = 115;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
                        

            ViewTestHeader("Test 7. \nTestar konstruktorerna så att undantag kastas då tid och alarmtid tilldelas \nfelaktiga värden. ");
            try 
	        {
                test3 = new AlarmClock(25, 15);
	        }
	        catch (ArgumentException ex)
	        {
                ViewErrorMessage(ex.Message);
	        }

            try
            {
                test3 = new AlarmClock(0, 0, 67, 03);
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }


        }

        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("    BEEP!");
                    Console.Write(ac.ToString());
                    Console.WriteLine("  BEEP! VAKNA!   ");
                    Console.ResetColor();

                }
                else 
                {
                    Console.Write("         ");
                    Console.WriteLine(ac.ToString());
                }                
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
