using System.Collections.Generic;
using System.Linq;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the IEnumerable is empty.
        /// </summary>
        /// <typeparam name="TEnumerable"></typeparam>
        /// <param name="source"></param>
        /// <returns>
        /// True if the IEnumerable is empty.
        /// </returns>
        public static bool IsEmpty<TEnumerable>(this IEnumerable<TEnumerable> source)
        {
            return !source.Any();
        }
    }
}
