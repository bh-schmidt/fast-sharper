using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Splits the <paramref name="source"/> into an array of substrings at the positions defined by a regular expression pattern.
        /// </summary>
        /// <param name="regexPattern"></param>
        /// <returns>An array of substrings that were splitted by the expression pattern.</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="regexPattern"/> is null.</exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static IEnumerable<string> SplitWithRegex(this string source, string regexPattern)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (regexPattern is null)
                throw new ArgumentNullException(nameof(regexPattern));

            return Regex.Split(source, regexPattern);
        }
    }
}
