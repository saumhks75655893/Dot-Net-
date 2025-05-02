using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFourteenObjectAsArgument
{
    class Complex
    {
        private int real;
        private int imag;

        // Constructor
        public Complex(int real, int imag)
        {
            this.real = real;   // 'this' refers to the current object's field
            this.imag = imag;
        }

        // Method to add two complex numbers
        public Complex Add(Complex c)
        {
            // Add c to the current object (this)
            int sumReal = this.real + c.real;
            int sumImag = this.imag + c.imag;

            return new Complex(sumReal, sumImag);  // return new Complex object
        }

        // Method to display the complex number
        public void Display()
        {
            Console.WriteLine($"{real} + {imag}i");
        }
    }

    class Program
    {
        static void Main()
        {
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(1, 2);

            Console.Write("First Complex Number: ");
            c1.Display();

            Console.Write("Second Complex Number: ");
            c2.Display();

            Complex result = c1.Add(c2);

            Console.Write("Sum: ");
            result.Display();  // Output: 4 + 6i
        }
    }

}
