using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the <paramref name="source"/> is the equals to <paramref name="comparison"/>.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="comparison"></param>
        /// <returns>True if the <paramref name="source"/> value is equals to the <paramref name="comparison"/> value.</returns>
        public static bool IsEqualsTo(this DateTime source, DateTime comparison) =>
            source == comparison;
    }
}
