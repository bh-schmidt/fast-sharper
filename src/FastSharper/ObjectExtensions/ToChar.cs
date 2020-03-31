using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to its equivalent Unicode character, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to char.</returns>
        /// <exception cref="FormatException">value is a null string.</exception>
        /// <exception cref="InvalidCastException">value does not implement the System.IConvertible interface. -or- The conversion of value to a System.Char is not supported.</exception>
        /// <exception cref="OverflowException">value is less than System.Char.MinValue or greater than System.Char.MaxValue.</exception>
        public static char ToChar(this object source, IFormatProvider? provider = null) =>
            Convert.ToChar(source, provider);
    }
}
