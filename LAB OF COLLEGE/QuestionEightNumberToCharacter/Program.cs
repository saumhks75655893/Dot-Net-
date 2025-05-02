using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEightNumberToCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 127)
            {
                char Char = (char)num;
                Console.WriteLine("The ASCII character is: " + Char);
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 0 and 127.");
            }
        }
    }
}
