using System;
using System.Text.RegularExpressions;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string.
        /// </summary>
        /// <param name="regexPattern"></param>
        /// <param name="replacement"></param>
        /// <returns>The string that were replaced the <paramref name="regexPattern"/> match by the <paramref name="replacement"/>.</returns>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="source"/>, <paramref name="regexPattern"/> or <paramref name="replacement"/> is null.</exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static string ReplaceWithRegex(this string source, string regexPattern, string replacement)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (regexPattern is null)
                throw new ArgumentNullException(nameof(regexPattern));

            if (replacement is null)
                throw new ArgumentNullException(nameof(replacement));

            return Regex.Replace(source, regexPattern, replacement);
        }
    }
}
