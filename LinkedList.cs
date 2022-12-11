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

        
        public LinkedList<t> reverse()//this method reveses the linked list
        {
            if (!this.IsEmpty())//checks if the list is empty or not
            {
                LinkedList<t> reversedList = new LinkedList<t>();//initializes a new list to store a reversed list
                Node<t>? tempNode = this.head;//Object that stores the current node of the list
                Node<t>? newNode;//Object that stores the new node of the reversed list
                while (tempNode != null)//while runs till the tempNode reaches the end of the list
                {
                    newNode = new Node<t>(tempNode.Data);//make a new node to be added to the reversed list
                    newNode.Next = reversedList.head;//appends the previous list to the end of the new node
                    reversedList.head = newNode;//makes the new node the head of the reversed list
                    tempNode = tempNode.Next;//moves to the next node
                   
                }
                
                return reversedList;//returns the reversed list

            }
            else//executes if the list is empty
            {
                Console.WriteLine("The list is currently empty");//error message
            }
            

            return this;//return the same list if the given list is empty
        }
        
        
    }
}
