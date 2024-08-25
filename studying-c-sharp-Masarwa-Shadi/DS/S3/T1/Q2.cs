using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.S3.T1
{
    public class Q2
    {
        public Stack<int> ReverseStack(Stack<int> stck)
        {
            Stack<int> backup = new Stack<int>();
            while (!stck.IsEmpty())
                backup.Push(stck.Pop());
            return backup;
        }
    }
}
