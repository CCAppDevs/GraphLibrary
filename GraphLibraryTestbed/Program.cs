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
            map.CreateNode("Rochester");

            map.AddEdge("distance", 1, "Olympia", "Lacey");

            //Console.WriteLine($"{portland.Label} connects to {portland.Edges[0].Target.Label}");
        }
    }
}
