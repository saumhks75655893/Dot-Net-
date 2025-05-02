using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEighteenSingleInheritance
{
    // Base class
    class Person
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, I am a person.");
        }
    }

    // Derived class
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I am studying.");
        }
    }

    class Program
    {
        static void Main()
        {
            Student s = new Student();
            s.SayHello();  // Inherited from Person
            s.Study();     // Defined in Student
        }
    }

}
