using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculator Calc = new Calculator.Calculator();
            Console.WriteLine(Calc.Add(1, 2));
        }
    }
}
