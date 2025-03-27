using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_B
{
    public class Q5
    {
        public static void RunMe()
        {
            Node<int> n = new Node<int>(1, new Node<int>(5, new Node<int>(14, new Node<int>(80))));
            Console.WriteLine(n.ToPrint());
            Console.WriteLine(IsSuper(n));
            Console.WriteLine(AddToSuper(n, 100));
            Console.WriteLine(n.ToPrint());

        }

        public static bool IsSuper(Node<int> n)
        {
            Node<int> pos = n;
            int sum = pos.GetValue();
            while (pos.HasNext() && sum < pos.GetNext().GetValue())
            {
                pos = pos.GetNext();
                sum += pos.GetValue();
            }
            if (pos.HasNext())
                return false;
            return true;
        }

        public static bool AddToSuper(Node<int> n, int num)
        {
            Node<int> pos = n;
            Node<int> newNode = new Node<int>(num);
            while (pos.HasNext() && pos.GetNext().GetValue() < num)
            {
                pos = pos.GetNext();
            }

            newNode.SetNext(pos.GetNext());
            pos.SetNext(newNode);
            if(IsSuper(n))
                return true;
            else
            {
                pos.SetNext(pos.GetNext().GetNext());
                return false;
            }

        }
    }
}
