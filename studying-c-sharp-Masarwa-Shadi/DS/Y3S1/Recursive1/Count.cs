using System;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Recursive1
{
    public class Count
    {

        public static void RunMe()
        {
            Stack<int> originalStack = new Stack<int>();
            originalStack.Push(1);
            originalStack.Push(2);
            originalStack.Push(3);
            Console.WriteLine("Original Stack: " + originalStack);
            //Console.WriteLine(CountStackRecrsive(originalStack));
            Console.WriteLine("Original Stack: " + originalStack);

            Console.WriteLine();
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);
            q.Insert(4);
            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine(CountQ(q));
            Console.WriteLine("Original Queue: " + q);

        }
        public static Node<int> Remove(Node<int> lst, int num)
        {
            if (lst.GetValue() == num) 
                return lst.GetNext();
            Node<int> pos = lst;
            while (pos.HasNext() && pos.GetNext().GetValue() != num)
                pos = pos.GetNext();
            if (!pos.HasNext()) 
                return lst;
            pos.SetNext(pos.GetNext().GetNext());
            return lst;
        }


















        public static int CountStack(Stack<int> stack)
        {
            int count = 0;
            Stack<int> temp = new Stack<int>(); ;
            while (!stack.IsEmpty())
            {
                temp.Push(stack.Pop());
                count++;
            }
            while (!temp.IsEmpty())
                stack.Push(temp.Pop());
            return count;
        }

        //public static Stack<int> Clone(Stack<int> stack)
        //{

        //}
        //public static int CountStackRecrsive(Stack<int> stack)
        //{
        //    if (stack.IsEmpty()) return 0;
        //    stack.Pop();
        //    return 1 + CountStackRecrsive(stack);
        //}

        public static int CountQ(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            int count = 0;
            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
                count++;
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return count;
        }
    }
}
