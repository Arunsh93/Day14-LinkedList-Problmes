using System;
using System.Collections.Generic;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problems");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(70);
            Console.WriteLine("List before inserting 30: ");
            linkedList.Print();

            linkedList.InsertInBetweenNodes(2, 30);
            Console.WriteLine("List after inserting 30: ");
            linkedList.Print();

            linkedList.InsertInBetweenNodes(3, 40);
            Console.WriteLine("List after inserting 40: ");
            linkedList.Print();

            linkedList.DeleteNode(40);
            Console.WriteLine("After deleting 40:");
            linkedList.Print();

            int sizeOfList = linkedList.Size();
            Console.WriteLine("Size of an Linked List is: " + sizeOfList);

            /*linkedList.Search(30);
            linkedList.Print();*/

            /* linkedList.RemoveLastNode();
             Console.WriteLine("After Deleting the Last node: ");
             linkedList.Print();*/

            /*linkedList.RemoveNode();
            Console.WriteLine("After Deleting the First node: ");
            linkedList.Print();*/

            SortedLinkedList sortedList = new SortedLinkedList();
            sortedList.Add(56);
            sortedList.Add(30);
            sortedList.Add(40);
            sortedList.Add(70);
            Console.WriteLine("The ordered list after inserting 56,30,40,70 using sorted linked list is : ");
            sortedList.Print();
        }
    }
}
