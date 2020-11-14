using System;
using System.Linq.Expressions;

namespace FastSharper
{
    public static partial class FC
    {
        /// <summary>
        /// Create a new expression that is the merge of the two validations.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second) => first.Compose(second, Expression.OrElse);
    }
}
