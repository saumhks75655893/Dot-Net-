using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSeventeenBoxing
{
    class Program
    {
        static void Main()
        {
            int num = 42;          // value type
            object obj = num;      // Boxing: int → object

            Console.WriteLine("Boxed value: " + obj);

            int unboxedNum = (int)obj;  // Unboxing: object → int

            Console.WriteLine("Unboxed value: " + unboxedNum);
        }
    }
}
