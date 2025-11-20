using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Vertex
    {
        public string Label { get; set; }

        public List<Edge> Edges { get; set; }

        public Vertex(string label)
        {
            Label = label;
            Edges = new List<Edge>();
        }

        public void AddEdge(Edge e)
        {
            Edges.Add(e);
        }

        public void AddEdge(Vertex target, string label, int weight)
        {
            Edges.Add(new Edge(label, weight, this, target));
        }
    }
}
