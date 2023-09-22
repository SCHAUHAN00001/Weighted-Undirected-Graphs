using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighted_Undirected_Graphs
{
    internal class Program
    {
        class Graphs
        {
            int vertices;
            int[,] adjMat;

            public Graphs(int n)
            {
                vertices = n;
                adjMat = new int[n, n];
            }

            public void insertEdge(int u, int v, int x)
            {
                adjMat[u, v] = x;
            }

            public void removeEdge(int u, int v)
            {
                adjMat[u, v] = 0;
            }

            public bool existEdge(int u, int v)
            {
                return adjMat[u, v] != 0;
            }

            public int vertexCount()
            {
                return vertices;
            }

            public int edgeCount()
            {
                int count = 0;
                for (int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                        if (adjMat[i, j] != 0)
                            count = count + 1;
                }
                return count;
            }

            public void edges()
            {
                Console.WriteLine("Edges:");
                for (int i = 0; i < vertices; i++)
                    for (int j = 0; j < vertices; j++)
                        if (adjMat[i, j] != 0)
                            Console.WriteLine(i + "--" + j);
            }

            public int outdegree(int v)
            {
                int count = 0;
                for (int j = 0; j < vertices; j++)
                    if (adjMat[v, j] != 0)
                        count = count + 1;
                return count;
            }

            public int indegree(int v)
            {
                int count = 0;
                for (int i = 0; i < vertices; i++)
                    if (adjMat[i, v] != 0)
                        count = count + 1;
                return count;
            }

            public void display()
            {
                for (int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                        Console.Write(adjMat[i, j] + "\t");
                    Console.WriteLine();
                }
            }

            static void Main(string[] args)
            {
                Graphs g = new Graphs(4);
                Console.WriteLine("Graphs Adjacency Matrix:");
                g.display();
                Console.WriteLine("Vertices: " + g.vertexCount());
                Console.WriteLine("Edges Count: " + g.edgeCount());
                g.insertEdge(0, 1, 26);
                g.insertEdge(0, 2, 16);
                g.insertEdge(1, 0, 26);
                g.insertEdge(1, 2, 12);
                g.insertEdge(2, 0, 16);
                g.insertEdge(2, 1, 12);
                g.insertEdge(2, 3, 8);
                g.insertEdge(3, 2, 8);
                Console.WriteLine("Graphs Adjacency Matrix:");
                g.display();
                Console.WriteLine("Vertices: " + g.vertexCount());
                Console.WriteLine("Edges Count: " + g.edgeCount());
                g.edges();
                Console.WriteLine("Edge between 1--3: " + g.existEdge(1, 3));
                Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));
                Console.WriteLine("Degree of Vertex 2: " + g.indegree(2));
                Console.WriteLine("Graphs Adjacency Matrix:");
                g.display();
                g.removeEdge(1, 2);
                Console.WriteLine("Graphs Adjacency Matrix:");
                g.display();
                Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));
                Console.ReadKey();
            }
        }
    }
}

