using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp.Loop
{
    public class SwitchHandler
    {
        public void GetDayOfWeek()
        {
            Console.WriteLine("Enter value :");
            string input = Console.ReadLine(); //format Date Thang/Ngay/Nam
            DateTime.TryParse(input, out DateTime datetimeValue); //add format datetime 
            // Console.WriteLine(datetimeValue.DayOfWeek);
            var currentDay = datetimeValue.DayOfWeek;
            switch (currentDay)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Thu hai");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Thu ba");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Thu tu");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Thu nam");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Thu sau");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Thu bay");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Chu nhat");
                    break;
            }
        }
        // public static void Main(string[] args)
        // {
        //     SwitchHandler switchHandler = new SwitchHandler();
        //     switchHandler.GetDayOfWeek();

        // }


    }
}