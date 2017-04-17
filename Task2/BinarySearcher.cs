using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BinarySearcher<T>
    {
        public IComparer<T> Comparep { get; }

        /// <summary>
        /// Initialise new BinarySearcher object
        /// </summary>
        /// <param name="comparer"></param>
        public BinarySearcher(IComparer<T> comparer)
        {
            if (comparer == null) throw new ArgumentNullException(nameof(comparer));
            Comparep = comparer;
        }

        /// <summary>
        /// Find element
        /// </summary>
        /// <param name="array">Array of elements</param>
        /// <param name="element">Element for search</param>
        /// <returns>Element</returns>
        public int? BinarySearch(T[] array, T element)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if ((array.Length == 0) || (Comparep.Compare(element, array[0]) < 0) || (Comparep.Compare(element, array[array.Length-1]) > 0))
                return null;

            int first = 0, last = array.Length;
            while (first < last)
            {
                int mid = first + (last - first) / 2;
                if (Comparep.Compare(element, array[mid]) <= 0)
                    last = mid;
                else
                    first = mid + 1;
            }
            if (Comparep.Compare(element, array[last]) == 0) return last;
            else return null;
        }
    }
}
