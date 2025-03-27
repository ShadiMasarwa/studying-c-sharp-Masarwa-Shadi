using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Recursive1
{
    public class Find
    {
        public static void RunMe()
        {
            Stack<int> originalStack = new Stack<int>();
            originalStack.Push(1);
            originalStack.Push(2);
            originalStack.Push(3);
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine(FindInStack(originalStack, 5));
            Console.WriteLine("Original Stack: " + originalStack);

            Console.WriteLine();
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);
            q.Insert(4);
            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine(FindInQ(q,5));
            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine();

            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine(FindByPositionInStack(originalStack, 3));
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine();

            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine(FindByPositionInQ(q, 5));
            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine();
        }

        public static int FindByPositionInStack(Stack<int> stack, int position)
        {
            Stack<int> temp = new Stack<int>();
            bool found = false;
            int index = 0;
            int num = -1;
            while (!stack.IsEmpty()&&!found)
            {
                num = stack.Pop();
                index++;
                if(index == position)
                    found = true;
                temp.Push(num);
            }
            while(!temp.IsEmpty())
                stack.Push(temp.Pop());
            if(found)
                return num;
            return -1;
        }
        public static int FindByPositionInQ(Queue<int> q, int position)
        {
            Queue<int> temp = new Queue<int>();
            bool found = false;
            int index = 0;
            int numInPos = -1;
            while (!q.IsEmpty())
            {
                int currNum = q.Remove();
                index++;
                if(index == position)
                {
                    found = true;
                    numInPos = currNum;
                }
                temp.Insert(currNum);
            }
           
            while(!temp.IsEmpty())
                q.Insert(temp.Remove());
            if(found)
                return numInPos;
            return -1;
        }

        public static bool FindInStack(Stack<int> stack, int num)
        {
            Stack<int> temp = new Stack<int>();
            bool found = false;
            while (!stack.IsEmpty() && !found)
            {
                if(stack.Top() == num)
                    found = true;
                temp.Push(stack.Pop());
            }
            while(!temp.IsEmpty())
                stack.Push(temp.Pop());
            return found;
        }

        public static bool FindInQ(Queue<int> q, int num)
        {
            Queue<int> temp = new Queue<int>();
            bool found = false;
            while (!q.IsEmpty())
            {
                if (q.Head() == num)
                    found = true;
                temp.Insert(q.Remove());
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return found;
        }
    }
}
