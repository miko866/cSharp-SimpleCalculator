using System;
using Xunit;

namespace SimpleCalturator.Test.Unit
{
    public class CalculatorEngineTest
    {
        private readonly SimpleCalculator.CalculatorEngine _calculatorEngine = new SimpleCalculator.CalculatorEngine();

        [Fact]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);

            Assert.Equal(3, result);

        }

        [Fact]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);

            Assert.Equal(3, result);

        }
    }
}
