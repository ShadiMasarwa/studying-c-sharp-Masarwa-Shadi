using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Exception
{
    class ExceptionDemo
    {
        public static void RunMe()
        {
            try
            {
                //int x = 0;
                //Console.WriteLine(5/x);
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("An Exception occured, but we will continue any way!!!");
            }

            Console.WriteLine("Told ya, we are continuing....");
            Console.ReadKey();
        }
    }
}
