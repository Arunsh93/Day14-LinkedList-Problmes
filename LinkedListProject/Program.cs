﻿using System;
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


            /*linkedList.Search(30);
            linkedList.Print();*/

           /* linkedList.RemoveLastNode();
            Console.WriteLine("After Deleting the Last node: ");
            linkedList.Print();*/

            /*linkedList.RemoveNode();
            Console.WriteLine("After Deleting the First node: ");
            linkedList.Print();*/
        }
    }
}
