namespace FastSharper
{
    public static partial class FC
    {
        public static bool CanConvertTo<TType>(this object source)
        {
            if (source is TType)
                return true;

            try
            {
                source.To<TType>();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
