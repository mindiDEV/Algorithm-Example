using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Represent_Graph_Adjacency_Matrix
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int ver, ed, count = 1, to = 0, from = 0;
            Represent_Graph_Adjacency_Matrix graph;
            try
            {
                Console.Write("Enter the number of vertices : ");
                ver = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number of edge : ");
                ed = Convert.ToInt32(Console.ReadLine());

                graph = new Represent_Graph_Adjacency_Matrix(ver);

                
                while (count<=ed)
                {
                    Console.Write("Enter the edge : <to> ");
                    to = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the edge : <from> ");
                    from = Convert.ToInt32(Console.ReadLine());

                    graph.makeEdge(to, from, 1);

                    count++;
                }
                Console.WriteLine("The adjacency matrix for the given graph is: ");
                Console.Write("  ");
                for (int i  = 1; i <= ver; i ++)
                {
                    Console.Write(i + " ");

                }
                Console.WriteLine();
                for (int i = 1; i <= ver; i++)
                {
                    Console.Write(i + " ");
                    for (int j = 1; j <= ver; j++)
                    {
                        Console.Write(graph.getEdge(i,j) + " ");

                    }
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Something went wrong " + e.Message);
            }
        }
    }
}
