using System;

namespace CalcApp
{
    public interface IChecker
    {
        public static double Checked(string numberString, int index)
        {
            double number;
            
            try
            {
                number = Convert.ToDouble(numberString);
            }
            catch (FormatException)
            {
                Console.WriteLine(("Error, please enter "+ index+" number correctly"));
                number = Checked((Console.ReadLine()), index);
            }

            return number;
        }
    }
}