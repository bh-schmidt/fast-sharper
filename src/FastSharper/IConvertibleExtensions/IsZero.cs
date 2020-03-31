using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Check if the source is zero.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>When the source is zero returns true.</returns>
        public static bool IsZero(this IConvertible source)
        {
            try
            {
                return CheckIfIsZero(source);
            }
            catch
            {
                return false;
            }
        }

        private static bool CheckIfIsZero(IConvertible source)
        {
            if (source is bool boolValue)
                return !boolValue;

            if (source is char charValue)
                return charValue == '0';

            if (source is DateTime)
                return false;

            return source.ToDecimal() == 0;
        }
    }
}
