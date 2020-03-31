using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to an 8-bit signed integer, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to sbyte.</returns>
        /// <exception cref="FormatException">value is not in an appropriate format.</exception>
        /// <exception cref="InvalidCastException">value does not implement the System.IConvertible interface. -or- The conversion is not supported.</exception>
        /// <exception cref="OverflowException">value represents a number that is less than System.SByte.MinValue or greater than System.SByte.MaxValue.</exception>
        public static sbyte ToSByte(this object source, IFormatProvider? provider = null) =>
            Convert.ToSByte(source, provider);
    }
}
