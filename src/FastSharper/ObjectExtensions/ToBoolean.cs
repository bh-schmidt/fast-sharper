using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to an equivalent Boolean, using the specified culture-specific formating information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to boolean.</returns>
        /// <exception cref="FormatException">value is a string that does not equal System.Boolean.TrueString or System.Boolean.FalseString.</exception>
        /// <exception cref="InvalidCastException">value does not implement the System.IConvertible interface. -or- The conversion of value to a System.Boolean is not supported.</exception>
        public static bool ToBoolean(this object source, IFormatProvider? provider = null) =>
            Convert.ToBoolean(source, provider);
    }
}
