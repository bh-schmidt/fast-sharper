using System;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the <paramref name="src"/> is a valid <typeparamref name="TEnum"/>.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="src"></param>
        /// <returns></returns>
        public static bool IsValidEnum<TEnum>(this object src) => Enum.IsDefined(typeof(TEnum), src);
    }
}
