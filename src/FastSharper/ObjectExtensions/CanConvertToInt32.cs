namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid int.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to int.</returns>
        public static bool CanConvertToInt32(this object source)
        {
            if (source is int)
                return true;

            try
            {
                source.ToInt32();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
