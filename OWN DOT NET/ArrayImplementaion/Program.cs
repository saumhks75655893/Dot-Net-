using System;
using System.Linq; 

class ArrayImplementaion
{

        static void Main(string[] args)
        {
        //// single dimensional array 
        //int[] arr = new int[4]; arr[0] = 1; arr[1] = 2; arr[2] = 3; arr[3] = 4;
        //foreach(int i in arr)
        //{
        //    Console.WriteLine(i);
        //}

        int[] arr = { 1, 2, 3, 4, 5 , 0,3,1,12,5,49,32,1};
        
        Array.Sort(arr);
        foreach(int i in arr)
        {
            Console.Write(i + " "); 
        }

        Console.WriteLine();    
        // multi dimensional array
        int row = 3;
        int col = 3; 
        int[,] arr2d = new int[row,col];
        arr2d[0, 0] = 1;
        arr2d[0, 1] = 2;
        arr2d[0, 2] = 3;
        arr2d[1, 0] = 4;
        arr2d[1, 1] = 5;
        arr2d[1, 2] = 6;
        arr2d[2, 0] = 7;
        arr2d[2, 1] = 8;
        arr2d[2, 2] = 9;

        //for(int i=0; i<row; i++)
        //{
        //    for(int j=0; j<col; j++)
        //    {
        //        Console.Write("Enter the value of array : ");
        //        arr2d[i, j] = int.Parse(Console.ReadLine()); 
        //    }
        //}

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("    "); 
        for(int i = 0; i<row; i++)
        {
            Console.Write($"{i, 4}"); 
        }
        Console.WriteLine(); 
        Console.Write(" ");
        Console.Write(new string('-',16) + "\n");
        for (int i=0; i<row; i++)
        {
            Console.Write($"{i,2} |");
            for(int j=0; j<col; j++)
            {
                Console.Write($"{arr2d[i,j], 4}");
            }
            Console.WriteLine();
        }

        // jagged array
        Console.WriteLine(); 

        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 2, 3 };
        jaggedArray[2] = new int[] { 4, 5, 6 };

        Console.Write("\n" + new string('-', 16) + "\n"); 
        for(int i=0; i<jaggedArray.Length; i++)
        {
            Console.Write($"{i,2} |"); 
            for(int j=0;j<jaggedArray[i].Length; j++)
            {
                Console.Write($"{jaggedArray[i][j], 4}");
            }
            Console.WriteLine(); 
        }
        Console.Write(new string('-', 16) + "\n"); 


    }
}

