using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTenThisReference
{
    class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;  // 'this' distinguishes between the field and the parameter
        }

        public void Display()
        {
            Console.WriteLine("Name: " + this.name);
        }
    }

    class Program
    {
        static void Main()
        {
            Student s = new Student("Himanshu Kumar");
            s.Display();  // Output: Name: John
        }
    }

}
