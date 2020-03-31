namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid double.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to double.</returns>
        public static bool CanConvertToDouble(this object source)
        {
            if (source is double)
                return true;

            try
            {
                source.ToDouble();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
