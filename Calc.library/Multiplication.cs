using System;
using System.Collections.Generic;
using System.Text;

namespace Calc.library
{
    public class Multiplication : CalcBase
    {
        public override int Calculate(string[] values)
        {
           
                List<int> intArray = GetIntegerArray(values);
                int result = 0;
                foreach (var num in intArray)
                {
                    result *= num;
                }

                return result;
           
        }
    }
}
