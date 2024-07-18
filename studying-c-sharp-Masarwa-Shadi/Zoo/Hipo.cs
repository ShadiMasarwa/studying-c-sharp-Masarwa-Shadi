using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Hipo : Mammal
    {
        private double fatPecentage;

        public Hipo(string name, int age, bool apexPredator, int caloriesForMeel, int caloriesInMilk, int pregnancyMonths, double fatPecentage) : base(name, age, apexPredator, caloriesForMeel, caloriesInMilk, pregnancyMonths)
        {
            this.fatPecentage = fatPecentage;
        }

        public double FatPecentage { get => fatPecentage; set => fatPecentage = value; }
    }
}
