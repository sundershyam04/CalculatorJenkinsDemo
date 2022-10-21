using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorJenkinsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator cal = new Calculator();

            int a = 10, b = 25;

            Console.WriteLine($"Addition of {a} and {b} : { cal.Add(a, b)}" );

            Console.WriteLine($"Subtraction of {a} from {b} : {cal.Subtract(b, a)}");

            Console.WriteLine($"Multiplication of {a} and {b} : {cal.Multiply(a, b)}");

            Console.WriteLine($"Division of {b} and {a} :  {cal.Divide(b, a)}");

            Console.WriteLine($"Squareroot of {b} : {cal.Sqrroot(b)}");
      
            Console.Read();
        }
    }
}
