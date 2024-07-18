using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Mammal:Animal
    {
        private int caloriesInMilk;
        private int pregnancyMonths;

        public Mammal(string name, int age, bool apexPredator, int caloriesForMeel, int caloriesInMilk, int pregnancyMonths) : base(name, age, apexPredator, caloriesForMeel)
        {
            this.caloriesInMilk=caloriesInMilk;
            this.pregnancyMonths=pregnancyMonths;
        }

        public override int Eat()
        {
            return base.Eat() + caloriesInMilk;
        }
    }
}
