using System;

class DiamondPattern
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        // Upper part of the diamond
        for (int i = 1; i <= rows; i++)
        {
            for (int j = i; j < rows; j++)
                Console.Write(" ");

            for (int j = 1; j <= (2 * i - 1); j++)
                Console.Write("*");

            Console.WriteLine();
        }

        // Lower part of the diamond
        for (int i = rows - 1; i >= 1; i--)
        {
            for (int j = rows; j > i; j--)
                Console.Write(" ");

            for (int j = 1; j <= (2 * i - 1); j++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}
