using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_B
{
    public class Q2
    {
        public static void RunMe()
        {
            Node<int> node = new Node<int>(-1, new Node<int>(8));
            Console.WriteLine("Origin: " + node.ToPrint());
            Balance(node);
            Console.WriteLine("New:    " + node.ToPrint());

        }

        public static void Balance(Node<int> chain)
        {
            int len = Length(chain);
            int sum = Sum(chain);
            int dif = 0 - sum;
            if(len % 2 !=0 && dif == 0)
            {
                Node<int> pos = chain;
                while (pos.HasNext())
                    pos = pos.GetNext();
                pos.SetNext(new Node<int>(0));
            }
            if(dif != 0)
            {
                Node<int> pos = chain;
                while(pos.HasNext())
                    pos=pos.GetNext();
                if (len % 2 != 0)
                    pos.SetNext(new Node<int>(dif));
                else
                    pos.SetNext(new Node<int>(0, new Node<int>(dif)));
            }
        }

        public static int Length(Node<int> lst)
        {
            Node<int> pos = lst;
            int len = 0;
            while (pos != null)
            {
                len++;
                pos = pos.GetNext();
            }
            return len;
        }

        public static int Sum(Node<int> lst)
        {
            Node<int> pos = lst;
            int sum = 0;
            while (pos != null)
            {
                sum += pos.GetValue();
                pos = pos.GetNext();
            }
            return sum;
        }


    }
}
