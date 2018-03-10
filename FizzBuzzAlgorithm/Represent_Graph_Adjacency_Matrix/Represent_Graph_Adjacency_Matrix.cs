using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Represent_Graph_Adjacency_Matrix
{
    class Represent_Graph_Adjacency_Matrix
    {
        //Đỉnh đồ thị
        private int vertices;

        //Tạo 1 mảng 2 chiều
        private int[,] adjacency_Matrix;

        public Represent_Graph_Adjacency_Matrix(int v)
        {
            vertices = v;
            adjacency_Matrix = new int[vertices + 1, vertices +1];
        }
        public void makeEdge(int to,int from,int edge)
        {
            try
            {
                adjacency_Matrix[to,from] = edge;

            }
            catch (Exception index)
            {


                Console.WriteLine("The vertices does not exit" + index);
            }
        }

        public int getEdge(int to,int from)
        {
            try
            {
                return adjacency_Matrix[to, from];
            }
            catch (Exception index)
            {

                Console.WriteLine("The vertices does not exit" + index);
            }
            return -1;
        }

    }
}
