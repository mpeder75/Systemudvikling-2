using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Diijkstra - A shortest Path Algorithm
// implementation of the Diijkstra Algorithm using
// an adjacency matrix. 
// TO BE STUDIED VERY CAREFULLY...
//
// Datamatikeruddannelsen i Vejle, Per Larsen

namespace Diijkstra
{
    class Program
    {
        public static void Main(String[] args)
        {
            Graph g = new Graph(7);

            g.Join(0, 1, 2);          // build the oriented Graph, fig.9.20
            g.Join(0, 3, 1);

            g.Join(1, 3, 3);
            g.Join(1, 4, 10);

            g.Join(2, 5, 5);
            g.Join(2, 0, 4);

            g.Join(3, 2, 2);
            g.Join(3, 5, 8);
            g.Join(3, 6, 4);
            g.Join(3, 4, 2);

            g.Join(4, 6, 6);

            g.Join(6, 5, 1);

            g.Prt_graph();

            g.Diijkstra(0);   // invoke the diijkstra method.      
            // finds all shortest paths from vertice #0
            // to any of the other vertices.

        }
    }


    public class Graph
    {
        private int[,] adj_weight;

        public Graph(int numEdges)
        {
            adj_weight = new int[numEdges, numEdges];
            for (int i = 0; i < numEdges; i++)
                for (int j = 0; j < numEdges; j++)
                    adj_weight[i, j] = -1;
        }

        public void Join(int node1, int node2, int w)
        {
            adj_weight[node1, node2] = w;
        }

        public void Remv(int node1, int node2)
        {
            adj_weight[node1, node2] = -1;
        }

        public int Adjacent(int node1, int node2)
        {
            return adj_weight[node1, node2];
        }

        public void Prt_graph()
        {
            int r, s;
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------");
            for (r = 0; r < adj_weight.GetLength(0); r++)
            {
                for (s = 0; s < adj_weight.GetLength(0); s++)
                    Console.Write(adj_weight[r, s] + "  ");
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------");
        }

        public void Diijkstra(int s)    // the parameter is the starting vertex
        {
            int v, w;
            int[,] table = new int[7, 3]; // the table in fig.9.21
            for (int i = 0; i < 7; i++)
                table[i, 1] = 1000;          // 1000 used for infinite value.
            // Maxint is better.
            table[s, 1] = 0;              // distance from s to s is of course 0
            for (; ; )
            {
                v = 0;
                int dist = 1000;
                bool f = false;
                for (int i = 0; i < 7; i++)    // find smallest UNKNOWN distance
                    if ((table[i, 1] < dist) && (table[i, 0] == 0))
                    {
                        v = i;
                        dist = table[i, 1];
                        f = true;
                    }

                Console.WriteLine("v=" + v);


                if (f == false)   // not any uNKNOWN distances so DONE...
                    break;

                table[v, 0] = 1;   // known set to be true (1 indicates true)
                for (w = 0; w < 7; w++)
                    if (table[w, 0] == 0)
                        if ((table[v, 1] + adj_weight[v, w] < table[w, 1]) && (adj_weight[v, w] > 0))
                        {
                            table[w, 1] = table[v, 1] + adj_weight[v, w];  // ashorter distance
                            table[w, 2] = v;                           // notice the path.
                        }


                for (int x = 0; x < 7; x++)      //printing for debugging purpose... 
                {
                    for (int y = 0; y < 3; y++)
                        Console.Write(table[x, y] + "  ");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }

    }
}

