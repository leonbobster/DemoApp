using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void ShouldAddNumbers()
        {
            Calculator calc = new Calculator();
            int sum = calc.Add(2, 3);
            Assert.That(sum, Is.EqualTo(5));
        }

        [Test]
        public void ShouldMultNumbers()
        {
            Calculator calc = new Calculator();
            int sum = calc.Mult(2, 3);
            Assert.That(sum, Is.EqualTo(1));
        }
    }
}
