using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace C_sharp
{
    public class WhileHandler
    {
        public void PrintNextDay()
        {
            Console.Write("Enter time (yyyy-MM-dd HH:mm:ss): ");
            string dateTimeInput = Console.ReadLine();
            DateTime startDateTime;
            if (!DateTime.TryParse(dateTimeInput, out startDateTime))
            {
                Console.WriteLine("Datetime value is not valid");
                return;
            }
            Console.WriteLine("Enter second :");
            string numberInput = Console.ReadLine();
            int seconds;
            if (!int.TryParse(numberInput, out seconds))
            {
                Console.WriteLine("Number is not valid.");
                return;
            }
            while (seconds > 0)
            {
                startDateTime = startDateTime.AddDays(1);
                Console.WriteLine($"Next Day: {startDateTime:yyyy-MM-dd HH:mm:ss}");
                seconds--;
                Thread.Sleep(1000);

            }

        }
        // public static void Main(string[] args)
        // {
        //     WhileHandler whileHandler = new WhileHandler();
        //     whileHandler.PrintNextDay();

        // }

    }
}