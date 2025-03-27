using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_A
{
    public class RunMethods
    {
        public static void RunMe()
        {
            Stack<int> st1 = new Stack<int>();
            st1.Push(1);
            st1.Push(3);
            st1.Push(5);
            st1.Push(7);
            st1.Push(9);
            st1.Push(11);
            //Console.WriteLine(Q1A.IsUniform(st1));
            Queue<int> queue1 = new Queue<int>();
            queue1.Insert(8);
            queue1.Insert(10);
            queue1.Insert(11);
            queue1.Insert(2);
            queue1.Insert(3);
            queue1.Insert(16);
            queue1.Insert(12);
            queue1.Insert(4);
            //Console.WriteLine(queue1.ToString());
            //Console.WriteLine(Q2A.RemoveLast(queue));
            //Console.WriteLine(queue1.ToString());
            Node<int> node = new Node<int>(10, new Node<int>(-3, new Node<int>(10, new Node<int>(-3))));
            //Console.WriteLine(Q3A.UniqNeg(node));
            Queue<int> queue2 = new Queue<int>();
            queue2.Insert(1);
            queue2.Insert(2);
            queue2.Insert(3);
            queue2.Insert(4);
            Queue<int> queue3 = new Queue<int>();
            queue3.Insert(1);
            queue3.Insert(2);
            queue3.Insert(3);
            queue3.Insert(4);
            queue3.Insert(1);
            queue3.Insert(2);
            queue3.Insert(3);
            queue3.Insert(4);
            //Console.WriteLine(queue2.ToString());
            //Console.WriteLine(Q6A.StartWith(queue2, queue3));
            //Console.WriteLine(queue2.ToString());
            //Console.WriteLine(Q6A.Duplication(queue2, queue3));
            //Console.WriteLine(queue2.ToString());
            //Node<int> node2 = new Node<int>(2, new Node<int>(5, new Node<int>(4, new Node<int>(3))));
            //Console.WriteLine(Q7.IsUpDown(node2));
            BinNode<int> node3 = new BinNode<int>(3);
            BinNode<int> node4 = new BinNode<int>(4);
            BinNode<int> node2 = new BinNode<int>(null, 2, node3);
            BinNode<int> node22 = new BinNode<int>(node2, 22, node4);
            BinNode<int> node6 = new BinNode<int>(6);
            BinNode<int> node5 = new BinNode<int>(node6, 5, null);
            BinNode<int> root = new BinNode<int>(node5, 10, node22);
            //Console.WriteLine(root.ToString());
            //Q8.LessThanAvg(root);
            Q9.RunTests();
        }
    }
}
