using System;


namespace studying_c_sharp_Masarwa_Shadi.DS.Train
{
    public class Manager
    {
        public static void RunMe()
        {
            Random rnd = new Random();
            Katar katar1 = new Katar(11, 2020);
            Train train1 = new Train(katar1, 0);
            for(int i=1; i<=10; i++)
            {
                Crone newCrone = new Crone(100 + i, rnd.Next(5, 51));
                train1.AddCrone(newCrone);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine(train1.ToString());
            Console.WriteLine();
            Crone crone111 = new Crone(111, 80);
            Crone crone112 = new Crone(112, 0);
            train1.AddCrone(crone111);
            train1.AddCrone(crone112);
            Console.WriteLine(train1.ToString());
            Console.WriteLine();
            train1.DeleteCrone(111);
            train1.DeleteCrone(112);
            Console.WriteLine(train1.ToString());
            Console.WriteLine();

            Katar katar2 = new Katar(22, 2024);
            Train train2 = train1.ReduceCrones(katar2);

            Console.WriteLine("\n\nAfter Reducing:");
            Console.WriteLine(train1.ToString());
            Console.WriteLine(train2.ToString());

        }
    }
}
