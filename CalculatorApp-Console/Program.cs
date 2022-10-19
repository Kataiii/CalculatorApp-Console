using System;
using System.Collections.Generic;

namespace CalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the expression");
            string expression = Console.ReadLine();
            
            Console.WriteLine("Your result: "+IController.Contr(expression));
        }
    }
}