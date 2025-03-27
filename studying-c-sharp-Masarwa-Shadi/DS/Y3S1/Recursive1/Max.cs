using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Recursive1
{
    public class Max
    {
        public static void RunMe()
        {
            Stack<int> originalStack = new Stack<int>();
            originalStack.Push(4);
            originalStack.Push(2);
            originalStack.Push(3);

            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(4);
            q.Insert(3);
            q.Insert(4);

            Console.WriteLine("Max");
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine(MaxInStack(originalStack));
            Console.WriteLine("New Stack: " + originalStack);
            Console.WriteLine();

            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine(MaxInQ(q));
            Console.WriteLine("New Queue: " + q);
            Console.WriteLine();
        }

        public static int MaxInStack(Stack<int> stack)
        {
            Stack<int> temp = new Stack<int>();
            int max = stack.Pop();
            temp.Push(max);
            while(!stack.IsEmpty())
            {
                int num = stack.Pop();
                temp.Push(num);
                if (num > max)
                    max = num;
            }
            while(!temp.IsEmpty())
                stack.Push(temp.Pop());
            return max;
        }
        public static int MaxInQ(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            int max = q.Remove();
            temp.Insert(max);
            while(!q.IsEmpty())
            {
                int num = q.Remove();
                temp.Insert(num);
                if (num > max)
                    max = num;
            }
            while(!temp.IsEmpty())
                q.Insert(temp.Remove());
            return max;
        }
    }
}
