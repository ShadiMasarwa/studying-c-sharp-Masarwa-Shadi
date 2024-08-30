using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Singleton
{
    public class Store
    {
        private int price;
        private static Store instance = null;
        private Store() { }
        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int value)
        {
            price=value;
        }

        public static Store GetInstance()
        {
            if (instance == null)
                instance = new Store();
            return instance;
        }

        
    }

    public class Fruit
    {
        protected int weight;
        public Fruit(int val) { weight = val; }
        public int GetWeight() { return weight; }
    }
    public class Apple : Fruit
    {
        private string color;
        public Apple(int val, string col) : base(val)
        {
            color = col;
        }
        public bool ValidWeight()
        {
            return weight > 80 && weight < 140;
        }
    }
}
