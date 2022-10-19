using System;
using System.Collections.Generic;

namespace CalcApp
{
    public interface IController
    {
        public static double Contr(string expression)
        {
            List<string> lexems = new List<string>();
            lexems = IParser.Parsing(expression);
            
            return Calculator.Calc(
                IChecker.Checked(lexems[0], 1),
                IChecker.Checked(lexems[2], 2),
                Convert.ToChar(lexems[1]));

        }
    }
}