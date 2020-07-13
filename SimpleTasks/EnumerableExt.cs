using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    public static class EnumerableExt
    {
        /// <summary>
        /// Объединяет список элементов в строку
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self">Список элементов</param>
        /// <param name="separator">Разделитель. По умолчанию ', '</param>
        /// <param name="toStringConverter">Функция для преобразования в строку. По умолчанию вызывает ToString()</param>
        /// <param name="prefix">То что будет писать перед последовательностью. По умолчанию пусто</param>
        /// <param name="postfix">То что будет писать после последовательности. По умолчанию пусто</param>
        /// <returns></returns>
        public static string JoinToString<T>(this IEnumerable<T> self, 
            string separator = ", ", 
            Func<T, string> toStringConverter = null, 
            string prefix = null, 
            string postfix = null)
        {
            if (self == null)
                throw new ArgumentNullException(nameof(self));

            if (toStringConverter == null)
                toStringConverter = t => t?.ToString();

            prefix = (prefix ?? string.Empty);
            postfix = (postfix ?? string.Empty);
            
            return prefix + string.Join(separator, self.Select(toStringConverter)) + postfix;
        }
    }
}
