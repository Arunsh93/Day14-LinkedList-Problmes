using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
    class SortedLinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            Node current = head, previous = null;
            while(current != null && current.data<node.data)
            {
                previous = current;
                current = current.next;
            }
            if(previous == null)
            {
                head = node;
            }
            else
            {
                previous.next = node;
            }
            node.next = current;
        }
        public void Print()
        {
            if (this.head == null)
            {
                Console.WriteLine("This List is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
