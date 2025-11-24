using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Graph
    {
        private List<Vertex> Vertices { get; set; }
        private List<Edge> Edges { get; set; }


        public Graph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public void CreateNode(string label)
        {
            Vertices.Add(new Vertex(label));
        }

        public Vertex? FindNode(string label)
        {
            Vertex v = null;

            foreach (var vertex in Vertices)
            {
                if (vertex.Label == label)
                {
                    v = vertex;
                    break;
                }
            }

            return v;
        }

        public void AddEdge(string label, int weight, Vertex v1, Vertex v2)
        {
            Edges.AddRange(new List<Edge>() {
                new Edge(label, weight, v1, v2),
                new Edge(label, weight, v2, v1)
            });

            v1.AddEdge(v2, label, weight);
            v2.AddEdge(v1, label, weight);
        }

        public void AddEdge(string label, int weight, string label1, string label2)
        {
            Vertex? v1 = FindNode(label1);
            Vertex? v2 = FindNode(label2);

            // check for existence
            if (v1 == null || v2 == null)
            {
                throw new Exception("Vertex was not found");
            }

            Edges.AddRange(new List<Edge>() {
                new Edge(label, weight, v1, v2),
                new Edge(label, weight, v2, v1)
            });

            v1.AddEdge(v2, label, weight);
            v2.AddEdge(v1, label, weight);
        }

        public int[,] CreateAdjMatrix()
        {
            int[,] adjMatrix = new int[Vertices.Count, Vertices.Count];

            for (int x = 0; x < Vertices.Count; x++)
            {
                Vertex a = Vertices[x];

                for (int y = 0; y < Vertices.Count; y++)
                {
                    Vertex b = Vertices[y];

                    Edge edge = a.Edges.FirstOrDefault(e => e.Target == b);

                    if (edge != null)
                    {
                        adjMatrix[x, y] = edge.Weight;
                    }

                    
                }
            }

            return adjMatrix;
        }

        public void PrintGraph()
        {
            // need to get a 2d array of the adjacency matrix
            var adjMatrix = CreateAdjMatrix();

            Console.Write("            ");
            // print the labels across the top
            foreach (var vert in Vertices)
            {
                Console.Write($"{vert.Label.PadRight(12, ' ')}");
            }
            Console.WriteLine();

            // print the columns
            for (int x = 0; x < Vertices.Count; x++)
            {
                Console.Write($"{Vertices[x].Label.PadRight(12, ' ')}");

                for (int y = 0; y < Vertices.Count; y++)
                {
                    Console.Write($"{adjMatrix[x,y]}".PadRight(12, ' '));
                }

                Console.WriteLine();
            }
        }
    }
}

