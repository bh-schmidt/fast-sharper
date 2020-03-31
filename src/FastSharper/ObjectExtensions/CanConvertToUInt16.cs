namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid ushort.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to ushort.</returns>
        public static bool CanConvertToUInt16(this object source)
        {
            if (source is ushort)
                return true;

            try
            {
                source.ToUInt16();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
