using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Zoo
{
    public class Zoo
    {
        public static void RunMe()
        {
            Parrot parrot = new Parrot("Coco", 1, false, 10, 200, 35, true);
            HolsteinFriesian holsteinFriesian = new HolsteinFriesian("Momo", 10, false, 1000, 300, 6, 30, 560);
            Hipo hipo = new Hipo("Hiphop", 31, true, 2400, 1000, 8, 45);
            Snake snake = new Snake("Python", 2, false, 85, 28, true);
            Crocodile crocodile = new Crocodile("Aligator", 14, true, 500, 125, true);
            Parrot parrot2 = new Parrot("Ricko", 2, false, 15, 185, 32, true);
            HolsteinFriesian holsteinFriesian2 = new HolsteinFriesian("Meemo", 5, false, 1250, 400, 6, 10, 650);
            Hipo hipo2 = new Hipo("Hipotamtam", 25, true, 2800, 850, 8, 55);
            Snake snake2 = new Snake("Cobra", 1, false, 100, 15, true);
            Crocodile crocodile2 = new Crocodile("Amazon", 35, true, 1000, 215, false);

            Animal[] animals = { parrot, parrot2, holsteinFriesian, holsteinFriesian2, hipo, hipo2, snake, snake2, crocodile, crocodile2 };
            Console.WriteLine(GetTotalCalories(animals));
            MakeSound(animals);
            MakeDance(animals);
            Console.WriteLine("Hipo with max fat is: " + MaxFat(animals));

        }

        private static int GetTotalCalories(Animal[] animals)
        {
            int sum = 0;
            foreach (Animal animal in animals)
            {
                sum += animal.Eat();
            }
            return sum;
        }

        private static void MakeSound(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                if (animal is Bird)
                {
                    Bird bird = (Bird)animal;
                    bird.Sing();
                }
            }
        }

        private static void MakeDance(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                if (animal is Snake)
                {
                    Snake snack = (Snake)animal;
                    snack.Dance();
                }
                if (animal is Bird)
                {
                    Bird bird = (Bird)animal;
                    bird.Dance();
                }

            }
        }

        private static string MaxFat(Animal[] animals)
        {
            double maxFat = -1;
            string name = "";
            foreach (Animal animal in animals)
            {
                if (animal is Hipo)
                {
                    Hipo hipo= (Hipo)animal;
                    if (hipo.FatPecentage > maxFat)
                    {
                        maxFat = hipo.FatPecentage;
                        name = hipo.Name;
                    }
                }
            }
            return name;
        }
    }
}
