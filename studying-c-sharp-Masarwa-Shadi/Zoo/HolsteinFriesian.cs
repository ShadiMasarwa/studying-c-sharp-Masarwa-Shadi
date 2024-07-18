using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class HolsteinFriesian : Cow
    {
        private int weight;

        public HolsteinFriesian(string name, int age, bool apexPredator, int caloriesForMeel, int caloriesInMilk, int pregnancyMonths, int numOflitters, int weight) : base(name, age, apexPredator, caloriesForMeel, caloriesInMilk, pregnancyMonths, numOflitters)
        {
            this.weight = weight;
        }
    }
}
