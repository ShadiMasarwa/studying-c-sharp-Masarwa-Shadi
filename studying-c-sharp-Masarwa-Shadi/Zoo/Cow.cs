using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Cow : Mammal
    {
        private int numOflitters;

        public Cow(string name, int age, bool apexPredator, int caloriesForMeel, int caloriesInMilk, int pregnancyMonths, int numOflitters) : base(name, age, apexPredator, caloriesForMeel, caloriesInMilk, pregnancyMonths)
        {
            this.numOflitters= numOflitters;
        }

        public override int Eat()
        {
            return base.Eat()/4;
        }
    }
}
