using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp.DataType
{
    public class DictionnaryHandler
    {
        public void PrintObjectDict()
        {
            Dictionary<int, string> StudentDict = new Dictionary<int, string>();
            StudentDict.Add(1, "John");
            StudentDict.Add(2, "Doe");
            StudentDict.Add(3, "Smith");
            foreach (var item in StudentDict)
            {
                Console.WriteLine(item);
            }
        }

        public string CheckStudent(int id)
        {
            Dictionary<int, string> StudentDict = new Dictionary<int, string>();
            StudentDict.Add(1, "John");
            StudentDict.Add(2, "Doe");
            StudentDict.Add(3, "Smith");
            if (StudentDict.ContainsKey(id))
            {
                var studentName = StudentDict[id].ToString();
                return studentName;
            }
            return Error.InvalidStudentId;
        }

        public string AddStudent(int id, string name)
        {
            Dictionary<int, string> StudentDict = new Dictionary<int, string>();
            StudentDict.Add(1, "John");
            StudentDict.Add(2, "Doe");
            StudentDict.Add(3, "Smith");
            if (StudentDict.ContainsKey(id))
            {
                var message = Error.StudentExists;
                return message;
            }
            else
            {
                StudentDict.Add(id, name);
                var message = $"{Notify.AddedStudent} {name} with id {id}";
                return message;
            }
        }

        public string UpdateStudent(int id, string name)
        {
            Dictionary<int, string> StudentDict = new Dictionary<int, string>();
            StudentDict.Add(1, "John");
            StudentDict.Add(2, "Doe");
            StudentDict.Add(3, "Smith");
            if (StudentDict.ContainsKey(id))
            {
                StudentDict[id] = name;
                var message = $"{Notify.UpdatedStudent} {name} with id {id}";
                return message;
            }
            else
            {
                AddStudent(id, name);
                var message = $"{Notify.AddedStudent} {name} with id {id}"; ;
                return message;
            }
        }

        // static void Main(string[] args)
        // {
        //     DictionnaryHandler dict = new DictionnaryHandler();
        //     Console.WriteLine(dict.AddStudent(4, "Mathew"));
        // }
    }
}