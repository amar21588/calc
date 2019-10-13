using System;
using System.Collections.Generic;
using System.Text;

namespace Calc.library
{
    public abstract class CalcBase
    {
        public abstract int Calculate(string[] values);

        protected List<int> GetIntegerArray(string[] numbers)
        {
            List<int> numberList = new List<int>();
            int val;
            foreach (var num in numbers)
            {
                val = 0;
                int.TryParse(num, out val);
                numberList.Add(val);
            }
            return numberList;
        }
    }
}
