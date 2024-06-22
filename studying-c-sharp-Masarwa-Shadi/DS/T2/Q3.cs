using System;
namespace studying_c_sharp_Masarwa_Shadi.DS.T2
{
    public class Q3
    {
        public static void RunMe()
        {
            //Build nodes
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);
            Node<int> node6 = new Node<int>(6);
            Node<int> node7 = new Node<int>(7);
            Node<int> node8 = new Node<int>(8);
            Node<int> node9 = new Node<int>(9);
            Node<int> node10 = new Node<int>(10);
            //Build connections
            node1.SetNext(node2);
            node2.SetNext(node3);
            node3.SetNext(node4);
            node4.SetNext(node5);
            node5.SetNext(node6); 
            node6.SetNext(node7); 
            node7.SetNext(node8); 
            node8.SetNext(node9); 
            node9.SetNext(node10);
            node10.SetNext(node6); //last pointing to node6

            Console.WriteLine("Intersection at node no. " + GetIntersection(node1,node2).GetValue());
        }

        private static Node<int> GetIntersection(Node<int>node1, Node<int> node2)
        {
            Node<int> firstStep = node1;
            Node<int> secondStep = node1;
            while (firstStep != secondStep || firstStep == node1)
            {
                firstStep = firstStep.GetNext();
                secondStep = secondStep.GetNext().GetNext();
            }

            firstStep = node1;
            while (firstStep != secondStep)
            {
                firstStep = firstStep.GetNext();
                secondStep = secondStep.GetNext();
            }

            return firstStep;
        }
    }
}
