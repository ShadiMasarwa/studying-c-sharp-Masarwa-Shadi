using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Tv
{
    public class Tv : Element
    {
        //enum colors
        //{
        //    White,
        //    Black,
        //    Gray
        //}
        private double inches;
        private string color;

        public Tv(double inches, string color, string name, bool hasFrame, bool canBeHange):base(name, hasFrame, canBeHange)
        {
            this.inches = inches;
            this.color = color;
        }

        public override void Hange()
        {
            Console.WriteLine("Tv can be hange on wall");
        }
        public override void Show()
        {
            Console.WriteLine("Tv can show multiple images");
        }


    }
}
