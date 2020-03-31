namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid float.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to single.</returns>
        public static bool CanConvertToSingle(this object source)
        {
            if (source is float)
                return true;

            try
            {
                source.ToSingle();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
