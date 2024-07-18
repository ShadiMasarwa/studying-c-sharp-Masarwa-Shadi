using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Crocodile : Reptile
    {
        private bool dentalCare;

        public Crocodile(string name, int age, bool apexPredator, int caloriesForMeel, double tailLong, bool dentalCare) : base(name, age, apexPredator, caloriesForMeel, tailLong)
        {
            this.dentalCare=dentalCare;
        }

        public override int Eat()
        {
            return base.Eat()*2;
        }
    }
}
