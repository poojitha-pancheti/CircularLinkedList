﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CircularLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, x;
            CircularLinkedList list = new CircularLinkedList();
            while (true)
            {
                Console.WriteLine("1.Display the list");
                Console.WriteLine("2.Insert in empty list");
                Console.WriteLine("3.Insert in the beginning");
                Console.WriteLine("4.Insert at the end");
                Console.WriteLine("5.Insert after a node");
                Console.WriteLine("6.Delete first node");
                Console.WriteLine("7.Delete last node");
                Console.WriteLine("8.Delete any node");
                Console.WriteLine("9.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 9)
                    break;
                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        Console.Write("Enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInEmptyList(data);
                        break;
                    case 3:
                        Console.Write("Enter the element to be inserted:");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;
                    case 4: 
                        Console.Write("Enter the element to be inserted:");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 5:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert:");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data,x);
                        break;
                    case 6:
                        list.DeleteFirstNode();
                        break;
                    case 7:
                        list.DeleteLastNode();
                        break;
                    case 8:
                        Console.Write("Enter the element to be deleted:");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    default:Console.WriteLine("Wrong choice");
                        break
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");
        }
    }
}
