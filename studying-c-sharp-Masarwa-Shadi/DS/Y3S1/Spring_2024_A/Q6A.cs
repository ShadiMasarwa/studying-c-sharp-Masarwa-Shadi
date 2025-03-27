using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_A
{
    public class Q6A
    {
        public static bool StartWith(Queue<int> q1,Queue<int> q2)
        {
            if (Size(q1)>Size(q2))
                return false;
            Queue<int> q = Clone(q1); // q1 שימור ערכי התור
            while(!q.IsEmpty())
            {
                int x1 = q.Remove();
                int x2 = q2.Remove();
                if(x1 != x2)
                    return false;
            }
            return true;
        }

        public static bool Duplication(Queue<int> q1,Queue<int> q2)
        {
            if(Size(q2) % Size(q1)!=0 || Size(q2) > Size(q2))
                return false;
            bool dublicated = true;
            while (!q2.IsEmpty())
            {
                Queue<int> temp = new Queue<int>();
                for (int i = 0; i < Size(q1); i++)
                    temp.Insert(q2.Remove());
                dublicated = StartWith(q1, temp);
                if(!dublicated)
                    return false;
            }
            return true;
        }

        public static int Size(Queue<int> q)
        {
            int count = 0;
            Queue<int> temp = Clone(q);
            while (!temp.IsEmpty())
            {
                temp.Remove();
                count++;
            }
            return count;
        }

        public static Queue<int> Clone(Queue<int> q)
        {
            Queue<int> cloned = new Queue<int>();
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                int x = q.Remove();
                cloned.Insert(x);
                temp.Insert(x);
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return cloned;
        }

    }
}
