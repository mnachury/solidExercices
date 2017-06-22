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
        public void CalculateASumFromNeg()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("-5+2.5");
            Check.That(result).IsEqualTo(-2.5);
        }
        [Test]
        public void CalculateAnotherSum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1.3+2+7");
            Check.That(result).IsEqualTo(10.3);
        }

        [Test]
        public void CalcPlusieurCalcul()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1.3+2+5");
            Check.That(result).IsEqualTo(8.3);
            result = calculator.Calculate("12/20");
            Check.That(result).IsEqualTo(0.6);
            Calculator.stringMalFormerException ex1 = Assert.Throws<Calculator.stringMalFormerException>(lanceExceptionMalFormer);
            Assert.AreEqual("Erreur sur la string operation au niveau du caractères: 'a'", ex1.Message);
            DivideByZeroException ex2 = Assert.Throws<DivideByZeroException>(lanceExceptionZero);
            Assert.AreEqual("Impossible de diviser par zero : (154,5/0)", ex2.Message);
            result = calculator.Calculate("6.6/3");
            Check.That(Math.Round(result, 1)).IsEqualTo(2.2);

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
            var result = calculator.Calculate("100+56.3-1.8x25");
            Check.That(result).IsEqualTo(3862.5);
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
            Assert.AreEqual("Impossible de diviser par zero : (154,5/0)", ex.Message);
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
