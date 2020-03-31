using System;
using System.Collections.Generic;
using System.Linq;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if <paramref name="source"/> contains all the <paramref name="comparison"/> values
        /// </summary>
        /// <typeparam name="TEnumerable"></typeparam>
        /// <param name="source"></param>
        /// <param name="comparison"></param>
        /// <returns>
        /// True if <paramref name="comparison"/> is null or empty.
        /// False if <paramref name="source"/> is null or empty and the <paramref name="comparison"/> is not null or empty.
        /// True if all <paramref name="comparison"/> values are in <paramref name="source"/>.
        /// </returns>
        public static bool ContainsAll<TEnumerable>(this IEnumerable<TEnumerable> source, IEnumerable<TEnumerable> comparison)
        {
            if (comparison.IsNullOrEmpty())
                return true;

            if (source.IsNullOrEmpty())
                return false;

            return comparison.All(x => source.Contains(x));
        }
    }
}
