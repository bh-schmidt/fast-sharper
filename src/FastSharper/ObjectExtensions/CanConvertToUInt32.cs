namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid uint.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to uint.</returns>
        public static bool CanConvertToUInt32(this object source)
        {
            if (source is uint)
                return true;

            try
            {
                source.ToUInt32();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
