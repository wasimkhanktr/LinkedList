﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkListOperation list = new LinkListOperation();
            Console.WriteLine("Before Deleting");
            list.append(56);
            list.append(70);
            list.append(30);
            list.display();
            Console.WriteLine("After Deleting");
            list.popLast();
            list.display();
        }
    }
}