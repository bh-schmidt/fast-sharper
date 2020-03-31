using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the <paramref name="source"/> is between <paramref name="start"/> and <paramref name="end"/>.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns>True if the <paramref name="source"/> value is equals or greater than the <paramref name="start"/> value and equals or smaller than the <paramref name="end"/> value.</returns>
        public static bool IsInRange(this DateTime source, DateTime start, DateTime end) =>
            IsEqualsOrLaterThan(source, start) && IsEqualsOrEarlierThan(source, end);
    }
}
