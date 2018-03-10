using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class Program
    {
        static int V = 9;
        int minDistance(int []dist, Boolean []sptSet)
        {
            int min = int.MaxValue, min_index = -1;
            for(int v = 0;v<V;v++)
            {
                if(sptSet[v]==false && dist[v]<=min)
                {
                    min = dist[v];
                    min_index = v;
                }
            }
            return min_index;
        }
        static void Main(string[] args)
        {
          
        }
    }
}
