﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListExample
{
    internal class DoublyNode<T>
    {
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }


        public DoublyNode(T data)
        {
            Data = data;
            Previous = null;
            Next = null;
        }

    }
}
