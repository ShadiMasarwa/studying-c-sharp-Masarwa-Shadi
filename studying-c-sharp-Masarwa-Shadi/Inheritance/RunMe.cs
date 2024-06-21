using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Inheritance
{
    public class RunMe
    {
        public static void Run()
        {
            PlayStation p1 = new PlayStation(4);
            p1.PrintDetails();

            TV tv1 = new TV("Xi098m", false, 1987, true, "android");
            tv1.PrintScreen();
        }
        
    }
}
