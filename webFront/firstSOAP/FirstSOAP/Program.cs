using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculatorSoapClient calc = new Calculator.CalculatorSoapClient();
            Console.WriteLine(calc.Add(1, 3));
            Console.ReadLine();
        }
    }
}
