using System;
using System.Collections.Generic;
using System.Linq;

namespace Ays.Extensions
{
    public static class IEnumerableExt
    {
        #region Public Methods

        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> collection, int batchSize)
        {
            W.ArgumentNotNull(collection, nameof(collection));
            W.ArgumentPositive(batchSize, nameof(batchSize));

            return collection
                .Select((item, index) => new { item, index })
                .GroupBy(i => i.index / batchSize)
                .Select(g => g.Select(i => i.item));
        }

        public static TSelected FirstOrDefaults<TSource, TSelected>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TSelected> selector)
        {
            W.ArgumentNotNull(source, nameof(source));
            W.ArgumentNotNull(predicate, nameof(predicate));
            W.ArgumentNotNull(selector, nameof(selector));

            return source
                .Where(predicate)
                .Select(selector)
                .FirstOrDefault();
        }

        #endregion Public Methods
    }
}