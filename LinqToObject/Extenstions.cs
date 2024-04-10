using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    internal static class Extenstions
    {

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Func<T, bool> filter) // fun لان مش كويس اني اطبع حاجه ف ال Oop ده مش كويس ع مستوي ال
        {
            // List<T> list = new List<T>();
            foreach (T item in items)
            {
                if (filter(item))
                {
                    //list.Add(item);   
                    yield return item;
                }
            }
        }
        public static int MyCount<T>(this IEnumerable<T> items)//, Func<T, bool> filter) 
        {
            int count = 0;

            // List<T> list = new List<T>();
            foreach (T item in items)
            {
                count++;
            }
            return count;
        }

        // ليها لكن مش بالضروره ده يحصل override لكن ده حصل لان بالصدفه انا عامل fun ToString ال Subject لان ف كلاس name هنا بترجع ال
        //public static IEnumerable<string> Choose<T>(this IEnumerable<T> items)//, Func<T, bool> filter) // fun لان مش كويس اني اطبع حاجه ف ال Oop ده مش كويس ع مستوي ال
        //{
        //    foreach (T item in items)
        //    {
        //        yield return items.ToString();

        //    }

        //}
        public static IEnumerable<TResult> Choose<TSource, TResult>(this IEnumerable<TSource> items, Func<TSource, TResult> selector) 
        {
            foreach (TSource item in items)
            {
                yield return selector(item);

            }

        }
    }
}
