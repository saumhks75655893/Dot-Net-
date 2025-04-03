using System;

//class
class student
{
    //fields (data)
    public int stdId { get; set; }
    public string name { get; set; }
    public string address { get; set; }

    //method

    public void ShowDetails()
    {
        Console.WriteLine("Student Information !!");
        Console.WriteLine($"Student Id : {stdId}\nStudent Name : {name} \nStudent Address : {address}"); 
    }
}
class Program
{
    static void Main(string[] args)
    {
        //object
        student st = new student();
        st.stdId = 1;
        st.name = "Himanshu kumar";
        st.address = "Vill - Rammando, Post-Bhatraul, Chakia, Chandauli, UP (232103)";

        st.ShowDetails(); 
    }
}

