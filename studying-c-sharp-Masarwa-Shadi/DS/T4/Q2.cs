using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T4
{
    public class Q2
    {
        public static void RunMe()
        {
            Node<int> circleLst = new Node<int>(1);
            Node<int> pos = circleLst;
            for (int i = 2; i <= 10; i++)
            {
                pos.SetNext(new Node<int>(i));
                pos = pos.GetNext();
            }
            pos.SetNext(circleLst);
            Console.WriteLine("Circular chain:");
            Console.WriteLine(circleLst.ToPrintCircleChain());
            Node<int> head = circleLst.GetNext().GetNext().GetNext();
            Console.WriteLine(head.ToPrintCircleChain());

            Node<int> linearLst = GetLinearLst(head);
            Console.WriteLine("Linear chain:");
            Console.WriteLine(linearLst.ToPrint());
        }

        private static Node<int> GetLinearLst(Node<int> head)
        {
            Node<int> linearChain = head;
            do
            {
                head = head.GetNext();
            } while (!head.GetNext().Equals(linearChain));
            
            head.SetNext(null);
            return linearChain;
        }
    }
}
