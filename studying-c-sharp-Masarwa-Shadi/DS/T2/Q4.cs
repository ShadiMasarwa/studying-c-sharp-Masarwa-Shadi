using System;
namespace studying_c_sharp_Masarwa_Shadi.DS.T2
{
    public class Q4
    {
        public static void RunMe()
        {
            Node<int> lst1 = new Node<int>(2);
            lst1 = new Node<int>(3, lst1);
            lst1 = new Node<int>(4, lst1);
            lst1 = new Node<int>(5, lst1);
            lst1 = new Node<int>(6, lst1);
            lst1 = new Node<int>(7, lst1);

            Node<int> lst2 = new Node<int>(8);
            lst2 = new Node<int>(4, lst2);
            lst2 = new Node<int>(25, lst2);
            lst2 = new Node<int>(9, lst2);
            lst2 = new Node<int>(16, lst2);
            lst2 = new Node<int>(7, lst2);

            Console.WriteLine(GetSquaresList(lst1, lst2).ToPrint());
           
        }

        private static Node<int> GetSquaresList(Node<int> lst1, Node<int>lst2)
        {
            Node<int> squares = null;
            Node<int> pointer1 = lst1;
            while (pointer1 != null)
            {
                Node<int> pointer2 = lst2;
                while (pointer2 != null)
                {
                    if (pointer2.GetValue() == Math.Pow(pointer1.GetValue(), 2))
                        squares = new Node<int>(pointer1.GetValue(), squares);
                    pointer2 = pointer2.GetNext();
                }
                pointer1 = pointer1.GetNext();
            }
            return squares;
        }
    }
}
