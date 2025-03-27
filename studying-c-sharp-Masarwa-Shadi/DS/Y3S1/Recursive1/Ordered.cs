using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Recursive1
{
    public class Ordered
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

            Console.WriteLine("Ordered");
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine(OrderedStack(originalStack));
            Console.WriteLine("New Stack: " + originalStack);
            Console.WriteLine();

            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine(OrderedQ(q));
            Console.WriteLine("New Queue: " + q);
            Console.WriteLine();

            
        }

        public static bool OrderedStack(Stack<int> stack)
        {
            bool ordered = true;
            int prev = stack.Pop();
            Stack<int> temp = new Stack<int>() ;
            temp.Push(prev);
            while(!stack.IsEmpty())
            {
                int curr = stack.Pop();
                if (curr > prev) // (Asc <), (Dec >)
                    ordered = false;
                prev = curr;
                temp.Push(curr);
            }
            while(!temp.IsEmpty()) 
                stack.Push(temp.Pop());
            return ordered;
        }
        public static bool OrderedQ(Queue<int> q)
        {
            bool ordered = true;
            int prev = q.Remove();
            Queue<int> temp = new Queue<int>() ;
            temp.Insert(prev);
            while(!q.IsEmpty())
            {
                int curr = q.Remove();
                if (curr < prev) // (Asc <), (Dec >)
                    ordered = false;
                prev = curr;
                temp.Insert(curr);
            }
            while(!temp.IsEmpty()) 
                q.Insert(temp.Remove());
            return ordered;
        }

    }
}
