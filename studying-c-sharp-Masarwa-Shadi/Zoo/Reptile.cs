using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Reptile:Animal
    {
        private double tailLong;

        public Reptile(string name, int age, bool apexPredator, int caloriesForMeel, double tailLong) : base(name, age, apexPredator, caloriesForMeel)
        {
            this.tailLong=tailLong;
        }
    }
}
