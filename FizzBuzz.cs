using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class cls_FizzBuzz
    {
        static void Main(string[] args)
        {
        }

        public String FizzBuzz(int InputNumber)
        {
            string OutputValue;

            if (InputNumber % 3 == 0) OutputValue = "Fizz";
            else OutputValue = InputNumber.ToString();
            return OutputValue;
        }
    }
}
