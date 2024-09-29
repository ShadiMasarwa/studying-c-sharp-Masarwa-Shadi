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
            num1 = Reverse(num1);
            num2 = Reverse(num2);
            Queue<int> Result = new Queue<int>();
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
                        Result.Insert(sum);
                        ten = 0;
                    }
                    else
                    {
                        Result.Insert(sum - 10);
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
                        Result.Insert(tempSum);
                        ten = 0;
                    }
                    else
                    {
                        Result.Insert(tempSum - 10);
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
                        Result.Insert(num);
                    }
                    else
                    {
                        ten = 1;
                        Result.Insert(num - 10);
                    }
                }
            }
            if (ten == 1)
            {
                Queue<int> temp = new Queue<int>();
                temp.Insert(1);
                while (!Result.IsEmpty())
                    temp.Insert(Result.Remove());
                while (!temp.IsEmpty())
                    Result.Insert(temp.Remove());

            }
            while (!temp1.IsEmpty())
                num1.Insert(temp1.Remove());
            while (!temp2.IsEmpty())
                num2.Insert(temp2.Remove());
            return Result;
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
