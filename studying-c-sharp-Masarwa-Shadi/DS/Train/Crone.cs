using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Train
{
    public class Crone
    {
        private int id;
        private int passengers;

        public Crone(int id, int passengers)
        {
            this.id = id;
            if (passengers <= 50 && passengers>=0)
            {
                this.passengers = passengers;
            }
            else
            {
                Console.WriteLine("Passengers number must be between 0-50\nNum of passengers was set to 50");
                this.passengers = 50;
            }
        }

        public int Id { get => id; set => id = value; }
        public void SetPassengers(int value)
        {
            passengers = value;
        }
        public int GetPassengers()
        {
            return passengers;
        }

        public override string ToString()
        {
            return $"Crone Id: {id}, Num of passengers: {passengers}";
        }
    }
}
