using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the enum type contains the value provided.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="source"></param>
        /// <returns>True if the value is provided is a valid value.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> is null</exception>
        public static bool IsValid<TEnum>(this TEnum source) where TEnum : Enum
        {
            return Enum.IsDefined(source.GetType(), source);
        }
    }
}
