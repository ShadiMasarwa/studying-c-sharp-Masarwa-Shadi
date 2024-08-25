using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q6
    {
        public int FindPlace(Stack<char> stck, char ch)
        {
            Stack<char> backup = new Stack<char>();
            int distance = -1;
            while (!stck.IsEmpty())
            {
                distance++;
                char c = stck.Pop();
                backup.Push(c);
                if (c == ch)
                    return distance;
            }
            return -1;
        }
    }
}
