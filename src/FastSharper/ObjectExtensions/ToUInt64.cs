﻿using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the value of the specified object to a 64-bit unsigned integer, using the specified culture-specific formatting information.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="provider"></param>
        /// <returns>Returns the conversion of <paramref name="source"/> to ulong.</returns>
        /// <exception cref="FormatException">value is not in an appropriate format.</exception>
        /// <exception cref="InvalidCastException">value does not implement the System.IConvertible interface. -or- The conversion is not supported.</exception>
        /// <exception cref="OverflowException">value represents a number that is less than System.UInt64.MinValue or greater than System.UInt64.MaxValue.</exception>
        public static ulong ToUInt64(this object source, IFormatProvider? provider = null) =>
            Convert.ToUInt64(source, provider);
    }
}
