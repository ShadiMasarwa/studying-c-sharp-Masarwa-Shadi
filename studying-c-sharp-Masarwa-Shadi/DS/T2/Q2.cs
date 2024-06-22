using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T2
{
    public class Q2
    {
        public static void RunMe()
        {

            Node<int> innerNode1 = new Node<int>(0);
            Node<int> innerNode2 = new Node<int>(1);
            Node<int> innerNode3 = new Node<int>(0);
            Node<int> innerNode4 = new Node<int>(1);
            Node<int> innerNode5 = new Node<int>(0);
            Node<int> innerNode6 = new Node<int>(1);
            Node<int> innerNode7 = new Node<int>(0);
            Node<int> innerNode8 = new Node<int>(1);

            innerNode1.SetNext(innerNode3);
            innerNode3.SetNext(innerNode5);
            innerNode5.SetNext(innerNode7);

            Node<Node<int>> node1 = new Node<Node<int>>(innerNode1);
            Node<Node<int>> node2 = new Node<Node<int>>(innerNode2);
            Node<Node<int>> node3 = new Node<Node<int>>(innerNode3);
            Node<Node<int>> node4 = new Node<Node<int>>(innerNode4);
            Node<Node<int>> node5 = new Node<Node<int>>(innerNode5);
            Node<Node<int>> node6 = new Node<Node<int>>(innerNode6);
            Node<Node<int>> node7 = new Node<Node<int>>(innerNode7);
            Node<Node<int>> node8 = new Node<Node<int>>(innerNode8);

            node1.SetNext(node2);
            node2.SetNext(node3);
            node3.SetNext(node4);
            node4.SetNext(node5);
            node5.SetNext(node6);
            node6.SetNext(node7);
            node7.SetNext(node8);

            Console.WriteLine(ZeroCount(node1));
        }

        private Node<Node<int>> NextZero(Node<Node<int>> lst, Node<Node<int>> p)
        {
            p = p.GetNext();
            while (p != null)
            {
                if (p.GetValue().GetValue() == 0)
                    return p;
                p = p.GetNext();
            }
            return null;
        }

        private Node<Node<int>> PrevZero(Node<Node<int>> lst, Node<Node<int>> p)
        {
            Node<Node<int>> pos = lst;
            Node<Node<int>> nodeFound = null;

            while (pos != p)
            {
                if (pos.GetValue().GetValue() == 0)
                    nodeFound = pos;
                pos = pos.GetNext();
            }
            return nodeFound;
        }

        private static int ZeroCount(Node<Node<int>> lst)
        {
            int count = 0;
            Node<int> pos = null;
            //Find first node with 0 value
            while (lst != null)
            {
                if (lst.GetValue().GetValue() == 0)
                {
                    count++;
                    pos = lst.GetValue();
                    break;
                }
            }
            //Loop through 0s only
            while (pos!=null && pos.HasNext())
            {
                count++;
                pos = pos.GetNext();
            }
            return count;
        }





    }
}
