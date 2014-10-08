using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_vackarklocka
{
    class Program
    {
        static void Main(string[] args)
        {
            string HorizontalLine = "\n════════════════════════════════════════════════════════════════════════════";

            AlarmClock ac = new AlarmClock();

            //Test 1
            Console.WriteLine(HorizontalLine);
            ViewTestHeader("Test 1. \nTest av standardkonstruktorn.\n");
            Console.WriteLine(ac.ToString());

            //Test 2
            ac = new AlarmClock(9, 42);
            Console.WriteLine(HorizontalLine);
            ViewTestHeader("Test 2. \nTest av konstruktorn med två parametrar, <9, 42>.\n");
            Console.WriteLine(ac.ToString());

            //Test 3
            ac = new AlarmClock(13, 27, 7, 35);
            Console.WriteLine(HorizontalLine);
            ViewTestHeader("Test 3. \nTest av konstruktorn med fyra parametrar, <13, 24, 7, 35>.\n");
            Console.WriteLine(ac.ToString());

            //Test 4
            Console.WriteLine(HorizontalLine);
            ViewTestHeader("Test 4. \nStäller befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
           
            ac = new AlarmClock(23, 58, 7, 35);
            Run(ac, 13);

            //Test 5
            Console.WriteLine(HorizontalLine);
            ViewTestHeader("Test 5. \nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            
            ac = new AlarmClock(6, 12, 6, 15);
            Run(ac, 6);

            //Test 6
            Console.WriteLine(HorizontalLine);
            ViewTestHeader("Test 6. \nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.\n");

            try
            {
                ac.Hour = 25;
            }
            catch
            {
                ViewErrorMessage("Timmen är inte i intervallet 0-23");
            }
            try
            {
                ac.Minute = 61;
            }
            catch
            {
                ViewErrorMessage("Minuten är inte i intervallet 0-59");
            }
            try
            {
                ac.AlarmHour = 25;
            }
            catch
            {
                ViewErrorMessage("Alarmtimmen är inte i intervallet 0-23");
            }
            try
            {
                ac.AlarmMinute = 61;
            }
            catch
            {
                ViewErrorMessage("Alarmminuten är inte i intervallet 0-59");
            }

            //Test 7
            Console.WriteLine(HorizontalLine);
            ViewTestHeader("Test 7. \nTestar konstruktorer så att undantag kastas då tid och alarmtid tildelas felaktiga värden.\n");
            
            try
            {
                ac = new AlarmClock(25, 0);
            }
            catch
            {
                ViewErrorMessage("Timmen är inte i intervallet 0-23");
            }
            try
            {
                ac = new AlarmClock(0, 30);
            }
            catch
            {
                ViewErrorMessage("Minuten är inte i intervallet 0-59");
            }
            try
            {
                ac = new AlarmClock(0, 0, 25, 0);
            }
            catch
            {
                ViewErrorMessage("Alarmtimmen är inte i intervallet 0-23");
            }
            try
            {
                ac = new AlarmClock(0, 0, 0, 30);
            }
            catch
            {
                ViewErrorMessage("Alarmminuten är inte i intervallet 0-59");
            }

           
        }
        private static void Run(AlarmClock ac, int minutes)
        {

            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(ac.ToString() + "     Beep Beep Beep");
                    Console.ResetColor();
                }
                
                Console.WriteLine(ac.ToString()); 
            }
        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }
    }
}
