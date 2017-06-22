using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }
        [Test]
        public void CalculateAnotherSum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1.3+2+7");
            Check.That(result).IsEqualTo(10.3);
        }
        [Test]
        public void CalculateComplexeCalcul()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("3+2-7/4");
            Check.That(result).IsEqualTo(-0.5);
        }
        [Test]
        public void CalculateAnotherComplexeCalcul()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("100+56.3-1.8/25");
            Check.That(result).IsEqualTo(6.18);
        }
    }
}
