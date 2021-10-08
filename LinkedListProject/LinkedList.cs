using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void InsertInBetweenNodes(int position, int data)
        {
            Node node = new Node(data);
            if(position<1)
            {
                Console.WriteLine("Linkde List is Null! Invalid Position");
            }
            else if(position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                while(position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }

       /* public void Append(int value)
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
        }*/

       /* internal Node RemoveNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next.next;
            return this.head;
        }*/

       /* internal Node RemoveLastNode()
        {
            Node newNode = head;
            while(newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }*/

        public void DeleteNode(int data)
        {
            Node temp = head, previous = null;

            if(temp != null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while(temp != null  && temp.data != data)
            {
                previous = temp;
                temp = temp.next;
            }
            if(temp == null)
            {
                return;
            }
            previous.next = temp.next;
        }
        public bool Search(int value)
        {
            if(this.head != null)
            {
                while(this.head.data == value)
                {
                    return true;
                }
                this.head = this.head.next;
            }
            return false;
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
        public int Size()
        {
            int size = 0;
            if (this.head == null)
            {
                Console.WriteLine("This List is Empty");
            }
            else
            {
                
                Node temp = head;
                while (temp != null)
                {
                    size++;
                    temp = temp.next;
                }
            }
            return size;
        }
    }
}
