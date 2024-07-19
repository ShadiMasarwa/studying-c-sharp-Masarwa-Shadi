using studying_c_sharp_Masarwa_Shadi.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Park
    {
        private Animal[] animal = null;
        private int numOfAnimals;

        public Park()
        {
            animal = new Animal[1000];
            numOfAnimals = 0;
        }

        public  void AddAnimal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("***********************");
                Console.WriteLine("*    Please choose    *");
                Console.WriteLine("* 1. Add a Mammal     *");
                Console.WriteLine("* 2. Add a Bird       *");
                Console.WriteLine("* 3. Add a Reptile    *");
                Console.WriteLine("* 0. Exit             *");
                Console.WriteLine("***********************");
                Console.WriteLine("Enter Choice => ");
                int choice = Console.ReadKey().KeyChar-'0';
                switch (choice)
                {
                    case 1:
                        animal[numOfAnimals++] = GetMammalInfo();
                        break;
                    case 2:
                        animal[numOfAnimals++] = GetBirdInfo();
                        break;
                    case 3:
                        animal[numOfAnimals++] = GetReptileInfo();
                        break;
                    case 0:
                        return;
                }
            }

        }
        private static Animal GetAnimalInfo()
        {
            
            Console.Write("Enter Name => ");
            string name = Console.ReadLine();
            Console.Write("Enter Age => ");
            int age = int.Parse(Console.ReadLine());
            bool apexPredator = false;
            while (true)
            {
                Console.Write("Is It Apex Predator (Y/N) => ");
                char choice = Console.ReadKey().KeyChar;
                if (choice == 'Y' || choice == 'y')
                {
                    apexPredator = true;
                    break;
                }
                if (choice == 'N' || choice == 'n')
                {
                    apexPredator = false;
                    break;
                }
            }
            Console.Write("Enter Calories for meal => ");
            int caloriesPerMeal = int.Parse(Console.ReadLine());
            

            Animal animal = new Animal(name, age, apexPredator, caloriesPerMeal);
            return animal;
        }

        private static Mammal GetMammalInfo()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("*       Mammal Info        *");
            Console.WriteLine("****************************");
            Animal mammal = GetAnimalInfo();
            Console.Write("Enter Calories in milk => ");
            int caloriesInMilk = int.Parse(Console.ReadLine());
            Console.Write("Enter Months of Pregnancy => ");
            int pregnancyMonths = int.Parse(Console.ReadLine());
            return new Mammal(mammal.Name, mammal.Age, mammal.ApexPredator, mammal.CaloriesForMeel, caloriesInMilk, pregnancyMonths);
        }

        private static Bird GetBirdInfo()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("*       Bird Info        *");
            Console.WriteLine("****************************");
            Animal bird = GetAnimalInfo();
            Console.Write("Enter Fly Height => ");
            int flyHeight = int.Parse(Console.ReadLine());
            Console.Write("Enter Wings Long => ");
            double wingsLong = double.Parse(Console.ReadLine());
            return new Bird(bird.Name, bird.Age, bird.ApexPredator, bird.CaloriesForMeel, flyHeight, wingsLong);
        }

        private static Reptile GetReptileInfo()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("*       Reptile Info       *");
            Console.WriteLine("****************************");
            Animal reptile = GetAnimalInfo();
            Console.Write("Enter Tail Long => ");
            int tailLong = int.Parse(Console.ReadLine());
            return new Reptile(reptile.Name, reptile.Age, reptile.ApexPredator, reptile.CaloriesForMeel, tailLong);
        }

    }
}
