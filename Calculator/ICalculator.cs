using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_Calculator
{
    public interface ICalculator
    {
        /// <summary>
        /// Adds two number together: a + b
        /// </summary>
        /// <param name="a">The left hand of the addition</param>
        /// <param name="b">The right hand of the addition</param>
        /// <returns>The sum of a and b</returns>
        double Add(double a, double b);

        /// <summary>
        /// Subtracts two numbers: a - b
        /// </summary>
        /// <param name="a">The left hand of the subtraction</param>
        /// <param name="b">The right hand of the subtraction</param>
        /// <returns>The difference between a and b</returns>
        double Subtract(double a, double b);

        /// <summary>
        /// Multiplies two numbers: a * b
        /// </summary>
        /// <param name="a">The left hand of the multiplication</param>
        /// <param name="b">The right hand of the multiplication</param>
        /// <returns>The product of a and b</returns>
        double Multiply(double a, double b);

        /// <summary>
        /// Raise x to the power of exp: x^exp
        /// </summary>
        /// <param name="x">The number to raise</param>
        /// <param name="exp">The power to raise to</param>
        /// <returns>The power x^exp</returns>
        double Power(double x, double exp);
    }
}
