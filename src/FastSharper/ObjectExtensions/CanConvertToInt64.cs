namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid long.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to long.</returns>
        public static bool CanConvertToInt64(this object source)
        {
            if (source is long)
                return true;

            try
            {
                source.ToInt64();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
