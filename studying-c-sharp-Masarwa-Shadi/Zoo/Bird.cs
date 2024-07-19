using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Bird : Animal, IAnimal,IDance, ISing
    {
        private int flyHeight;
        private double wingsLong;

        public Bird(string name, int age, bool apexPredator, int caloriesForMeel, int flyHeight, double wingsLong) : base(name, age, apexPredator, caloriesForMeel)
        {
            this.flyHeight=flyHeight;
            this.wingsLong=wingsLong;
        }

        public override int Eat()
        {
            return base.Eat()/10;
        }

        public void Sing()
        {
            Console.WriteLine("Bird is singing...");
        }

        public void Dance()
        {
            Console.WriteLine("The bird is dancing...");
        }
    }
}
