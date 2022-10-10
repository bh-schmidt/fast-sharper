using System;
using System.Collections.Generic;
using System.Linq;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Returns a specified percentage of contiguous elements from the start of a sequence.
        /// If the percentage result turns into a floating point <seealso cref="Math.Round(double)"/> will be used to get the number of elements.
        /// </summary>
        /// <typeparam name="TEnumerable"></typeparam>
        /// <param name="src"></param>
        /// <param name="percentage"></param>
        /// <returns></returns>
        public static IEnumerable<TEnumerable> TakePercentage<TEnumerable>(this IEnumerable<TEnumerable> src, double percentage)
        {
            if (percentage > 100 || percentage <= 0)
                throw new ArgumentException("Percentage must be greater than 0 and small than 100.");

            var totalCount = src.Count();

            var takeDouble = (totalCount * percentage) / 100;
            var takeInt = Math.Round(takeDouble).To<int>();

            return src.Take(takeInt);
        }
    }
}
