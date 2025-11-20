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
        }
    }
}
