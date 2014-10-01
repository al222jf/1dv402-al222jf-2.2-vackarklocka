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
            string HorizontalLine = "════════════════════════════════════════════════════════════════════════════";

            AlarmClock a = new AlarmClock();

            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Test 1. \nTest av standardkonstruktorn.\n");
            Console.WriteLine(a.ToString());
            Console.WriteLine();

            a = new AlarmClock(9, 42);
            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Test 2. \nTest av konstruktorn med två parametrar, <9, 42>.\n");
            Console.WriteLine(a.ToString());
            Console.WriteLine();

            a = new AlarmClock(13, 27, 7, 35);
            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Test 3. \nTest av konstruktorn med fyra parametrar, <13, 24, 7, 35>.\n");
            Console.WriteLine(a.ToString());
            Console.WriteLine();

            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Test 4. \nStäller befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            a = new AlarmClock(23, 58, 7, 35);
            Run(a, 13);

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
