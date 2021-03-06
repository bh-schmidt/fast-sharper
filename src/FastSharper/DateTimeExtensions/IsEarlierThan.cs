﻿using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the <paramref name="source"/> is earlier than <paramref name="comparison"/>.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="comparison"></param>
        /// <returns>True if the <paramref name="source"/> value is smaller than the <paramref name="comparison"/> value.</returns>
        public static bool IsEarlierThan(this DateTime source, DateTime comparison) =>
            DateTime.Compare(source, comparison) < 0;
    }
}
