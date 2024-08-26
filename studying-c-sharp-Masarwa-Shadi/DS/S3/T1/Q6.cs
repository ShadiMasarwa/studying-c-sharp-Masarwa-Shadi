using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q6
    {
        public static int FindPlace(Stack<char> stck, char ch)
        {
            Stack<char> backup = new Stack<char>();
            int distance = 0;
            while (!stck.IsEmpty())
            {
                distance++;
                char c = stck.Top();
                if (c == ch)
                    break;
                else
                {
                    backup.Push(c);
                    stck.Pop();
                }
            }
            if(stck.IsEmpty())
                distance=-1;
            while(!backup.IsEmpty())
                stck.Push(backup.Pop());
            return distance;
        }
    }
}
