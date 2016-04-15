using System.Collections.Generic;

namespace Ays.Extensions
{
    public static class ICollectionExt
    {
        #region Public Methods

        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            W.ArgumentNotNull(collection, nameof(collection));
            W.ArgumentNotNull(items, nameof(items));

            if (collection is List<T>)
            {
                List<T> list = collection as List<T>;

                if (list.Count > 0)
                {
                    list.AddRange(items);
                }
            }
            else
            {
                foreach (T item in items)
                {
                    collection.Add(item);
                }
            }
        }

        #endregion Public Methods
    }
}