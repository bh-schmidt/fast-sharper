using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to a 16-bit signed integer, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to short.</returns>
        /// <exception cref="FormatException">value is not in an appropriate format for an System.Int16 type.</exception>
        /// <exception cref="InvalidCastException">value does not implement System.IConvertible.</exception>
        /// <exception cref="OverflowException">value represents a number that is less than System.Int16.MinValue or greater than System.Int16.MaxValue.</exception>
        public static short ToInt16(this object source, IFormatProvider? provider = null) =>
            Convert.ToInt16(source, provider);
    }
}
