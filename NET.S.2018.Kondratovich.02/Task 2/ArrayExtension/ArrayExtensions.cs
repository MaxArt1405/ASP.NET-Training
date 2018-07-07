using System;
using System.Collections.Generic;

namespace ArrayExtensions
{
    public static class ArrayExtension
    {
        /// <summary>
        /// This method takes an array and filter it by criteria
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">source array</param>
        /// <param name="predicate">Filter method criteria</param>
        /// <returns></returns>
        public static T[] FilterNumbers<T>(this T[] source, IPredicate<T> predicate)
        {
            Valid(source, predicate);

            List<T> list = new List<T>();

            for (int i = 0; i < source.Length; i++)
            {
                if (predicate.IsMatch(source[i]))
                {
                    list.Add(source[i]);
                }
            }
            return list.ToArray();
        }
        /// <summary>
        /// Validation method
        /// </summary>
        /// <exception cref="ArgumentNullException">Throws when value of source or predicate is null.</exception>    
        /// <exception cref="ArgumentException">Throws when the length of source is zero.</exception>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">Source array</param>
        /// <param name="predicate">Filter method criteria</param>
        private static void Valid<T>(T[] source, IPredicate<T> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"The value of parameter{nameof(source)} can't be null");
            }
            if (predicate == null)
            {
                throw new ArgumentNullException($"The value of parameter{nameof(predicate)} can't be null");
            }
            if (source.Length == 0)
            {
                throw new ArgumentException($"The length of parametr {nameof(source)} can`t ne zero");
            }
        }
    }
}
