using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Parrot : Bird
    {
        private bool talking;

        public Parrot(string name, int age, bool apexPredator, int caloriesForMeel, int flyHeight, double wingsLong, bool talking) : base(name, age, apexPredator, caloriesForMeel, flyHeight, wingsLong)
        {
            this.talking = talking;
        }
    }
}
