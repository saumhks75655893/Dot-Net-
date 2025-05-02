using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSisteenSealedClass
{
    // Sealed class
    sealed class SealededClass
    {
        public void Show()
        {
            Console.WriteLine("This is the sealded class");
        }
    }

    // Attempting to inherit from FinalReport will cause a compile-time error
    /*
    class ExtendedReport : FinalReport
    {
        // ❌ Error: 'FinalReport' is sealed and cannot be inherited
    }
    */

    class Program
    {
        static void Main()
        {
            SealededClass sc = new SealededClass();
            sc.Show();
        }
    }

}
