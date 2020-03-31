using System;
using System.Text.RegularExpressions;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Indicates whether the string matches with the regex pattern.
        /// </summary>
        /// <param name="regexPattern"></param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="regexPattern"/> is null.</exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static bool IsMatch(this string source, string regexPattern)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (regexPattern is null)
                throw new ArgumentNullException(nameof(regexPattern));

            return Regex.IsMatch(source, regexPattern);
        }
    }
}
