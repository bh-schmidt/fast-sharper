using System;
using System.Collections.Generic;
using System.Linq;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the sequence of both enumerables are equals.
        /// </summary>
        /// <typeparam name="TEnumerable"></typeparam>
        /// <param name="source"></param>
        /// <param name="comparison"></param>
        /// <returns>True if the <paramref name="source"/> and the <paramref name="comparison"/> contains the same values at same positions.</returns>
        /// <exception cref="OverflowException">The number of elements in <paramref name="source"/> or <paramref name="comparison"/> is larger than System.Int32.MaxValue.</exception>
        public static bool IsSequenceEquals<TEnumerable>(this IEnumerable<TEnumerable> source, IEnumerable<TEnumerable> comparison)
        {
            var sourceCount = source.Count();
            var comparationCount = comparison.Count();

            if (sourceCount != comparationCount)
                return false;

            if (sourceCount.IsZero())
                return true;

            try
            {
                return IsSequenceEquals(source.GetEnumerator(), comparison.GetEnumerator());
            }
            catch
            {
                return false;
            }
        }

        private static bool IsSequenceEquals<TEnumerable>(IEnumerator<TEnumerable> source, IEnumerator<TEnumerable> comparison)
        {
            while (source.MoveNext())
            {
                comparison.MoveNext();

                if (!Equals(source.Current, comparison.Current))
                    return false;
            }

            return true;
        }
    }
}
