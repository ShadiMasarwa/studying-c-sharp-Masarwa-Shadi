using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Snake : Reptile, IDance
    {
        private bool poisonous;

        public Snake(string name, int age, bool apexPredator, int caloriesForMeel, double tailLong, bool poisonous) : base(name, age, apexPredator, caloriesForMeel, tailLong)
        {
            this.poisonous = poisonous;
        }

        public void Dance()
        {
            Console.WriteLine("The snake is dancing...");
        }
    }
}
