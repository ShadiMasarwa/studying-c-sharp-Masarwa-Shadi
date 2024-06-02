using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studying_c_sharp_Masarwa_Shadi.DS;

namespace studying_c_sharp_Masarwa_Shadi.T1
{
    class Q1
    {
        public static Node<int> Even(Node<int> lst)
        {
            Node<int> pos = lst;
            Node<int> newlst = null;
            while(pos != null)
            {
                if(pos.GetValue() % 2 == 0)
                {
                    if (newlst==null)
                        newlst = new Node<int>(pos.GetValue());
                    else
                        newlst = new Node<int>(pos.GetValue(), newlst);
                }
                pos = pos.GetNext();
                
            }
            return newlst;
        } 
    }
}
