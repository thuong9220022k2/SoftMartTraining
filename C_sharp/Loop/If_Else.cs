using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp.Loop
{
    public class LoopHandler
    {
        // get input command line and check input type
        public void CheckInputType()
        {
            Console.Write("Enter a value: ");
            string input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Input is null");
                return;
            }
            if (int.TryParse(input, out int intValue))
            {
                Console.WriteLine("Input is integer");
            }
            else if (bool.TryParse(input, out bool boolValue))
            {
                Console.WriteLine("Input is boolean");
            }
            else if (DateTime.TryParse(input, out DateTime datetimeValue))
            {
                Console.WriteLine("Input is datatime");
            }
            else
            {
                Console.WriteLine("Input is string");
            }
        }
        // public static void Main(string[] args)
        // {
        //     LoopHandler loopHandler = new LoopHandler();
        //     loopHandler.CheckInputType();

        // }
    }
}