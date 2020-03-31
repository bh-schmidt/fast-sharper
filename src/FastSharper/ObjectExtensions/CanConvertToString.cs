namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is an instance of a string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to string.</returns>
        public static bool CanConvertToString(this object source)
        {
            return source is string;
        }
    }
}
