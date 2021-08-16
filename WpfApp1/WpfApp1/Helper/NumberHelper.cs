using System;
using System.Linq;
using WpfApp1.Model;

namespace WpfApp1.Helper
{
    public static class NumberHelper 
    {
        public static void GenerateNumber(ref string Display, ref CalculatorModel calculator, string number)
        {
            try
            {
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = number;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + number;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = number;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + number;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateOne(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string one = "1";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = one;
                    Display = calculator.FirstNumber;                    
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + one;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = one;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber ;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + one;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateTwo(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string two = "2";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = two;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + two;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = two;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + two;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateThree(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string three = "3";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = three;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + three;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = three;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + three;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateFour(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string four = "4";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = four;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + four;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = four;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + four;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateFive(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string five = "5";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = five;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + five;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = five;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + five;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateSix(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string six = "6";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = six;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + six;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = six;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + six;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateSeven(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string seven = "7";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = seven;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + seven;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = seven;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + seven;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateEigth(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string eigth = "8";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = eigth;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + eigth;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = eigth;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + eigth;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateNine(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string nine = "9";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = nine;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + nine;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = nine;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + nine;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GenerateZero(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string zero = "0";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    calculator.FirstNumber = zero;
                    Display = calculator.FirstNumber;
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (calculator.FirstNumber.Length <= 11)
                        {
                            calculator.FirstNumber = calculator.FirstNumber + zero;
                        }
                        Display = calculator.FirstNumber;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            calculator.SecondNumber = zero;
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                        else
                        {
                            if (calculator.SecondNumber.Length <= 11)
                            {
                                calculator.SecondNumber = calculator.SecondNumber + zero;
                            }
                            Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                        }
                       }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GeneratePoint(ref string Display, ref CalculatorModel calculator)
        {
            try
            {
                string point = ".";
                if (string.IsNullOrEmpty(calculator.FirstNumber))
                {
                    if (!calculator.FirstNumber.Contains('.'))
                    {
                        calculator.FirstNumber = point;
                        Display = calculator.FirstNumber;
                    }
                }
                else
                {
                    if (char.IsWhiteSpace(calculator.Operator))
                    {
                        if (!calculator.FirstNumber.Contains('.'))
                        {
                            calculator.FirstNumber = calculator.FirstNumber + point;
                            Display = calculator.FirstNumber;
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(calculator.SecondNumber))
                        {
                            if (!calculator.SecondNumber.Contains('.'))
                            {
                                calculator.SecondNumber = point;
                                Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                            }
                        }
                        else
                        {
                            if (!calculator.SecondNumber.Contains('.'))
                            {
                                calculator.SecondNumber = calculator.SecondNumber + point;
                                Display = calculator.FirstNumber + " " + calculator.Operator + " " + calculator.SecondNumber;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
