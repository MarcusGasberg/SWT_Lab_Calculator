﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        #region Setup

        private Calculator _uutCalculator;

        [SetUp]
        public void Setup()
        {
            _uutCalculator = new Calculator();
        } 
        #endregion
        #region Add Tests
        [Test]
        public void Add_Add2And2_Returns4()
        {
            var sum = _uutCalculator.Add(2, 2);
            Assert.That(sum, Is.EqualTo(4));
        }

        [Test]
        public void Add_Add2AndMinus2_Returns0()
        {
            var sum = _uutCalculator.Add(2, -2);
            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void Add_AddMinus2AndMinus2_ReturnsMinus4()
        {
            var sum = _uutCalculator.Add(-2, -2);
            Assert.That(sum, Is.EqualTo(-4));
        }

        [Test]
        public void Add_Add0And0_Returns0()
        {
            var sum = _uutCalculator.Add(0, 0);
            Assert.That(sum, Is.EqualTo(0));
        }
        #endregion
        #region Subtract Tests
        [Test]
        public void Sub_Sub2from2_Returns0()
        {
            var res = _uutCalculator.Subtract(2, 2);
            Assert.That(res, Is.EqualTo(0));
        }

        [Test]
        public void Sub_SubMinus2from2_Returns4()
        {
            var res = _uutCalculator.Subtract(2, -2);
            Assert.That(res, Is.EqualTo(4));
        }

        [Test]
        public void Sub_SubMinus2fromMinus2_Returns0()
        {
            var res = _uutCalculator.Subtract(-2, -2);
            Assert.That(res, Is.EqualTo(0));
        }

        [Test]
        public void Sub_SubMinus2from0_Returns2()
        {
            var res = _uutCalculator.Subtract(0, -2);
            Assert.That(res, Is.EqualTo(2));
        }

        #endregion
        #region Multiply Tests

        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, -4)]
        [TestCase(-2, -2, 4)]
        [TestCase(2, 0, 0)]
        public void Multiply_MultiplyPositiveNegativeIntegers_SignIsRight(double lh, double rh, double result)
        {
            var product = _uutCalculator.Multiply(lh, rh);
            Assert.That(product,Is.EqualTo(result).Within(0.01));
        }

        [TestCase(0.5,2,1.0)]
        [TestCase(2.25,2.25,5.0625)]
        [TestCase(2.2,2,4.4)]
        [TestCase(0.5,0.2,0.1)]
        public void Multiply_MultiplyDecimalNumbers_ResultAreRight(double lh, double rh, double result)
        {
            var product = _uutCalculator.Multiply(lh, rh);
            Assert.That(product, Is.EqualTo(result).Within(0.01));
        }
        #endregion
        #region Power Tests

        [TestCase(2,2,4)]
        [TestCase(2,0,1)]
        [TestCase(2,1,2)]
        [TestCase(2,-1,0.5)]
        public void Power_IntegerToPowerOfInteger_ResultsAreRight(double a, double x, double result)
        {
            var powerRes = _uutCalculator.Power(a, x);
            Assert.That(powerRes,Is.EqualTo(result));
        }

        [TestCase(0.5, 2, 0.25)]
        [TestCase(0.5, 0, 1)]
        [TestCase(0.2, 1, 0.2)]
        public void Power_DecimalsToPowerOfInteger_ResultsAreRight(double a, double x, double result)
        {
            var powerRes = _uutCalculator.Power(a, x);
            Assert.That(powerRes, Is.EqualTo(result).Within(0.1));
        }


        [TestCase(4.0, 0.5, 2)]
        [TestCase(27, 0.33, 3)]
        [TestCase(0.2, 0.0, 1)]
        public void Power_IntegersToPowerOfDecimal_ResultsAreRight(double a, double x, double result)
        {
            var powerRes = _uutCalculator.Power(a, x);
            Assert.That(powerRes, Is.EqualTo(result).Within(0.1));
        }



        #endregion
    }
}
