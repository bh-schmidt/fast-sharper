using System;

namespace FastSharper
{
    public static partial class FC
    {
        /// <summary>
        /// Converts the <paramref name="source"/> to <typeparamref name="TValue"/>.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source"></param>
        /// <returns>Instance of <typeparamref name="TValue"/> conversion of <paramref name="source"/>.</returns>
        public static TValue To<TValue>(this object source)
        {
            if (typeof(Enum).IsAssignableFrom(typeof(TValue)))
                return (TValue)Enum.ToObject(typeof(TValue), source);

            var conversion = Convert.ChangeType(source, typeof(TValue));
            return conversion.CastTo<TValue>();
        }
    }
}
