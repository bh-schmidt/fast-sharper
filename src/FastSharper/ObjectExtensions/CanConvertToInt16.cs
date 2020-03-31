namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid short.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to short.</returns>
        public static bool CanConvertToInt16(this object source)
        {
            if (source is short)
                return true;

            try
            {
                source.ToInt16();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
