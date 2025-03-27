using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_B
{
    public class Q9
    {
        public static void RunMe()
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(1);
            s1.Push(-1);
            s1.Push(6);
            s1.Push(7);
            Stack<int> s2 = new Stack<int>();
            s2 .Push(3);
            s2.Push(4);
            s2.Push(2);
            s2.Push(5);
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);
            Console.WriteLine(Secret(s1,s2));
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);
        }
        public static int Secret(Stack<int> s1, Stack<int> s2)
        {
            if (s1.IsEmpty() || s2.IsEmpty())
                return 0;
            if (s1.Top() > s2.Top())
                return s1.Pop() + s2.Top() + Secret(s1, s2);
            else
                return s1.Top() + s2.Pop() + Secret(s1, s2);
        }
    }

}
