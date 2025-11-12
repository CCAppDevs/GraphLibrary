using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Node
    {
        // what the node represents
        public string Value { get; set; }
        public List<Node> Children { get; set; }

        public Node(string value)
        {
            Value = value;
            Children = new List<Node>();
        }

        public Node AddChild(Node node)
        {
            Node obj = node;
            Children.Add(node);
            return obj;
        }
    }
}
