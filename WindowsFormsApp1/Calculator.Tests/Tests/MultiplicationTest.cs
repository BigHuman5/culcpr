﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests.Tests
{
    [TestFixture]
    public class MultiplicationTest
    {
        [Test]
        public void Calcpr()
        {
            var calculator = new Calcpr.Multiplication();
            var actual = calculator.Calculate(9, 3);
            Assert.AreEqual(27, actual);
        }
    }
}