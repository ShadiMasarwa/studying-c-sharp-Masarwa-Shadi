using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.T1
{
    public class Q1
    {
        public static void RunMe()
        {
            //Console.WriteLine("aaa");
            Node<int> n1 = new Node<int>(10);
            Node<int> n2 = new Node<int>(15);
            Node<int> n3 = new Node<int>(17);
            Node<int> n4 = new Node<int>(16);
            Node<int> n5 = new Node<int>(48);
            n1.SetNext(n2);
            n2.SetNext(n3);
            n3.SetNext(n4);
            n4.SetNext(n5);

            Node<int> result = Q1.Even(n1);
            Console.WriteLine(result.ToPrint());
        }
        public static Node<int> Even(Node<int> lst)
        {
            Node<int> pos = lst;
            Node<int> newlst = null;
            while(pos != null)
            {
                if(pos.GetValue() % 2 == 0)
                {
                        newlst = new Node<int>(pos.GetValue(), newlst);
                }
                pos = pos.GetNext();
                
            }
            return newlst;
        } 
    }
}
