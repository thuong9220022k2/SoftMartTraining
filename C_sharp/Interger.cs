using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp
{
    public class IntergerHandler
    {
        public string CheckInterger(int number)
        {
            if (number <= 0)
            {
                var message = Notify.NegativeInterger;
                return message;
            }
            else if (number % 2 == 0)
            {
                var message = Notify.EvenInterger;
                return message;
            }
            else
            {
                var message = Notify.OddInterger;
                return message;
            }
        }

        public int GetAbsValue(int number)
        {
            return Math.Abs(number);
        }

        public double GetSqrtValue(int number)
        {
            if (number < 0)
            {
                return 0;
            }
            return Math.Sqrt(number);
        }

        public int GetRemainder(int dividend, int divisor)
        {
            return dividend % divisor;
        }

        public string CheckPrimeNumber(int number)
        {
            if (number <= 0)
            {
                var message = Notify.NegativeInterger;
                return message;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return Notify.NotPrimeNumber;
                }
            }
            return Notify.PrimeNumber;
        }

        public string CheckNumberInteger(object number)
        {
            if (number.GetType().IsArray)
            {
                var message = Notify.IsArray;
                return message;
            }
            else
            {
                var message = Notify.IsNotArray;
                return message;
            }
        }

        // static void Main(string[] args)
        // {
        //     var intergerHandler = new IntergerHandler();
        //     Console.WriteLine(intergerHandler.CheckPrimeNumber(5));
        // }
    }
}