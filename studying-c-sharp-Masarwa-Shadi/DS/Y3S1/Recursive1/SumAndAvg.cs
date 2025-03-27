using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Recursive1
{
    public class SumAndAvg
    {
        public static void RunMe()
        {
            Stack<int> originalStack = new Stack<int>();
            originalStack.Push(1);
            originalStack.Push(2);
            originalStack.Push(3);
       
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);
            q.Insert(4);
            
            Console.WriteLine("Sum");
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine(SumOfStack(originalStack));
            Console.WriteLine("New Stack: " + originalStack);
            Console.WriteLine();

            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine(SumOfQ(q));
            Console.WriteLine("New Queue: " + q);
            Console.WriteLine();

            Console.WriteLine("Avg");
            Console.WriteLine("Original Stack: " + originalStack);
            Console.WriteLine(AvgOfStack(originalStack));
            Console.WriteLine("New Stack: " + originalStack);
            Console.WriteLine();

            Console.WriteLine("Original Queue: " + q);
            Console.WriteLine(AvgOfQ(q));
            Console.WriteLine("New Queue: " + q);
        }

        public static double AvgOfStack(Stack<int> stack)
        {
            int sum = 0;
            int count = 0;
            Stack<int> temp = new Stack<int>();
            while (!stack.IsEmpty())
            {
                temp.Push(stack.Top());
                sum += stack.Pop();
                count++;
            }
            while (!temp.IsEmpty())
                stack.Push(temp.Pop());
            if (count == 0)
                return -1;
            else
                return sum*1.0/count;
        }
        
        public static double AvgOfQ(Queue<int> q)
        {
            int sum = 0;
            int count = 0;
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                temp.Insert(q.Head());
                sum += q.Remove();
                count++;
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            if (count == 0)
                return -1;
            else
                return sum*1.0/count;
        }

        public static int SumOfStack(Stack<int> stack)
        {
            int sum = 0;
            Stack<int> temp = new Stack<int>();
            while (!stack.IsEmpty())
            {
                temp.Push(stack.Top());
                sum += stack.Pop();
            }
            while (!temp.IsEmpty())
                stack.Push(temp.Pop());
            return sum;
        }
        public static int SumOfQ(Queue<int> q)
        {
            int sum = 0;
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                temp.Insert(q.Head());
                sum += q.Remove();
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return sum;
        }
    }
}
