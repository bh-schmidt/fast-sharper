namespace FastSharper
{
    public static partial class FS
    {
        /// <summary>
        /// Checks if the value is a valid boolean.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>True if the <paramref name="source"/> can be converted to boolean.</returns>
        public static bool CanConvertToBoolean(this object source)
        {
            if (source is bool)
                return true;

            try
            {
                source.ToBoolean();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
