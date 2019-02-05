using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    
    //Testing auto build
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

        [Test]
        public void Power_0Power0_Returns1()
        {
            var powerRes = _uutCalculator.Power(0, 0);
            Assert.That(powerRes, Is.EqualTo(1));
        }



        #endregion
        #region Divide Tests
        [Test]
        public void Divide_Divide2By0_ExceptionThrown()
        {
            Assert.That(() => _uutCalculator.Divide(2.0, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(0, 2, 0)]
        [TestCase(4, 2, 2)]
        [TestCase(1, 3, 0.33)]
        [TestCase(5, 5, 1)]
        public void Divide_DivisionIntegers_ResultsAreRight(double dividend, double divisor, double result)
        {
            var divideResult = _uutCalculator.Divide(dividend, divisor);
            Assert.That(divideResult, Is.EqualTo(divideResult).Within(0.1));
        }
        #endregion
        #region Accumulator Tests
        [Test]
        public void Add_Add2And2()
        {
            _uutCalculator.Add(2, 2);
            Assert.That(_uutCalculator.Accumulator.Equals(4));
        }

        [TestCase(0, 2, 2)]
        [TestCase(4, 2, 6)]
        [TestCase(1, 3, 4)]
        [TestCase(5, 5, 10)]
        public void Add_AddIntegers_resultAreRight(double a, double b, double result)
        {
            _uutCalculator.Add(a, b);
            Assert.That(_uutCalculator.Accumulator.Equals(result));
        }

        [TestCase(0, 2, -2)]
        [TestCase(4, 2, 2)]
        [TestCase(1, 3, -2)]
        [TestCase(5, 5, 0)]
        public void Subtract_SubtractIntegers_resultAreRight(double a, double b, double result)
        {
            _uutCalculator.Subtract(a, b);
            Assert.That(_uutCalculator.Accumulator.Equals(result));
        }
        
        [Test]
        public void Accumalator_SubtractIntegersFromAccumaltor_ResultsAccumalated()
        {
            _uutCalculator.Subtract(4);
            _uutCalculator.Subtract(5);
            Assert.That(_uutCalculator.Accumulator.Equals(-9));
        }

        [Test]
        public void Accumalator_Clear_AccumalatorIs0()
        {
            _uutCalculator.Subtract(4);
            _uutCalculator.Subtract(5);
            _uutCalculator.Clear();
            Assert.That(_uutCalculator.Accumulator.Equals(0));
        }


        #endregion
    }
}
