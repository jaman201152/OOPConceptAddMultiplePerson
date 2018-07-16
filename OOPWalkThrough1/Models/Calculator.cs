using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough1.Models
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber+secondNumber;
        }

        public int Add(int firstNumber, int secondNumber, int thirdNumber=0)
        {
            return firstNumber+secondNumber+thirdNumber;
        }

        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Add(params double[] inputs)
        {
            double result = 0;
            if (inputs.Length == 0)
            {
                return result;
            }

            foreach (double input in inputs)
            {
                result += input;
            }

            return result;
        }
    }
}
