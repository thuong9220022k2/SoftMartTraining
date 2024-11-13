using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp.Object
{
    public class Student : Employee, IEmployeeAction
    {
        #region Constructor

        public Student(string name, string age) : base(name, age)
        {
        }
        #endregion

        #region Methods
        public List<Student> AddStudent(string name, string age)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(name, age));
            return students;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"My name is: {Name}, and I am {Age} years old, and I am a student");
        }

        public void ExtInfo()
        {
            var currentStartTime = DateTime.Now;
            var currentStartSecond = currentStartTime.Second;
            List<Student> students = new List<Student>();
            students.Add(new("John", "25"));
            var currentEndTime = DateTime.Now;
            var currentEndSecond = currentEndTime.Second;
            var timeDifference = currentEndSecond - currentStartSecond;
            var studentIndex = students.Count;
            Console.WriteLine($"This is {studentIndex} student Who is {Name} and {Age} years old after {timeDifference} seconds");
        }
        #endregion
    }

}