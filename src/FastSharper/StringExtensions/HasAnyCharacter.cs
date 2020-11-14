using System.Diagnostics.CodeAnalysis;

namespace FastSharper.StringExtensions
{
    public static partial class FC
    {
        /// <summary>
        /// Checks if the string has any char.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool HasAnyChar([NotNullWhen(true)] this string? source) => !source.IsNullOrEmpty();
    }
}
