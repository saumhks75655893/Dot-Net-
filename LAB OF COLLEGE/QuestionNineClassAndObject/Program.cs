using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionNineClassAndObject
{
    class ClassDemostrate
    {
        public void DemoFunc()
        {
            int a = 1;  
            int b = 2;
            int add = a + b; 
            Console.WriteLine("Addition is "+add);
            Console.WriteLine("This is the class function demonstratoin with object creation");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassDemostrate cd = new ClassDemostrate();
            cd.DemoFunc(); 
        }
    }
}
