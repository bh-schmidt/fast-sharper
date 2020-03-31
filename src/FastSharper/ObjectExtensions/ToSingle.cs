using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to an single-precision floating-point number, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to single.</returns>
        /// <exception cref="FormatException">value is not in an appropriate format.</exception>
        /// <exception cref="InvalidCastException">value does not implement System.IConvertible.</exception>
        /// <exception cref="OverflowException">value represents a number that is less than System.Single.MinValue or greater than System.Single.MaxValue.</exception>
        public static float ToSingle(this object source, IFormatProvider? provider = null) =>
            Convert.ToSingle(source, provider);
    }
}
