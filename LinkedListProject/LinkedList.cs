using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
    class LinkedList
    {
        public Node head;

        public void Add(int value)
        {
            Node node = new Node(value);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Added to the List", node.data);
        }
    }
}
