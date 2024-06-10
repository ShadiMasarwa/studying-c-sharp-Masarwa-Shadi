using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.T1
{
    public class Q1
    {
        public static void RunMe()
        {
            //Console.WriteLine("aaa");
            Node<int> lst = new Node<int>(10);
            lst = new Node<int>(15, lst);
            lst = new Node<int>(17, lst);
            lst  = new Node<int>(16, lst);
            lst = new Node<int>(48, lst);

            Console.WriteLine("Origin List: " + lst.ToPrint());

            Node<int> result = Even(lst);
            Console.WriteLine("Even Numbers: " + result.ToPrint());

            result = EvenReverse(lst);
            Console.WriteLine("Even Numbers (Reversed): " + result.ToPrint());
        }
        public static Node<int> EvenReverse(Node<int> lst)
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

        public static Node<int> Even(Node<int> lst)
        {
            Node<int> newlst = null;
            Node<int> pos = lst;
            while (pos != null)
            {
                if (pos.GetValue() % 2 == 0)
                {
                    if (newlst == null)
                        newlst = new Node<int>(pos.GetValue());
                    else
                    {
                        Node<int> after = GetLast(newlst);
                        after.SetNext(new Node<int>(pos.GetValue()));
                    }
                }
                pos = pos.GetNext();
            }
            return newlst;
        }

        public static Node<int> GetLast(Node<int> lst)
        {
            while (lst != null && lst.HasNext())
                lst = lst.GetNext();
            return lst;
        }
    }
}
