using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp
{
    public class ForLoopHandler
    {
        public void PrintNextMonth()
        {
            Console.WriteLine("Enter number :");
            string numberInput = Console.ReadLine();
            int day;
            if (!int.TryParse(numberInput, out day))
            {
                Console.WriteLine("Number is not valid.");
                return;
            }
            DateTime currentTime = DateTime.Now;
            var currentMonth = currentTime.Month;
            var currentYear = currentTime.Year;
            int nextMonth;
            if (currentMonth == 12)
            {
                nextMonth = 1;
                currentYear = currentYear + 1;
            }
            nextMonth = currentMonth + 1;
            DateTime nextDateTime = new DateTime(currentYear, nextMonth, day);
            for (int i = 0; i < 10; i++)
            {
                nextDateTime = nextDateTime.AddDays(1);
                Console.WriteLine($"Next {i + 1} day : {nextDateTime} ");
            }
        }
        // public static void Main(string[] args)
        // {
        //     ForLoopHandler loopHandler = new ForLoopHandler();
        //     loopHandler.PrintNextMonth();
        // }

    }
}