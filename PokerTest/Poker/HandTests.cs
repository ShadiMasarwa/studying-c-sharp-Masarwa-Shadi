using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_B;

namespace studying_c_sharp_Masarwa_Shadi.Poker.Tests
{
    [TestClass()]
    public class HandTests
    {
        [TestMethod()]
        public void HandTest()
        {
            string[] handsToCheck = 
                {"8C TS KC 9H 4S 7D 2S 5D 3S AF", //AF wrong
                "5C AD 5D AC 9C 7C 5H 8D TD KS",
                "3H 7H 6S KC JS QH TD JC 2D",    //hand 2 with 4 cards only
                "TH 8H 5C QS TC 9H 4D JC KS JS",
                "7C 5H KC RH JD AS KH 4C AD 4S", //RH wrong
                "5H KS 9C 7D 9H 8D 3S 5D 5C AH",
                "6H 4H 5C 3H 2H 3S QH 5S 6S AS"}; 
            
            for (int i=0;  i<handsToCheck.Length; i++)
            {
                Hand hand = new Hand(handsToCheck[i]);
                Console.WriteLine((i+1)+")");
                Console.WriteLine(hand);
                try
                {
                    Assert.IsNotNull(hand.GetHand1());
                    Assert.IsNotNull(hand.GetHand2());
                    Console.WriteLine("✅ PASS");
                }
                catch (AssertFailedException)
                {
                    Console.WriteLine("❌ FAILED");
                    //throw; //uncomment if want to terminate after wrong hand
                }
                Console.WriteLine("-------------------------");
            }
            

        }
    }
}