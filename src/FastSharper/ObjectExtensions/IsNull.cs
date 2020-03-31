using System.Diagnostics.CodeAnalysis;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is null.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> is null.</returns>
        public static bool IsNull([NotNullWhen(false)] this object? source)
        {
            return source is null;
        }
    }
}
