﻿#if NET_4_6
using System.Collections.Generic;
using System.Linq;

namespace Unity.Tiny
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<TSource> NotNull<TSource>(this IEnumerable<TSource> source)
        {
            if (null == source)
            {
                throw new System.NullReferenceException("source");
            }

            if (typeof(TSource).IsValueType)
            {
                return source;
            }

            return source.Where(item => null != item);
        }
    }
}
#endif // NET_4_6
