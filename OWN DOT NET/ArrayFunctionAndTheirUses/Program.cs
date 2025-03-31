using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayFunctionAndTheirUses
{
    
        static void Main(string[] args)
        {
        // Clear()
        
            int[] numbers = { 1, 2, 3, 4, 5 };

            Array.Clear(numbers, 1, 3);

            Console.WriteLine("Array after clearing elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }


        // Copy()
        Console.WriteLine(); 
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = new int[10];
        arr1.CopyTo(arr2, 3);

        Console.WriteLine(); 
        Console.WriteLine("First array element : ");
        foreach(int num in arr1)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("Destination Array after CopyTo:");
        foreach (var num in arr2)
        {
            Console.Write(num + " ");
        }

        // GetLength() :-----
        Console.WriteLine(); 
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        Console.WriteLine($"Rows: {rows}, Columns: {cols}");

        // GetValue() : ----
        string[] colors = { "Red", "Green", "Blue" };

        Console.WriteLine($"Value at index 1: {colors.GetValue(1)}");

        // SetValue() : -----
        string[] fruits = { "Apple", "Banana", "Mango" };
        Console.WriteLine("Old Array:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        fruits.SetValue("Orange", 1);

        Console.WriteLine("Updated Array:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Contains() :-------
        int[] numArr = { 1, 2, 3, 4, 5 };

        bool containsThree = numArr.Contains(3);
        bool containsTen = numArr.Contains(10);

        Console.WriteLine($"Contains 3: {containsThree}");
        Console.WriteLine($"Contains 10: {containsTen}");

        // Insert() :------
        Console.WriteLine();
        string s = "Himanshu BCA"; 
        Console.WriteLine("Before inserting : " + s);

        string result = s.Insert(9, "Kumar "); 
        Console.WriteLine("After inserting : " + result);



        // Remove() :---------
        Console.WriteLine();

        List<int> numArray = new List<int> { 10, 20, 30, 40, 50 };
        Console.Write("Original array :");
        foreach (var num in numArray)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine(); 
        numArray.Remove(30);

        Console.Write("After Removing 30:  ");
        foreach (var num in numArray)
        {
            Console.Write(num + " ");
        }

        // RemoveAt() : ------
        Console.WriteLine();
        Console.WriteLine();

        List<string> names = new List<string> { "hi", "hello", "whatsapp", "Nice" };

        Console.Write("Original array :");
        foreach (var name in names)
        {
            Console.Write(name + " ");
        }

        names.RemoveAt(1);  // Remove "hello"
        Console.WriteLine(); 
        Console.Write("After Removing at Index 1:");
        foreach (var name in names)
        {
            Console.Write(name + " ");
        }


        // RemoveRange()
        Console.WriteLine();
        Console.WriteLine();

        List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

        Console.Write("Original Array : ");
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }

        // Remove 3 elements starting at index 2
        Console.WriteLine(); 
        arr.RemoveRange(2, 3);

        Console.Write("After Removing Range:");
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }









        Console.WriteLine();
    }
}
