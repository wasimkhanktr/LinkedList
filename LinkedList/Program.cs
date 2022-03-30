﻿using System;
using System.Collections.Generic;

namespace LinkedList
{
    class program
    {
        static void Main()
        {
                LinkListOperation linklist = new LinkListOperation();
                Node node1 = new Node(21);
                Node node2 = new Node(22);
                Node node3 = new Node(23);
                Node node4 = new Node(24);
                Node node5 = new Node(25);

                linklist.AddNode(node1);
                linklist.AddNode(node2);
                linklist.AddNode(node3);
                linklist.AddNode(node4);
                linklist.AddNode(node5);

                linklist.Display();
                linklist.DeleteNodeAtFirst();
                linklist.Display();

                Console.WriteLine("\nEnter number you want to search");
                int data = int.Parse(Console.ReadLine());
                bool res = linklist.search(data);
                if (res == true)
                {
                    Console.WriteLine("Data found");
                }
                else
                {
                    Console.WriteLine("Data not found");
                }

                Node node7 = new Node(100);
                Console.WriteLine("\nEnter a number after you want to add: ");
                int Data = int.Parse(Console.ReadLine());
                linklist.AddSpicificNode(Data, node7);
                linklist.Display();
            }
        }
    }