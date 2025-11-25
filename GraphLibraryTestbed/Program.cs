using GraphLibrary;
using System.ComponentModel.Design;

namespace GraphLibraryTestbed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Relationships (a is adjacent to b)
            // olympia is adjacent to tenino
            // olympia is adjacent to centralia
            // olympia is adjacent to tacoma
            // tacoma is adjacent to tenino
            // tacoma is adjacent to seattle
            // centralia is adjacent to portland


            Graph map = new Graph();
            map.CreateNode("Olympia");
            map.CreateNode("Lacey");
            map.CreateNode("Tumwater");
            map.CreateNode("Centralia");
            map.CreateNode("Tenino");
            map.CreateNode("Tacoma");
            map.CreateNode("Seattle");
            map.CreateNode("Portland");

            // olympia
            map.AddEdge(1, "Olympia", "Lacey");
            map.AddEdge(1, "Olympia", "Tumwater");
            map.AddEdge(2, "Olympia", "Tenino");
            map.AddEdge(3, "Olympia", "Centralia");
            map.AddEdge(3, "Olympia", "Tacoma");
            map.AddEdge(5, "Olympia", "Seattle");
            map.AddEdge(5, "Olympia", "Portland");

            // lacey
            map.AddEdge(1, "Lacey", "Tumwater");
            map.AddEdge(2, "Lacey", "Tenino");
            map.AddEdge(3, "Lacey", "Centralia");
            map.AddEdge(3, "Lacey", "Tacoma");
            map.AddEdge(4, "Lacey", "Seattle");
            map.AddEdge(6, "Lacey", "Portland");

            // tumwater
            map.AddEdge(2, "Tumwater", "Tenino");
            map.AddEdge(3, "Tumwater", "Centralia");
            map.AddEdge(4, "Tumwater", "Tacoma");
            map.AddEdge(6, "Tumwater", "Seattle");
            map.AddEdge(4, "Tumwater", "Portland");

            // tenino
            map.AddEdge(1, "Tenino", "Centralia");
            map.AddEdge(4, "Tenino", "Tacoma");
            map.AddEdge(5, "Tenino", "Seattle");
            map.AddEdge(4, "Tenino", "Portland");

            // Centralia
            map.AddEdge(6, "Centralia", "Tacoma");
            map.AddEdge(8, "Centralia", "Seattle");
            map.AddEdge(2, "Centralia", "Portland");

            // Tacoma
            map.AddEdge(2, "Tacoma", "Seattle");
            map.AddEdge(8, "Tacoma", "Portland");

            // Seattle
            map.AddEdge(10, "Seattle", "Portland");

            map.PrintGraph();
            //Console.WriteLine($"{portland.Label} connects to {portland.Edges[0].Target.Label}");
        }
    }
}
