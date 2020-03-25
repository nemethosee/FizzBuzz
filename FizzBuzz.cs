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

        // Method   :   FizzBuzz
        // Descr.   :   Method takes an integer numeric input and returns the following:
        //               - the word "FizzBuzz" if the input number is multiple of 3 and 5
        //               - the word "Fizz" if the input number is multiple of 3
        //               - the word "BUzz" if the input number is multiple of 5
        //               - the input number itself if none of the above conditions apply
        // Input    :   InputNumber
        // Output   :   none

        public String FizzBuzz(int InputNumber)
        {
            string OutputValue;

            if ((InputNumber % 3 == 0) && (InputNumber % 5 == 0)) OutputValue = "FizzBuzz";
            else if (InputNumber % 3 == 0) OutputValue = "Fizz";
            else if (InputNumber % 5 == 0) OutputValue = "Buzz";
            else OutputValue = InputNumber.ToString();
            
            return OutputValue;
        }
    }
}
