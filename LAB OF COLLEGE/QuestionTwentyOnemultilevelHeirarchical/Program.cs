using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwentyOnemultilevelHeirarchical
{
    class Person
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("I am a person.");
        }
    }

    // Derived class 1
    class Student : Person
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a student.");
        }
    }

    // Derived class 2 (from Student)
    class CollegeStudent : Student
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a college student.");
        }
    }

    class Program
    {
        static void Main()
        {
            Person p;

            p = new Person();
            p.DisplayInfo();  // Output: I am a person.

            p = new Student();
            p.DisplayInfo();  // Output: I am a student.

            p = new CollegeStudent();
            p.DisplayInfo();  // Output: I am a college student.
        }
    }

}
