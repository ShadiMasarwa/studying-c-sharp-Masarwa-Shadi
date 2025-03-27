using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Recursive1
{
    internal class Reversed
    {
        public static void RunMe()
        {
            Stack<int> originalStack = new Stack<int>();
            originalStack.Push(1);
            originalStack.Push(2);
            originalStack.Push(3);
            Console.WriteLine("Original Stack: " + originalStack);

            Stack<int> reversedStack = new Stack<int>();
            ReversedStack(originalStack, reversedStack);
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine("Reversed Stack: " + reversedStack);

            Console.WriteLine();
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);
            q.Insert(4);
            Console.WriteLine("Original Queue: " + q);
            Queue<int> reversedQ = ReversedQ(q);
            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine("Cloned Queue: " + reversedQ);
        }


       

        public static void ReversedStack(Stack<int> originalStack, Stack<int> reversed)
        {
            if (originalStack.IsEmpty())
                return;
            int num = originalStack.Pop();
            reversed.Push(num);
            ReversedStack(originalStack, reversed);
            originalStack.Push(num);
        }

        public static Queue<int> ReversedQ(Queue<int> originalQ)
        {
            Queue<int> reversed = new Queue<int>();
            Stack<int> temp1 = new Stack<int>();
            Queue<int> temp2 = new Queue<int>();
            while(!originalQ.IsEmpty())
            {
                temp1.Push(originalQ.Head());
                temp2.Insert(originalQ.Remove());
            }
            while (!temp1.IsEmpty())
            {
                reversed.Insert(temp1.Pop());
                originalQ.Insert(temp2.Remove());
            }
            return reversed;
        }
    }
}
