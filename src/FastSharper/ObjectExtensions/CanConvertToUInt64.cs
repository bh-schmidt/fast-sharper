namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid ulong.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to ulong.</returns>
        public static bool CanConvertToUInt64(this object source)
        {
            if (source is ulong)
                return true;

            try
            {
                source.ToUInt64();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
