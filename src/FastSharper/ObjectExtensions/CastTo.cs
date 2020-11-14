using System;
using System.Diagnostics.CodeAnalysis;

namespace FastSharper
{
    public static partial class FC
    {
        /// <summary>
        /// Casts the <paramref name="src"/> to <typeparamref name="TType"/>.
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="src"></param>
        /// <returns>A <typeparamref name="TType"/> cast of <paramref name="src"/>.</returns>
        public static TType CastTo<TType>([NotNullIfNotNull("src")] this object? src) => (TType)src!;
    }
}
