using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Test2024
{
    public class Q4
    {
        public static void MergeStacks(Stack<int> s1, Stack<int> s2)
        {
            Stack<int> temp = new Stack<int>();
            int count1 = Count(s1);
            int count2 = Count(s2);
            if (count2 % 2 == 0)
            {
                for(int i=0; i<count2/2; i++)
                    temp.Push(s2.Pop());
                while (!s1.IsEmpty())
                    temp.Push(s1.Pop());
                while(!s2.IsEmpty())
                    temp.Push(s2.Pop());
                while (!temp.IsEmpty())
                    s2.Push(temp.Pop());
            }
            if(count1%2==0 && count2 % 2 != 0)
            {
                for (int i = 0; i < count1 / 2; i++)
                    temp.Push(s1.Pop());
                while (!s2.IsEmpty())
                    temp.Push(s2.Pop());
                while (!s1.IsEmpty())
                    temp.Push(s1.Pop());
                while (!temp.IsEmpty())
                    s1.Push(temp.Pop());
            }
        }

        private static int Count(Stack<int> s)
        {
            int count = 0;
            Stack<int> temp = new Stack<int>();
            while (!s.IsEmpty())
            {
                temp.Push(s.Pop());
                count++;
            }
            while (!temp.IsEmpty())
                s.Push(temp.Pop());
            return count;

        }
    }
}
