using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the IEnumerable is null or empty.
        /// </summary>
        /// <typeparam name="TEnumerable"></typeparam>
        /// <param name="source"></param>
        /// <returns>
        /// True if the <paramref name="source"/> is null or empty.
        /// </returns>
        public static bool IsNullOrEmpty<TEnumerable>([NotNullWhen(false)] this IEnumerable<TEnumerable>? source)
        {
            return source is null || !source.Any();
        }
    }
}
