using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Train
{
    public class Katar
    {
        private int id;
        private int year;

        public Katar(int id, int year)
        {
            this.id = id;
            this.year = year;
        }

        public int Id { get => id; set => id = value; }
        public int Year { get => year; set => year = value; }

        public override string ToString()
        {
            return $"   Katar Id: {id}, Year: {year}";
        }
    }
}
