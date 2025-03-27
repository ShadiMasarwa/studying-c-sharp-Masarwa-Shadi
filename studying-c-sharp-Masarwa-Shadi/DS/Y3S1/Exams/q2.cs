using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Exams
{
    public class q2
    {

    }

    public class House
    {
        private int numOfRooms;
        private double size;
        private string address;
        private bool isForRent;

        public House(int numOfRooms, double size, string address, bool isForRent)
        {
            this.numOfRooms = numOfRooms;
            this.size = size;
            this.address = address;
            this.isForRent = isForRent;
        }

        public int NumOfRooms { get => numOfRooms; set => numOfRooms = value; }
        public double Size { get => size; set => size = value; }
        public string Address { get => address; set => address = value; }
        public bool IsForRent { get => isForRent; set => isForRent = value; }

        public double CompareSize(House house)
        {
            return Math.Max(this.size, house.Size);
        }
    }

    public class Maagar
    {
        private House[] arrHouse;
        private int houseCount;

        public House[] ArrHouse { get => arrHouse; set => arrHouse = value; }
        public int HouseCount { get => houseCount; set => houseCount = value; }

        public Maagar()
        {
            arrHouse = new House[200];
            houseCount = 0;
        }

        public bool CheckIfForRent(string address)
        {
            for (int i = 0; i < houseCount; i++)
                if (arrHouse[i].Address == address && arrHouse[i].IsForRent)
                    return true;
            return false;
        }

        public int HousesForRentWith5Rooms()
        {
            int count = 0;
            for (int i = 0; i < houseCount; i++)
                if (arrHouse[i].NumOfRooms == 5 && arrHouse[i].IsForRent)
                    count++;
            return count;
        }
    }
}
