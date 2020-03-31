using System.Diagnostics.CodeAnalysis;

namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Indicates whether the string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the source is null, empty or white space.</returns>
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? source)
        {
            return string.IsNullOrWhiteSpace(source);
        }
    }
}
