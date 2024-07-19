using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Animal: IAnimal
    {
        private string name;
        private int age;
        private bool apexPredator;
        private int caloriesForMeel;

        public Animal(string name, int age, bool apexPredator, int caloriesForMeel)
        {
            this.name = name;
            this.age = age;
            this.apexPredator = apexPredator;
            this.caloriesForMeel = caloriesForMeel;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool ApexPredator { get => apexPredator; set => apexPredator = value; }
        public int CaloriesForMeel { get => caloriesForMeel; set => caloriesForMeel = value; }

        public virtual int Eat()
        {
            return caloriesForMeel * 3;
        }
    }
}
