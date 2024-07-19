using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Tv
{
    public abstract class Element
    {
        private string name;
        private bool hasFrame;
        private bool canBeHange;

        public Element(string name, bool hasFrame, bool canBeHange)
        {
            this.name = name;
            this.hasFrame = hasFrame;
            this.canBeHange = canBeHange;
        }

        public abstract void Hange();
        public abstract void Show();


    }
}
