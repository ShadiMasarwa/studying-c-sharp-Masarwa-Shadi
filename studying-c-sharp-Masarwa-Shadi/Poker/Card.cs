using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Poker
{
    public class Card
    {
        private string num;
        private string suit;

        public Card(string num, string suit)
        {
            this.num = num;
            this.suit = suit;
        }

        public override string ToString()
        {
            return num+suit;
        }
    }
}
