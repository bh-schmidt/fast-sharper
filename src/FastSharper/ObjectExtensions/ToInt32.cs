using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to a 32-bit signed integer, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to int.</returns>
        /// <exception cref="FormatException">value is not in an appropriate format.</exception>
        /// <exception cref="InvalidCastException">value does not implement System.IConvertible.</exception>
        /// <exception cref="OverflowException">value represents a number that is less than System.Int32.MinValue or greater than System.Int32.MaxValue.</exception>
        public static int ToInt32(this object source, IFormatProvider? provider = null) =>
            Convert.ToInt32(source, provider);
    }
}
