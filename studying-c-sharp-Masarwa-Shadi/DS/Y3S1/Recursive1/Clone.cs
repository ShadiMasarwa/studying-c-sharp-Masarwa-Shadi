using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Recursive1
{
    public class Clone
    {
        public static void RunMe()
        {
            Stack<int> originalStack = new Stack<int>();
            originalStack.Push(1);
            originalStack.Push(2);
            originalStack.Push(3);
            Console.WriteLine("Original Stack: " + originalStack);

            Stack<int> clonedStack = CloneStack(originalStack);
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine("Cloned Stack: " + clonedStack);
            clonedStack.Pop();
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine("Cloned Stack: " + clonedStack);
            Console.WriteLine();

            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);
            q.Insert(4);
            Console.WriteLine("Original Queue: " + q);
            Queue<int> clonedQ = CloneQueue(q);
            Console.WriteLine("Cloned Queue: " + clonedQ);
            clonedQ.Remove();
            Console.WriteLine("Cloned Queue: " + clonedQ);
        }

        public static Stack<int> CloneStack(Stack<int> stk)
        {
            Stack<int> temp = new Stack<int>();
            while(!stk.IsEmpty())
                temp.Push(stk.Pop());
            Stack<int> copy = new Stack<int>();
            while (!temp.IsEmpty())
            {
                stk.Push(temp.Top());
                copy.Push(temp.Pop());
            }
            return copy;
        }
        public static Queue<int> CloneQueue(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
                temp.Insert(q.Remove());
            Queue<int> copy = new Queue<int>();
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Head());
                copy.Insert(temp.Remove());
            }
            return copy;
        }
        //public static void CloneStack(Stack<int> originalStack, Stack<int> cloned)
        //{
        //    if (originalStack.IsEmpty())
        //        return;
        //    int num = originalStack.Pop();
        //    CloneStack(originalStack, cloned);
        //    cloned.Push(num);
        //    originalStack.Push(num);
        //}

        //public static Stack<int> CloneStack(Stack<int> originalStack)
        //{
        //    if (originalStack.IsEmpty())
        //        return new Stack<int>();
        //    int num = originalStack.Pop();
        //    Stack<int> cloned = CloneStack(originalStack);
        //    cloned.Push(num);
        //    originalStack.Push(num);
        //    return cloned;
        //}

        public static void CloneQueue(Queue<int> originalQ, Queue<int> clonedQ)
        {
            if (originalQ.IsEmpty())
                return;
            int num = originalQ.Remove();
            clonedQ.Insert(num);
            CloneQueue(originalQ, clonedQ);
            originalQ.Insert(num);
        }

        //public static Queue<int> CloneQueue(Queue<int> originalQ)
        //{
        //    if (originalQ.IsEmpty())
        //        return new Queue<int>(); // Return an empty queue if original is empty

        //    int num = originalQ.Remove(); // Dequeue the front element
        //    Queue<int> clonedQ = CloneQueue(originalQ); // Recursively clone the remaining queue
        //    clonedQ.Insert(num); // Add the element back to the cloned queue
        //    originalQ.Insert(num); // Restore the original queue

        //    return clonedQ; // Return the cloned queue
        //}




    }
}
