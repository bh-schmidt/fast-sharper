using System;
using System.Text.RegularExpressions;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the <paramref name="source"/> has any number.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the string contains any number.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static bool ContainsAnyNumber(this string source)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            return Regex.IsMatch(source, @"[\d]");
        }
    }
}
