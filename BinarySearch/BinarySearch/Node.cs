using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Node<T>
    {
        // private member variables
        public T info;
        public Node<T> link;
        public Node<T> leftNode;
        public Node<T> rightNode;
        public Node<T>[] children;

        public Node()
        {

        }

        public Node(T info)
        {
            this.info = info;
            link = null;
            children = new Node<T>[2];
        }

        //public void AddChildNode(T child)
        //{
        //    if(Comparer<T>.Default.Compare(this.info, child) > 0 && children[0] == null)
        //    {
        //        children[0] = new Node<T>(child);
        //    }
        //    else if (Comparer<T>.Default.Compare(this.info, child) < 0 && children[1] ==null)
        //    {
        //        children[1] = new Node<T>(child);
        //    }
        //}

    }
}
