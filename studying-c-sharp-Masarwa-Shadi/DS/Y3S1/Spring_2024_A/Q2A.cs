using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_A
{
    public class Q2A
    {
        public static int RemoveLast(Queue<int> q)
        {
            Stack<int> st1 = new Stack<int>();
            Stack<int> st2 = new Stack<int>();
            while (!q.IsEmpty())
                st1.Push(q.Remove());
            int num = st1.Pop();
            while(!st1.IsEmpty())
                st2.Push(st1.Pop());
            while (!st2.IsEmpty())
                q.Insert(st2.Pop());
            return num;
        }
    }
}
