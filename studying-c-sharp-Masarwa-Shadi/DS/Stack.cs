﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS
{
    public class Stack<T>
    {
        private Node<T> head;

        public Stack()
        {
            this.head = null;
        }
        public bool IsEmpty()
        {
            return this.head == null;
        }
        public T Top()
        {
            return this.head.GetValue();
        }
        public void Push(T x)
        {
            this.head = new Node<T>(x, this.head);
        }
        public T Pop()
        {
            T x = this.head.GetValue();
            this.head = this.head.GetNext();
            return x;
        }
        public override string ToString()
        {
            string str = "[";
            Node<T> pos = this.head;
            while (pos != null)
            {
                str += pos.GetValue().ToString();
                if (pos.GetNext() != null)
                    str += ",";
                pos = pos.GetNext();
            }
            str += "]";
            return str;
        }
    }
}
