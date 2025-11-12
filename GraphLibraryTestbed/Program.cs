using GraphLibrary;
using System.ComponentModel.Design;

namespace GraphLibraryTestbed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tree myTree = new Tree();

            //myTree.Print();


            Node root = new Node("C:/");
            

            Node users = root.AddChild(new Node("Users"));
            users.AddChild(new Node("Jesse"));
            users.AddChild(new Node("Tom"));
            users.AddChild(new Node("Alice"));
            Node programs = root.AddChild(new Node("Programs"));
            Node code = programs.AddChild(new Node("VSCode"));

            code.AddChild(new Node("bin"));

            PrintTree(root, 0);
        }
        
        static void PrintTree(Node root, int level)
        {
            // base case
            if (root == null)
            {
                return;
            }

            string line = "";

            for (int i = 0; i < level; i++)
            {
                line += "  ";
            }

            line += root.Value;

            Console.WriteLine(line);

            // recurse
            for (int i = 0; i < root.Children.Count; i++)
            {
                PrintTree(root.Children[i], level + 1);
            }
        }
    }
}
