using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Test2024
{
    public class Q3
    {
        public static void FindMax(Trio t)
        {
           
            while (!t.IsEmpty(1))
            {
                if (t.IsEmpty(2))
                    t.Remove(1,2);
                else
                {
                    if (t.Compare(1, 2))
                    {
                        t.Remove(2, 3);
                        t.Remove(1, 2);
                    }
                    else
                    {
                        t.Remove(1, 2);
                        t.Remove(2, 3);
                    }
                }
            }
        }
    }

    public class Trio
    {
        public Stack<int> s1;
        public Stack<int> s2;
        public Stack<int> s3;
        public Trio()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
            s3 = new Stack<int>();
        }
    
        public void Remove(int x, int y)
        {
            
        }

        public bool Compare(int x, int y)
        {
            return true;

        }

        public bool IsEmpty(int x)
        {
            return true;

        }




    }
}
