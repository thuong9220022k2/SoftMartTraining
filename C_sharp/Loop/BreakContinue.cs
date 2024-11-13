using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace C_sharp.Loop
{
    public class BreakHandler
    {
        public void PrintNextWeek()
        {
            Console.WriteLine("Enter number :");
            string numberInput = Console.ReadLine();
            int number;
            if (!int.TryParse(numberInput, out number))
            {
                Console.WriteLine("Number is not valid.");
                return;
            }
            DateTime currentTime = DateTime.Now;
            for (int i = 0; i < number; i++)
            {
                currentTime = currentTime.AddDays(1);
                var currentWeek = currentTime.DayOfWeek;
                if (currentWeek != DayOfWeek.Sunday)
                {
                    Console.WriteLine($"Next week {currentWeek}");
                }
                else
                {
                    continue;
                }
            }

        }
        // public static void Main(string[] args)
        // {
        //     BreakHandler breakHandler = new BreakHandler();
        //     breakHandler.PrintNextWeek();
        // }



    }
}