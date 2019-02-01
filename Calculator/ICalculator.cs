namespace Calculator
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

        /// <summary>
        /// Calculates the result of division of 2 numbers
        /// </summary>
        /// <param name="dividend">The number on the top</param>
        /// <param name="divisor">The number at the bottom</param>
        /// <returns>Result of the division dividend/divisor.</returns>
        double Divide(double dividend, double divisor);

        //double Accumulator { get; set; }

        /// <summary>
        /// Clears the content of the accumulated value.
        /// </summary>
        /// <returns>Has void type, so no return value.</returns>
        void Clear();

        /// <summary>
        /// Adds a number with the value of Accumulator
        /// </summary>
        /// <param name="addend">The value to add to Accumulator</param>
        /// <returns>The sum of addend and Accumulator</returns>
        double Add(double addend);

        /// <summary>
        /// Subtracts a number, subtractor, from the value of Accumulator
        /// </summary>
        /// <param name="subtractor">The value to subtract from Accumulator</param>
        /// <returns>The difference between subtractor and Accumulator</returns>
        double Subtract(double subtractor);

        /// <summary>
        /// Multiplies a number, multiplier, with the value of Accumulator
        /// </summary>
        /// <param name="multiplier">The value to multiply with Accumulator</param>
        /// <returns>The result of multiplication with multiplier and Accumulator</returns>
        double Multiply(double multiplier);

        /// <summary>
        /// Divides a number, divisor, with the value of Accumulator
        /// </summary>
        /// <param name="divisor">The value to divide with the Accumulator</param>
        /// <returns>Divisor divided with the value of Accumulator</returns>
        double Divide(double divisor);

        /// <summary>
        /// Raise value of Accumulator to the power of exp.
        /// </summary>
        /// <param name="exponent">The power to raise to</param>
        /// <returns>The power Accumulator^exp</returns>
        double Power(double exponent);
    }
}
