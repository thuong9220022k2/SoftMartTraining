using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp.Object
{
    public class Teacher : Employee, IEmployeeAction
    {
        #region Constructor
        public Teacher(string name, string age) : base(name, age)
        {
        }
        #endregion

        #region Methods

        public void ShowInfo()
        {
            Console.WriteLine($"I am a teacher .My name is: {Name}, and I am {Age} years old.");
        }

        public void ExtInfo()
        {
            var currentStartTime = DateTime.Now;
            var currentStartSecond = currentStartTime.Second;
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("John", "25"));
            var currentEndTime = DateTime.Now;
            var currentEndSecond = currentEndTime.Second;
            var timeDifference = currentEndSecond - currentStartSecond;
            var teacherIndex = teachers.Count;
            Console.WriteLine($"This is {teacherIndex} teacher Who is {this.Name} and {this.Age} years old after {timeDifference} seconds");
        }
        #endregion

    }

}