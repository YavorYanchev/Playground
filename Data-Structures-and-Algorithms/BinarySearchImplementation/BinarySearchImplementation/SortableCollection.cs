using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchImplementation
{
    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }


        public bool BinarySearch(T item)
        {
            var left = 0;
            var right = this.items.Count - 1;
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (this.items[mid].CompareTo(item) < 0)
                {
                    left = mid + 1;
                }
                else if (this.items[mid].CompareTo(item) > 0)
                {
                    right = mid - 1;
                }
                else if (this.items[mid].CompareTo(item) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
