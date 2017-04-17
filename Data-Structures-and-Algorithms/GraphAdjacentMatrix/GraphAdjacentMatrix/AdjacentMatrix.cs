using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAdjacentMatrix
{
    public class AdjacentMatrix
    {
        public static void Main(string[] args)
        {
            int nodes = int.Parse(Console.ReadLine());

            var graph = new int[nodes, nodes];

            for (int i = 0; i < nodes; i++)
            {
                string[] connections = Console.ReadLine().Split(' ');
                foreach (var connection in connections)
                {
                    graph[i, int.Parse(connection)] = 1;
                }
            }

            for (int i = 0; i < nodes; i++)
            {
                for (int j = 0; j < nodes; j++)
                {
                    Console.Write(graph[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
