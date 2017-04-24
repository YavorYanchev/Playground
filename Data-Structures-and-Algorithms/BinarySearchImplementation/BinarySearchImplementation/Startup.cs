using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchImplementation
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            //sorted collection
            var collection = new SortableCollection<int>(new[] { 1, 5, 12, 45, 376, 456, 567, 678, 789, 1634, 3647 });
            Console.WriteLine(collection.BinarySearch(376));
        }
    }
}
