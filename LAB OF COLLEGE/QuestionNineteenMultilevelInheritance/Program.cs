using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionNineteenMultilevelInheritance
{
    // Base class
    class Person
    {
        public void ShowName()
        {
            Console.WriteLine("Name: Himanshu Kumar");
        }
    }

    // Derived class from Person
    class Student : Person
    {
        public void ShowStudentId()
        {
            Console.WriteLine("Student ID: 2201151015");
        }
    }

    // Derived class from Employee (indirectly inherits from Person)
    class Department : Student
    {
        public void ShowDepartment()
        {
            Console.WriteLine("Department: Computer Science");
        }
    }

    class Program
    {
        static void Main()
        {
            Department mgr = new Department();

            mgr.ShowName();         // From Person
            mgr.ShowStudentId();   // From Employee
            mgr.ShowDepartment();   // From Manager
        }
    }

}
