using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Tv
{
    public class Picture: Element
    {
        private string owner;
        private double price;

        public Picture(string owner, double price, string name, bool hasFrame, bool canBeHange):base(name, hasFrame, canBeHange)
        {
            this.owner = owner;
            this.price = price;
        }

        public override void Hange()
        {
            Console.WriteLine("Picture can be hange on wall");
        }
        public override void Show()
        {
            Console.WriteLine("Picture can show one image only");
        }
    }
}
