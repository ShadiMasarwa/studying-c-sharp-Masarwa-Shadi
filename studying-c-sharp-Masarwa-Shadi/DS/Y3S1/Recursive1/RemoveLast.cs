using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Recursive1
{
    public class RemoveLast
    {
        public static void RunMe()
        {
            Stack<int> originalStack = new Stack<int>();
            originalStack.Push(1);
            originalStack.Push(2);
            originalStack.Push(3);
            //Console.WriteLine("Original Stack: " + originalStack);
            //Console.WriteLine(RemoveLastInStack(originalStack));
            //Console.WriteLine("Original Stack: " + originalStack);

            //Console.WriteLine();
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);
            q.Insert(4);
            //Console.WriteLine("Original Queue: " + q);
            //Console.WriteLine(RemoveLastInQ(q));
            //Console.WriteLine("Original Queue: " + q);

            Console.WriteLine("Remove by position");
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine(RemoveByPositionInStack(originalStack, 4));
            Console.WriteLine("New Stack: " + originalStack);
            Console.WriteLine();

            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine(RemoveByPositionInQ(q,5));
            Console.WriteLine("New Queue: " + q);

        }

        public static int RemoveLastInStack(Stack<int> stack)
        {
            Stack<int> temp = new Stack<int>();
            while (!stack.IsEmpty())
                temp.Push(stack.Pop());
            int num = temp.Pop();
            while(!temp.IsEmpty())
                stack.Push(temp.Pop());
            return num;
        }

        public static int RemoveLastInQ(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>(); 
            int last = 0; 
            while (!q.IsEmpty())
            {
                last = q.Remove();
                if (!q.IsEmpty())
                    temp.Insert(last);
            }
            while(!temp.IsEmpty())
                q.Insert(temp.Remove());
            return last;
        }

        public static int RemoveByPositionInStack(Stack<int> stack, int position)
        {
            Stack<int> temp = new Stack<int>();
            bool found = false;
            int index = 0;
            int num = -1;
            while (!stack.IsEmpty() && !found)
            {
                num = stack.Pop();
                index++;
                if (index == position)
                    found = true;
                else
                    temp.Push(num);
            }

            while (!temp.IsEmpty())
                stack.Push(temp.Pop());
            if (found)
                return num;
            return -1;
        }

        public static int RemoveByPositionInQ(Queue<int> q, int position)
        {
            Queue<int> temp = new Queue<int>();
            bool found = false;
            int index = 0;
            int numInPos = -1;
            while (!q.IsEmpty())
            {
                int currNum = q.Remove();
                index++;
                if (index == position)
                {
                    found = true;
                    numInPos = currNum;
                }
                else
                    temp.Insert(currNum);
            }

            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            if (found)
                return numInPos;
            return -1;
        }
    }
}
