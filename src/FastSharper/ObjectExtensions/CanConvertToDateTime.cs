using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid DateTime.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to DateTime.</returns>
        public static bool CanConvertToDateTime(this object source)
        {
            if (source is DateTime)
                return true;

            try
            {
                source.ToDateTime();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
