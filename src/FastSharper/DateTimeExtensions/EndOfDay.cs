using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Returns the last Tick of the <paramref name="source"/> day.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static DateTime EndOfDay(this DateTime source) => source.Date.AddTicks(TimeSpan.TicksPerDay - 1);
    }
}
