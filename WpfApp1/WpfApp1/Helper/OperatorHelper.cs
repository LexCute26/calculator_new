using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Helper
{
    public static class OperatorHelper
    {
        public static double ProcessTwoNumbers(ref CalculatorModel calculator)
        {
            double result = 0.0;

            switch (calculator.Operator)
            {
                case '+':
                    {
                        result = double.Parse(calculator.FirstNumber) + double.Parse(calculator.SecondNumber);
                        calculator.Result = result.ToString();
                        break;
                    }              
                case '-':
                    {
                        result =  double.Parse(calculator.FirstNumber) - double.Parse(calculator.SecondNumber);
                        calculator.Result = result.ToString();
                        break;
                    }
                case '/':
                    {
                        result = double.Parse(calculator.FirstNumber) / double.Parse(calculator.SecondNumber);
                        calculator.Result = result.ToString();
                        break;
                    }
                case '*':
                    {
                        result = double.Parse(calculator.FirstNumber) * double.Parse(calculator.SecondNumber);
                        calculator.Result = result.ToString();
                        break;
                    }
            }

            return result;
        }
    }
}
