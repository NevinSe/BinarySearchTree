using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            Tree<int> binaryTree = new Tree<int>();
            binaryTree.AddNode(10);
            binaryTree.AddNode(20);
            binaryTree.AddNode(5);
            binaryTree.AddNode(6);
            binaryTree.AddNode(7);

            if(binaryTree.Search(6))
            {
                Console.WriteLine("found it");
                Console.ReadLine();
            }
        }
    }
}
