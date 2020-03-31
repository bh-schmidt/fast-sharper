namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid char.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to char.</returns>
        public static bool CanConvertToChar(this object source)
        {
            if (source is char)
                return true;

            try
            {
                source.ToChar();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
