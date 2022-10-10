using System.Diagnostics.CodeAnalysis;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is not null.
        /// </summary>
        /// <param name="src"></param>
        /// <returns>True if the <paramref name="src"/> is not null.</returns>
        public static bool HasValue([NotNullWhen(true)] this object? src) => !src.IsNull();
    }
}
