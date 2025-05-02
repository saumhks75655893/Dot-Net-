using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwentyHeirarchical
{
    // Base class
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle started.");
        }
    }

    // Derived class 1
    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    // Derived class 2
    class Bike : Vehicle
    {
        public void Ride()
        {
            Console.WriteLine("Bike is riding.");
        }
    }

    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.Start();  // Inherited from Vehicle
            car.Drive();  // Specific to Car

            Console.WriteLine();

            Bike bike = new Bike();
            bike.Start(); // Inherited from Vehicle
            bike.Ride();  // Specific to Bike
        }
    }

}
