using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    internal class LinkedList<t>
    {

        private Node<t>? head;
        private Node<t>? tail;
        private int count;

        public Node<t>? Head
        {
            get { return head; }
            set { head = value; }
        }
        public Node<t>? Tail
        {
            get { return tail; }
            set { tail = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Add(t data)
        {
            Node<t> node = new Node<t>(data);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            count++;
        }
        
        public void Remove(t data)
        {
            Node<t>? current = head;
            Node<t>? previous = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head?.Next;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    count--;
                }
                previous = current;
                current = current.Next;
            }
        }
        public void Print()
        {
            Node<t>? current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        
        public bool IsEmpty()
        {
            return count == 0;
        }
        public LinkedList<t> reverse()
        {
            if (!this.IsEmpty())
            {
                LinkedList<t> reversedList = new LinkedList<t>();
                Node<t>? tempNode = this.head,newNode;
                while(tempNode != null)
                {
                    newNode = new Node<t>(tempNode.Data);
                    newNode.Next = reversedList.head;
                    reversedList.head = newNode;
                    tempNode = tempNode.Next;
                   
                }
                

                return reversedList;

            }
            else
            {
                Console.WriteLine("The list is currently empty");
            }
            

            return this;
        }
        
        
    }
}
