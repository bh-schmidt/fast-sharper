namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid sbyte.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to sbyte.</returns>
        public static bool CanConvertToSByte(this object source)
        {
            if (source is sbyte)
                return true;

            try
            {
                source.ToSByte();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
