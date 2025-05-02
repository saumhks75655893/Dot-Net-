using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFifteenMethodReturningObjecgt
{    class Person
    {
        public string Name;
        public int Age;

        // Method that returns a Person object
        public static Person CreatePerson(string name, int age)
        {
            Person p = new Person();
            p.Name = name;
            p.Age = age;
            return p;  // returning the object
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Call method that returns a Person object
            Person person1 = Person.CreatePerson("Alice", 25);
            person1.Display();

            // You can also chain it
            Person.CreatePerson("Bob", 30).Display();
        }
    }

}
