using System;
using System.IO;

namespace studying_c_sharp_Masarwa_Shadi.Poker
{
    public class ManualTest
    {
        public static void Runme()
        {
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

            string filePath = Path.Combine(projectRoot, "Poker", "input.txt");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    Hand hand = new Hand(line);
                    Console.WriteLine(hand);
                    Console.WriteLine("------------------------");
                }
            }
           
            

            
        }
    }
}
