using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to an 8-bit unsigned integer, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to byte.</returns>
        /// <exception cref="FormatException">value is not in the property format for a System.Byte value.</exception>
        /// <exception cref="InvalidCastException">value does not implement System.IConvertible. -or- Conversion from value to the System.Byte type is not supported.</exception>
        /// <exception cref="OverflowException">value represents a number that is less than System.Byte.MinValue or greater than System.Byte.MaxValue.</exception>
        public static byte ToByte(this object source, IFormatProvider? provider = null) =>
            Convert.ToByte(source, provider);
    }
}
