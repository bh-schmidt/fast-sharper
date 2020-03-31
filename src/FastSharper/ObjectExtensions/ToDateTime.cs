using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to a System.DateTime object, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to DateTime.</returns>
        /// <exception cref="FormatException">value is not a valid date and time value.</exception>
        /// <exception cref="InvalidCastException">value does not implement the System.IConvertible interface. -or- The conversion is not supported.</exception>
        public static DateTime ToDateTime(this object source, IFormatProvider? provider = null) =>
            Convert.ToDateTime(source, provider);
    }
}
