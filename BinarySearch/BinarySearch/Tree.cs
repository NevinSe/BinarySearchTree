using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Tree<T>
    {
        private Node<T> root;
        private Node<T> tempNode;
        private Node<T> currNode;
        private Node<T>[] nodeList;
        public Tree()
        {
            root = null;
        }
        public bool Search(T value)
        {
            //bool isFound = false;
            currNode = root;
            while(true)
            {
                try
                {
                    if (Comparer<T>.Default.Compare(currNode.info, value) == 0)
                    {
                        return true;
                    }
                    else if (Comparer<T>.Default.Compare(currNode.info, value) > 0)
                    {
                        currNode = currNode.children[0];
                    }
                    else if (Comparer<T>.Default.Compare(currNode.info, value) < 0)
                    {
                        currNode = currNode.children[1];
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public void AddNode(T value)
        {
           
            if(root == null)
            {
                root = new Node<T>(value);
            }
            else
            {
                tempNode = root;
                while(tempNode != null)
                {
                    if (Comparer<T>.Default.Compare(tempNode.info, value) > 0)
                    {
                        if (tempNode.children[0] == null)
                        {
                            tempNode.children[0] = new Node<T>(value);
                            tempNode = tempNode.children[0];
                            break;
                        }
                        else
                        {
                            tempNode = tempNode.children[0];
                        }
                    }
                    if(Comparer<T>.Default.Compare(tempNode.info, value) < 0)
                    {
                        if (tempNode.children[1] == null)
                        {
                            tempNode.children[1] = new Node<T>(value);
                            tempNode = tempNode.children[1];
                            break;
                        }
                        else
                        {
                            tempNode = tempNode.children[1];
                        }
                    }
                 }
               
            }

        }
    }
}
