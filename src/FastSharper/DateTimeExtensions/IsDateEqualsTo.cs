using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the <paramref name="source"/> year, month and day are equal to the <paramref name="comparison"/> year, month and day.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="comparison"></param>
        /// <returns>True if the <paramref name="source"/> year, month and day are equal to the <paramref name="comparison"/> year, month and day.</returns>
        public static bool IsDateEqualsTo(this DateTime source, DateTime comparison) =>
            source.Date == comparison.Date;
    }
}
