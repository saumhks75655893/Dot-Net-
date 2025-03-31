using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFloydsTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int n = 1; 
            for(int i=1; i<=5; i++)
            {
                for(int j=0; j<i; j++)
                {
                    if(n%2 == 0)
                    {
                        Console.Write("0"); 
                    n++; 
                    }
                    else
                    {
                        Console.Write("1");
                    n++; 
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
