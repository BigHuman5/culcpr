﻿using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class AdditionTest
    {
        [Test]
        public void Calcpr()
        {
            var calculator = new Calcpr.Addition();
            var actual = calculator.Calculate(9, 3);
            Assert.AreEqual(12, actual);
        }
    }
}
