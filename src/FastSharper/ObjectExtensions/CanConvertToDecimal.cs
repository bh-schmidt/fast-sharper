namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid decimal.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to decimal.</returns>
        public static bool CanConvertToDecimal(this object source)
        {
            if (source is decimal)
                return true;

            try
            {
                source.ToDecimal();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
