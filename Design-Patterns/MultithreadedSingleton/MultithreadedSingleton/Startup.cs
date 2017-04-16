using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadedSingleton
{
    public class Startup
    {
        public static void Main()
        {
            var singleton = Singleton.Instance;
            //Console.WriteLine(singleton.ToString());
        }
    }
}
