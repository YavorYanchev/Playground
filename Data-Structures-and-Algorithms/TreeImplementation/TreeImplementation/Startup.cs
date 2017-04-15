using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var tree = new Tree<int>(1,new Tree<int>(234, new Tree<int>(321)),
                                        new Tree<int>(13),
                                 new Tree<int>(635));

            tree.TraverseDFSWithStack();
        }
    }
}
