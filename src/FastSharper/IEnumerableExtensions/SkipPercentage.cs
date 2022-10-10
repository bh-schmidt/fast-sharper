using System;
using System.Collections.Generic;
using System.Linq;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Bypasses a specified percentage of elements in a sequence and then returns the remaining elements.
        /// If the percentage result turns into a floating point <seealso cref="Math.Round(double)"/> will be used to get the number of bypasses.
        /// </summary>
        /// <typeparam name="TEnumerable"></typeparam>
        /// <param name="src"></param>
        /// <param name="percentage"></param>
        /// <returns></returns>
        public static IEnumerable<TEnumerable> SkipPercentage<TEnumerable>(this IEnumerable<TEnumerable> src, double percentage)
        {
            if (percentage > 100 || percentage <= 0)
                throw new ArgumentException("Percentage must be greater than 0 and small than 100.");

            var totalCount = src.Count();

            var takeDouble = (totalCount * percentage) / 100;
            var takeInt = Math.Round(takeDouble).To<int>();

            return src.Skip(takeInt);
        }
    }
}
