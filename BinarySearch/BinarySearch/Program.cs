﻿using System;
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
            binaryTree.AddNode(30);
            binaryTree.AddNode(7);
            binaryTree.AddNode(6);
            binaryTree.AddNode(5);
            binaryTree.AddNode(3);
            binaryTree.AddNode(2);
            while(true)
            {
                Console.WriteLine("\r\nEnter a valid integer");
                try
                {
                    if (binaryTree.Search(int.Parse(Console.ReadLine())))
                    {
                        Console.WriteLine("found it");
                    }
                    else
                    {
                        Console.WriteLine("Not in the list");
                    }
                }
                catch
                {
                    Console.WriteLine("I SAID A VALID INTEGER!");
                }
               
            }
            
        }
    }
}
