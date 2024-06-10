using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS
{
    internal class LinkedList<T>
    {
        public Node<T> first { get; set; }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.SetNext(first);
            first = newNode;
        }

        public Node<T> RemoveFirst()
        {
            first = first.GetNext();
            return first;
        }

        public void DisplayLst()
        {
            Node<T> curr = first;
            while(curr != null)
            {
                Console.Write(curr.GetValue() + ", ");
                curr = curr.GetNext();
            }
        }

        public void AddLast(T data)
        {
            Node<T> curr = first;
            while(curr.HasNext())
                curr = curr.GetNext();
            Node<T> newNode = new Node<T>(data);
            curr.SetNext(newNode);
        }

        public void RemoveLast()
        {
            Node<T> curr = first;
            Node<T> next = first.GetNext();
            while (next.HasNext())
            {
                curr = curr.GetNext();
                next = next.GetNext();
            }
            curr.SetNext(null);
        }
    }
}
