using System;
using System.Text;
using System.Collections.Generic;
namespace C_sharp
{
    public class ListHandler
    {
        public void PrintElement()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void SortElement(List<int> list)
        {
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            ListHandler listHandler = new ListHandler();
            listHandler.SortElement(new List<int> { 1, 3, 2, 5, 4, 7, 6, 9, 8, 10 });
        }

    }
}