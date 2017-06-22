using System;
using System.Linq;
using System.Linq.Expressions;
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

        public void lanceExceptionZero()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("100+56.3-1.8/0");
        }

        [Test]
        public void testExceptionZero()
        {
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(lanceExceptionZero);
            Assert.AreEqual("Impossible de diviser par zero : (154,5/0)",ex.Message);
        }

        public void lanceExceptionMalFormer()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("100+56.3-1.8a51");
        }

        [Test]
        public void testExceptionMalFormer()
        {
            Calculator.stringMalFormerException ex = Assert.Throws<Calculator.stringMalFormerException>(lanceExceptionMalFormer);
            Assert.AreEqual("Erreur sur la string operation au niveau du caractères: 'a'", ex.Message);
        }
    }
}
