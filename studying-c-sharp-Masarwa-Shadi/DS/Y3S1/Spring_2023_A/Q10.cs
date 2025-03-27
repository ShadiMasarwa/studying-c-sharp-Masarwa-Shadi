using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2023_A
{
    public class Q10
    {
        public static void RunMe()
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> stack3 = new Stack<int>();
            Queue<Stack<int>> queue = new Queue<Stack<int>>();
            stack1.Push(7);
            stack1.Push(5);
            stack1.Push(3);
            stack1.Push(2);
            stack2.Push(15);
            stack2.Push(13);
            stack2.Push(12);
            stack2.Push(10);
            stack2.Push(7);
            stack3.Push(40);
            stack3.Push(35);
            stack3.Push(30);
            stack3.Push(25);
            stack3.Push(20);
            stack3.Push(15);
            queue.Insert(stack1);
            queue.Insert(stack2);
            queue.Insert(stack3);
            Console.WriteLine(IsPerfect(queue));
        }

        public static bool IsPerfect(Queue<Stack<int>> q)
        {
            Queue<Stack<int>> copy = CloneQueue(q);
            while (!copy.IsEmpty())
            {
                if(!IsAsc(copy.Remove()))
                    return false;
            }
            
            copy = CloneQueue(q);
            int count = StackCount(copy.Remove());
            while(!copy.IsEmpty())
            {
                int currCount = StackCount(copy.Remove());
                if(currCount < count)
                    return false;
                count= currCount;
            }

            int num = GetLast(q.Remove());
            while (!q.IsEmpty())
            {
                if(q.Head().Top() != num)
                    return false;
                num = GetLast(q.Head());
                q.Remove();
            }
            return true;
        }

        public static bool IsAsc(Stack<int> st)
        {
            Stack<int> copy = CloneStack(st);
            int num = copy.Pop();
            while (!copy.IsEmpty())
            {
                if(copy.Top()<num)
                    return false;
                num = copy.Pop();
            }
            return true;
        }

        public static int StackCount(Stack<int> st)
        {
            Stack<int> copy = CloneStack(st);
            int count = 0;
            while (!copy.IsEmpty())
            {
                count++;
                copy.Pop();
            } 
            return count;
        }

        public static Stack<int> CloneStack(Stack<int> st)
        {
            Stack<int> temp = new Stack<int>();
            Stack<int> copy = new Stack<int>();
            while (!st.IsEmpty())
                temp.Push(st.Pop());
            while (!temp.IsEmpty())
            {
                copy.Push(temp.Top());
                st.Push(temp.Pop());
            }
            return copy;
        }

        public static int GetLast(Stack<int> st)
        {
            int num = st.Pop();
            while (!st.IsEmpty())
                num = st.Pop();
            return num;
        }

        public static Queue<Stack<int>> CloneQueue(Queue<Stack<int>> q)
        {
            Queue<Stack<int>> copy = new Queue<Stack<int>>();
            Queue<Stack<int>> temp = new Queue<Stack<int>>();
            while (!q.IsEmpty())
            {
                copy.Insert(q.Head());
                temp.Insert(q.Remove());
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return copy;
        }


    }
}
