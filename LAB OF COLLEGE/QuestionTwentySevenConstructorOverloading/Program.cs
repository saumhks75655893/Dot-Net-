using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwentySevenConstructorOverloading
{
    class Employee
    {
        public int Id;
        public string Name;
        public string Department;

        // Default constructor
        public Employee()
        {
            Id = 0;
            Name = "Not Assigned";
            Department = "General";
        }

        // Constructor with ID and Name
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Department = "General";
        }

        // Constructor with all properties
        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Department: {Department}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(101, "Himanshu Kumar");
            Employee emp3 = new Employee(102, "Kamlesh Kushwaha", "HR");

            emp1.Display();
            emp2.Display();
            emp3.Display();
        }
    }

}
