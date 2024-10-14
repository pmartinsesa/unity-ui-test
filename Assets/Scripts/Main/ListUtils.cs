using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts.Main
{
    public static class ListUtils
    {
        public static IEnumerable<T> RandomizeList<T>(this IEnumerable<T> list, int seed)
        {
            var rand = new Random(seed);
            return list.OrderBy(a => rand.Next(list.Count()));
        }
    }
}
