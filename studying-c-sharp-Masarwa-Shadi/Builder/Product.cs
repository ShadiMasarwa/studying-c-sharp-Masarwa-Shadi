using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Builder
{
    public class Product
    {
        protected string name;
        protected double price;




        public override string ToString()
        {
            return $"Product:[name = {name}, price = {price}";

        }
    }
}
