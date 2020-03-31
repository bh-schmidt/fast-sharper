using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to an equivalent decimal number, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to decimal.</returns>
        /// <exception cref="FormatException">value is not in an appropriate format for a System.Decimal type.</exception>
        /// <exception cref="InvalidCastException">value does not implement the System.IConvertible interface. -or- The conversion is not supported.</exception>
        /// <exception cref="OverflowException">value represents a number that is less than System.Decimal.MinValue or greater than System.Decimal.MaxValue.</exception>
        public static decimal ToDecimal(this object source, IFormatProvider? provider = null) =>
            Convert.ToDecimal(source, provider);
    }
}
