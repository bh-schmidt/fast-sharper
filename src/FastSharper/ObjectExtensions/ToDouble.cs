using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to an double-precision floating-point number, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to double.</returns>
        /// <exception cref="FormatException">value is not in an appropriate format for a System.Double type.</exception>
        /// <exception cref="InvalidCastException">value does not implement the System.IConvertible interface.</exception>
        /// <exception cref="OverflowException">value represents a number that is less than System.Double.MinValue or greater than System.Double.MaxValue.</exception>
        public static double ToDouble(this object source, IFormatProvider? provider = null) =>
            Convert.ToDouble(source, provider);
    }
}
