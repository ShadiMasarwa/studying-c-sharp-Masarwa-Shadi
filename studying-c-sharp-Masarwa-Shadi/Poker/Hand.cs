namespace studying_c_sharp_Masarwa_Shadi.Poker
{
    public class Hand
    {
        private Card[] hand1 = new Card[5];
        private Card[] hand2 = new Card[5];

        public Hand(string hands)
        {
            hand1 = GenerateHand(hands.Substring(0, 14).Trim().Split(' '));
            hand2 = GenerateHand(hands.Substring(15).Trim().Split(' '));

        }

        public Card[] GenerateHand(string[] userCards)
        {
            Card[] hand = new Card[5];
            if (userCards.Length != 5)
            {
                return null;
            }
            for (int i = 0; i < userCards.Length; i++)
            {
                char num = userCards[i][0];
                char suit = userCards[i][1];
                if (!(suit == 'D' || suit == 'H' || suit == 'C' || suit == 'S'))
                {
                    return null;
                }

                if (num == 'A' || num == 'J' || num == 'Q' || num == 'K' || num == 'T' || (num - '0' >= 1 && num - '0' <= 9))
                {
                    Card card = new Card(num.ToString(), suit.ToString());
                    hand[i] = card;
                }
                else
                {
                    return null;
                }
            }
            return hand;
        }

        public Card[] GetHand1()
        {
            return this.hand1;
        }
        public Card[] GetHand2()
        {
            return this.hand2;
        }

        public override string ToString()
        {

            if (this.hand1 == null)
                return "[First hand has wrong cards]";
            if (this.hand2 == null)
                return "[Second hand has wrong cards]";

            string str1 = "[";
            string str2 = "[";
            for (int i = 0; i < this.hand1.Length - 1; i++)
            {
                str1 += this.hand1[i].ToString() + ", ";
                str2 += this.hand2[i].ToString() + ", ";
            }
            str1 += this.hand1[4] + "]";
            str2 += this.hand2[4] + "]";
            string output = $"First Hand:  {str1}\nSecond Hand: {str2}";
            return output;
        }
    }
}
