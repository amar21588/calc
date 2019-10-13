using Calc.library;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, CalcBase> functions = new Dictionary<string, CalcBase>();
            functions.Add("Add", new Addition());
            functions.Add("Sum", new Addition());
            functions.Add("Multiply", new Multiplication());
            string[] numbers = args.Where(val => val != args[0]).ToArray();
            int result = functions[args[0]].Calculate(numbers);
            Console.WriteLine("Output : " + result);
        }
    }
}
