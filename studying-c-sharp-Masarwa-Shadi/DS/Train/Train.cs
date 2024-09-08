using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Train
{
    public class Train
    {
        private Katar katar;
        Stack<Crone> crones = new Stack<Crone>();
        private int numOfCrones = 0;

        public Train(Katar katar, int numOfCrones)
        {
            this.katar = katar;
            this.numOfCrones = numOfCrones;
        }

        public override string ToString()
        {
            string str = $"Train: Num of crones: {numOfCrones}\n";
            str += katar.ToString()+"\n";
            Crone tempCrone = null;
            Stack<Crone> tempCrones = new Stack<Crone>();
            while (!crones.IsEmpty())
            {
                tempCrone = crones.Pop();
                str += $"\t{tempCrone.ToString()}\n";
                tempCrones.Push(tempCrone);
            }
            while (!tempCrones.IsEmpty())
                crones.Push(tempCrones.Pop());
            return str;
        }

        public void AddCrone(Crone crone)
        {
            crones.Push(crone);
            numOfCrones++;
            Console.WriteLine($"Crone ({crone.Id}) Was Added successfully");
        }

        public void DeleteCrone(int id)
        {
            Stack<Crone> tempCrones = new Stack<Crone>();
            Crone tempCrone = null;
            while (!crones.IsEmpty())
            {
                tempCrone = crones.Pop();
                if (tempCrone.Id != id)
                    tempCrones.Push(tempCrone);
                else
                {
                    if (tempCrone.GetPassengers() != 0)
                    {
                        Console.WriteLine($"Crone ({tempCrone.Id}) has ({tempCrone.GetPassengers()}) Passengers and can't be deleted");
                        tempCrones.Push(tempCrone);
                    }
                    else
                    {
                        numOfCrones--;
                        Console.WriteLine($"Crone ({id}) Was deleted successfully");
                    }
                }
            }
            while (!tempCrones.IsEmpty())
                crones.Push(tempCrones.Pop());
        }

        public Train ReduceCrones(Katar newKatar)
        {
            int totalPassengers = 0;
            Stack<Crone> tempCrones = new Stack<Crone>();
            Crone tempCrone = null;
            
            //Calaculate num of passengers in all crones
            while (!crones.IsEmpty())
            {
                tempCrone = crones.Pop();
                totalPassengers += tempCrone.GetPassengers();
                tempCrone.SetPassengers(0);
                tempCrones.Push(tempCrone);
            }
            
            while (!tempCrones.IsEmpty())
            {
                tempCrone = tempCrones.Pop();
                if (totalPassengers >= 50)
                {
                    tempCrone.SetPassengers(50);
                    totalPassengers -= 50;
                }
                else
                {
                    tempCrone.SetPassengers(totalPassengers);
                    totalPassengers = 0;
                }
                crones.Push(tempCrone);
            }

            Train newTrain = new Train(newKatar, 0);
            while (!crones.IsEmpty())
            {
                tempCrone = crones.Pop();
                if (tempCrone.GetPassengers() == 0)
                {
                    newTrain.crones.Push(tempCrone);
                    newTrain.numOfCrones++;
                }
                else
                    tempCrones.Push(tempCrone);
            }
            while (!tempCrones.IsEmpty())
                crones.Push(tempCrones.Pop());

            return newTrain;

        }

    }
}
