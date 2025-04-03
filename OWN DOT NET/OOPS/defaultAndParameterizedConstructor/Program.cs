using System;

namespace defaultAndParameterizedConstructor
{
    class Student
    { 
        //instance variables
        public int stdId { get; set; }
        public string stdName { get; set; }
        public string stdCollege { get; set; }

        //default constructor
        public Student()
        {
            stdCollege = "IGNTU AMARKANTAK";
        }

        // parameterized constructor
        public Student(int id, string name, string college)
        {
            this.stdId = id;
            this.stdName = name;
            this.stdCollege = college;
        }
        public Student(int id, string name)
        {
            this.stdId = id;
            this.stdName = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Student id : {stdId}\nStudent name : {stdName}\nStudent College : {stdCollege}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //default
            Console.WriteLine("Default Constructor : ");
            Console.Write(new string('-',50));
            Console.WriteLine(); 
            Student std = new Student();
            std.ShowDetails(); 

            //parameterized with 3 variable
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Parameterized Constructor : ");
            Console.Write(new string('-', 50));
            Console.WriteLine();
            Student std2 = new Student(10,"Meera","BHU");
            std2.ShowDetails(); 

            //parameterized with 2 variable : constructor overloading
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Parameterized Constructor : ");
            Console.Write(new string('-', 50));
            Console.WriteLine();
            Student std3 = new Student(10,"Meera");
            std3.ShowDetails(); 


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
