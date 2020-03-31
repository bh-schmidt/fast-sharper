using System;
using System.Collections.Generic;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Concatenates the members of a collection, using the specified separator between each member.
        /// </summary>
        /// <typeparam name="TEnumerable"></typeparam>
        /// <param name="source"></param>
        /// <param name="separator"></param>
        /// <returns>A string of type <typeparamref name="TEnumerable"/> separated by <paramref name="separator"/>.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        public static string StringJoinBy<TEnumerable>(this IEnumerable<TEnumerable> source, char separator)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            return string.Join(separator, source);
        }
    }
}
