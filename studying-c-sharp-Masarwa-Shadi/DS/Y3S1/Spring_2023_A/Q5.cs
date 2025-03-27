using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_A
{
    internal class Q5
    {
        public static void RunMe()
        {
            Node<int> node = new Node<int>(4, new Node<int>(3, new Node<int>(7, new Node<int>(9, new Node<int>(3, new Node<int>(9))))));
            Console.WriteLine(node.ToPrint());
            //Console.WriteLine(Distance(node, 3));
            Console.WriteLine(MinDistanceValue(node));
        }

        public static int Distance(Node<int> lst, int num)
        {
            int count1 = 0, count2 = 0;
            Node<int> pos = lst;
            while (pos != null && pos.GetValue() != num )
            {
                count1++;
                pos = pos.GetNext();
            }
            if (pos == null)
                return -1;
            while (pos.HasNext())
            {
                pos = pos.GetNext();
                count2++;
                if (pos.GetValue() == num)
                    count2 = 0;
            }
            return count1 + count2;
        }

        public static int MinDistanceValue(Node<int> lst)
        {
            int num = 0;
            int minDist = -1;
            Node<int> pos = lst;
            while (pos != null)
            {
                if(minDist==-1)
                {
                    minDist = Distance(lst, pos.GetValue());
                    num = pos.GetValue();
                }
                else
                {
                    int currDist = Distance(lst, pos.GetValue());
                    if (currDist < minDist)
                    {
                        minDist= currDist;
                        num = pos.GetValue();
                    }
                }
                pos=pos.GetNext();
            }
            return num;
        }
    }
}
