using System;
using System.Text;
using System.Collections.Generic;
namespace C_sharp.DataType
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
        public void ReverseList(List<int> list)
        {
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void RemoveElement(List<int> list, int element)
        {
            List<int> listElement = new List<int>();
            foreach (var item in list)
            {
                if (item >= element)
                {
                    listElement.Add(item);
                }
            }
            foreach (var item in listElement)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintLastElements(List<int> list, int n)
        {
            if (n > list.Count)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = list.Count - n; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }

        public void PrintReverseLastElements(List<int> list, int n)
        {
            List<int> newList = new List<int>();
            for (int i = list.Count - n; i < list.Count; i++)
            {
                newList.Add(list[i]);
            }
            newList.Reverse();
            foreach (var item in newList)
            {
                Console.WriteLine(item);

            }
        }

        public void Fibonaci(int n)
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            for (int i = 2; i < n; i++)
            {
                list.Add(list[i - 1] + list[i - 2]);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintObject()
        {
            List<object> list = new List<object> { 1, "Hello", 3.5, true, 'a' };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void testExeception()
        {
            try { } catch (Exception ex) { throw ; }
            try { } catch (Exception ex) { throw ex; }
            try { } catch (Exception ex) { throw new Exception(); }

            // static void Main(string[] args)
            // {
            //     ListHandler listHandler = new ListHandler();
            //     listHandler.Fibonaci(10);
            // }

        }
}