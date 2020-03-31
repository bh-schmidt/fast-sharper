using System;

namespace FastSharper
{
    public static partial class FC
    {
        /// <summary>
        /// Casts the <paramref name="source"/> to <typeparamref name="TType"/>.
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="source"></param>
        /// <returns>A <typeparamref name="TType"/> cast of <paramref name="source"/>.</returns>
        public static TType CastTo<TType>(this object source)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));

            return (TType)source;
        }
    }
}
