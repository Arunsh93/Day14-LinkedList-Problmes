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
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);

            linkedList.Print();
        }
    }
}
