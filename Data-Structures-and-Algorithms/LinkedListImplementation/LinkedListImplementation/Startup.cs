using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var myLinkedList = new MyLinkedList<int>();
            myLinkedList.AddAtLast(12);
            myLinkedList.AddAtLast(35);
            myLinkedList.AddAtLast(47);
            myLinkedList.AddAtLast(38);

            myLinkedList.PrintAllNodes();
            Console.WriteLine();
            Console.WriteLine(string.Format("Count:{0}",myLinkedList.Count));
        }
    }
}
