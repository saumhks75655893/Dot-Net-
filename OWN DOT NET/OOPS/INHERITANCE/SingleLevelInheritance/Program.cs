using System;

internal class Program
{
    //base class
    class vehicle
    {
        string number;
        string owner;
        string typeOfTheVehicle;
    }

    //derived class
    class car : vehicle
    {
        public string number = "UP 65 AX 1023";
        public string owner = "HIMANSHU KUMAR"; 
        string typeOfTheVehicle = "Car";

        public void getDetails()
        {
            Console.WriteLine("The number of the car is : " + number);
            Console.WriteLine("The owner of the car is : " + owner);
            Console.WriteLine("The type of the vechicle is : "+ typeOfTheVehicle); 
        }
    }
    static void Main(string[] args)
    {
        car v1 = new car();
        v1.getDetails(); 
    }
}

