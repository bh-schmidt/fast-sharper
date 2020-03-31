namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid byte.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to byte.</returns>
        public static bool CanConvertToByte(this object source)
        {
            if (source is byte)
                return true;

            try
            {
                source.ToByte();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
