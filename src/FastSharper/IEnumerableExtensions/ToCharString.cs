using System;
using System.Collections.Generic;
using System.Linq;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Converts the IEnumerable<char> to the specific string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>A string based in the <see cref="IEnumerable{char}"></see>.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string ToCharString(this IEnumerable<char> source)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            return new string(source.ToArray());
        }
    }
}
