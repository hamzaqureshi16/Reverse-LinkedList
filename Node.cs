using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    internal class Node<t>
    {
        //make node class for linked lists
        private t data;
        private Node<t>? next;
        //make properties for the fields
        public t Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<t> Next
        {
            get { return next; }
            set { next = value; }
        }
        //make constructor for the node class
        public Node(t data)
        {
            this.data = data;
            next = null;
        }

    }
}
