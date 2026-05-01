using Xunit;
using CalculatorApp;

namespace CalculatorTests
{
    public class UnitTest1
    {
        Calculator calc = new Calculator();

        [Fact]
        public void Add_Test()
        {
            Assert.Equal(15, calc.Add(10, 5));
        }

        [Fact]
        public void Subtract_Test()
        {
            Assert.Equal(5, calc.Subtract(10, 5));
        }

        [Fact]
        public void Multiply_Test()
        {
            Assert.Equal(50, calc.Multiply(10, 5));
        }
    }
}
