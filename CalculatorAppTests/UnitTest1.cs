using CalcApp;
using NUnit.Framework;

namespace CalculatorAppTests
{
    public class CalculatorTests
    {

        [Test]
        public void TestAddition()
        {
            string expression = "10+5";
            double result = 15;
            Assert.IsTrue(result == IController.Contr(expression));
        }

        [Test]
        public void TestSubtraction()
        {
            string expression = "10-5";
            double result = 5;
            Assert.IsTrue(result == IController.Contr(expression));
        }

        [Test]
        public void TestMultiplication()
        {
            string expression = "10*5";
            double result = 50;
            Assert.True(result == IController.Contr(expression));
        }
        
        [Test]
        public void TestDivision()
        {
            string expression = "10/5";
            double result = 2;
            Assert.True(result == IController.Contr(expression));
        }
    }
}