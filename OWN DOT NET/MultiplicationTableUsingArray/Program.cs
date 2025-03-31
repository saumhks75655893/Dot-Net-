using System; 

class MultiplicationTable
{
    public static void Main(string[] args)
    {
        int[,] table = new int[10, 10];

        for (int i = 1;i<=10; i++)
        {
            for (int j = 1;j<=10; j++)
            {
                table[i - 1, j - 1] = i * j; 
            }
        }
        Console.WriteLine();

        Console.WriteLine("Multiplication table from 1 to 10 : \n\n");
        Console.Write("    "); 
        for(int i=1; i<=10; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine("\n" + new string('-', 45)); 

        for(int i = 0; i<10; i++)
        {
            Console.Write($"{i+1, 2} |");
            for(int j = 0; j<10; j++)
            {
                Console.Write($"{table[i, j],4}"); 
            }
            Console.WriteLine();
        }
    }
}