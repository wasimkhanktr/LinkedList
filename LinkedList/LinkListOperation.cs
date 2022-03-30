﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkListOperation
    {
        public Node Head;
        public Node Tail;
        public LinkListOperation()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("LinkList is empty");
            }
            else
            {
                Console.WriteLine("LinkList as follows: ");
            }
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write("->"); ;
                }
                temp = temp.next;
            }
        }
        public void DeleteNodeAtFirst()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothig to delete");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine("\nRemoved first node from LinkList");
        }

        public bool search(int data)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
    }
}