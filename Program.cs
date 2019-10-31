using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            int insertValue;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                insertValue = random.Next(100);
                Console.Write(insertValue + " ");
                tree.InsertNode(insertValue);
            }

            Console.WriteLine("\n\nPreorder traversal");
            tree.PreorderTraversal();

            Console.WriteLine("\n\n Inorder Traversal");
            tree.InorderTraversal();

            Console.WriteLine("\n\nPostorder Traversal");
            tree.PostorderTraversal();
            Console.WriteLine();
        }
    }
}
