using System;
using System.Diagnostics;

namespace CalcApp
{
    public class Calculator
    {
        public static double Calc(double number1, double number2, char op)
        {
            return op switch
            {
                Operators.Addition => number1 + number2,
                Operators.Subtraction => number1 - number2,
                Operators.Multiplication => number1 * number2,
                Operators.Division when number2 !=0 => number1 / number2,
                _ => throw new DivideByZeroException()
            };
        }
    }
}