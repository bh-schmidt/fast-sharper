using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the <paramref name="source"/> is equals or earlier than <paramref name="comparison"/>.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="comparison"></param>
        /// <returns>True if the <paramref name="source"/> value is equals or earlier than the <paramref name="comparison"/> value.</returns>
        public static bool IsEqualsOrEarlierThan(this DateTime source, DateTime comparison) =>
            DateTime.Compare(source, comparison) <= 0;
    }
}
