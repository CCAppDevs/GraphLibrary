using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Edge
    {
        public string Label { get; set; }
        public int Weight { get; set; }
        public Vertex Source { get; set; }
        public Vertex Target { get; set; }

        public Edge(string label, int weight, Vertex source, Vertex target)
        {
            Label = label;
            Weight = weight;
            Source = source;
            Target = target;
        }
    }
}
