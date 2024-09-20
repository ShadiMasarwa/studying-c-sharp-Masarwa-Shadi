using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Builder
{
    class BisliBuilder:Product , IProduct
    {
        public void BuildName()
        {
            base.name = "Bisli";
        }

        public void BuildPrice()
        {
            base.price = 3.5;
        }
                
        public BisliBuilder Build()
        {
            BisliBuilder bisly = new BisliBuilder();
            bisly.BuildPrice();
            bisly.BuildName();
            return bisly;
        }
    }
}
