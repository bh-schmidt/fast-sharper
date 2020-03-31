using System;

namespace FastSharper
{
    public static partial class FC
    {
        /// <summary>
        /// Converts the <paramref name="source"/> to <typeparamref name="TType"/>.
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="source"></param>
        /// <returns>Instance of <typeparamref name="TType"/> conversion of <paramref name="source"/>.</returns>
        public static TType To<TType>(this object source)
        {
            if (source.IsNull()) throw new ArgumentNullException(nameof(source));

            var conversion = Convert.ChangeType(source, typeof(TType));

            return conversion.CastTo<TType>();
        }
    }
}
