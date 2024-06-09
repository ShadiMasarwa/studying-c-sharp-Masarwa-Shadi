using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.ClassProj
{
    public class a1
    {
        public static void RunMe()
        {
            Node<int> lst = new Node<int>(8);
            lst = new Node<int>(-9, lst);
            lst = new Node<int>(-7, lst);
            lst = new Node<int>(100, lst);
            lst = new Node<int>(-25, lst);
            lst = new Node<int>(-7, lst);
            lst = new Node<int>(8, lst);

            Console.WriteLine(Check(lst));
        }


        private static bool Check(Node<int> lst)
        {
            int numOfPositive = 0;
            int numOfNegative = 0;
            Node<int> pos = lst;
            while (pos != null)
            {
                if (pos.GetValue() >= 0)
                    numOfPositive++;
                else
                    numOfNegative++;
                pos = pos.GetNext();
            }
            if (numOfPositive > numOfNegative)
                return true;
            return false;
        }
    }
}
