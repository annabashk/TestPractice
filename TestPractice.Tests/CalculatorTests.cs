using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalTest()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(100, 200) == 300);
        }

        [Test]
        public void SubtractionTest()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(100, 30) == 70);
        }

        [Test]
        public void MiltiplicationTest()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(30, 4) == 120);
        }

        [Test]
        public void DivisionTest()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(100, 20) == 5);
        }

    }
}
