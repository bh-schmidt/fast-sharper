using System;
using System.Collections.Generic;
using System.Linq;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if all <paramref name="source"/> values are in <paramref name="comparison"/> vice-versa.
        /// </summary>
        /// <typeparam name="TEnumerable"></typeparam>
        /// <param name="source"></param>
        /// <param name="comparison"></param>
        /// <returns>
        /// False if the enumerable counts are different.
        /// True if the intersect count is the same as the source count.
        /// </returns>
        /// <exception cref="OverflowException">The number of elements in <paramref name="source"/> or <paramref name="comparison"/> is larger than <see cref="Int32.MaxValue"/>.</exception>
        public static bool IsEqualsTo<TEnumerable>(this IEnumerable<TEnumerable> source, IEnumerable<TEnumerable> comparison)
        {
            var sourceCount = source.Count();
            var comparationCount = comparison.Count();

            if (sourceCount != comparationCount)
                return false;

            var intersectCount = source.Intersect(comparison).Count();

            return intersectCount == sourceCount;
        }
    }
}
