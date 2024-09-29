using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Test2024
{
    public class Q1
    {
        public static Queue<int> SumLongNumbers(Queue<int> num1, Queue<int> num2)
        {
            Stack<int> Result = new Stack<int>();
            Queue<int> temp1 = new Queue<int>();
            Queue<int> temp2 = new Queue<int>();
            int ten = 0;

            while (!num1.IsEmpty())
            {
                int sum = 0;
                if (num2.IsEmpty())
                {
                    int num = num1.Remove();
                    temp1.Insert(num);
                    sum = num + ten;
                    if (sum <= 9)
                    {
                        Result.Push(sum);
                        ten = 0;
                    }
                    else
                    {
                        Result.Push(sum - 10);
                        ten = 1;
                    }
                }
                else
                {
                    int n1 = num1.Remove();
                    int n2 = num2.Remove();
                    int tempSum = n1 + n2 + ten;
                    if (tempSum <= 9)
                    {
                        Result.Push(tempSum);
                        ten = 0;
                    }
                    else
                    {
                        Result.Push(tempSum - 10);
                        ten = 1;
                    }
                    temp1.Insert(n1);
                    temp2.Insert(n2);
                }
            }
            if (!num2.IsEmpty())
            {
                while (num2.IsEmpty())
                {
                    int num = num2.Remove();
                    temp2.Insert(num);
                    if((num + ten) <= 9)
                    {
                        ten = 0;
                        Result.Push(num);
                    }
                    else
                    {
                        ten = 1;
                        Result.Push(num - 10);
                    }
                }
            }
            if (ten == 1)
            {
                Queue<int> temp = new Queue<int>();
                while (!Result.IsEmpty())
                    temp.Insert(Result.Pop());
                temp.Insert(1);
                while (!temp.IsEmpty())
                    Result.Push(temp.Remove());

            }
            while (!temp1.IsEmpty())
                num1.Insert(temp1.Remove());
            while (!temp2.IsEmpty())
                num2.Insert(temp2.Remove());
            Queue<int> final = new Queue<int>();
            while (!Result.IsEmpty())
                final.Insert(Result.Pop());

            return final;
        }

        private static Queue<int> Reverse(Queue<int> q)
        {
            Queue<int> reversed = new Queue<int>();
            while (!q.IsEmpty())
                reversed.Insert(q.Remove());
            return reversed;
        }
    }
}
