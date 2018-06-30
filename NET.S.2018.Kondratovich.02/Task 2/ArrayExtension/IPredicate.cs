using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    /// <summary>
    /// Interface, implement method IsMatch
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPredicate<T>
    {
        bool IsMatch(T item);
    }
}
