using System;
using System.Collections.Generic;
using System.Linq;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>Converts an array to its equivalent string representation that is encoded with base-64 digits.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string ToBase64String(this IEnumerable<byte> source)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            return Convert.ToBase64String(source.ToArray());
        }
    }
}
