using System;
using System.Collections.Generic;

namespace CalcApp
{
    public interface IParser
    {
        public static List<string> Parsing(string expression)
        {
            List<string> lexemList = new List<string>();
            string lexem = "";

            foreach (var character in expression)
            {
                if (
                    character == Operators.Addition ||
                    character == Operators.Subtraction ||
                    character == Operators.Multiplication ||
                    character == Operators.Division
                )
                {
                    lexemList.Add(lexem);
                    lexemList.Add(Convert.ToString(character));
                    lexem = "";
                }
                else
                {
                    lexem += character;
                }
            }
            lexemList.Add(lexem);

            return lexemList;
        }
    }
}