using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.Inheritance
{
    public class ElectricProducts
    {
        private int id;
        private string manufacture;
        private string color;
        private double weight;

        public ElectricProducts(int id, string manufacture, string color, double weight)
        {
            this.id = id;
            this.manufacture = manufacture;
            this.color = color;
            this.weight = weight;
        }
    }

    public class Screen : ElectricProducts
    {
        private double width;
        private double height;
        private string model;

        public Screen(double width, double height, string model):base(0, "NA", "NA", 0)
        {
            this.width = width;
            this.height = height;
            this.model = model;
        }
    }

    public class TV : Screen
    {
        private string name;
        private bool onOff;
        private int numOfChanels;
        private bool smart;
        private string oS;

        public TV(string name, bool onOff, int numOfChanels, bool smart, string oS): base(100, 100, "Xiomi")
        {
            this.name = name;
            this.onOff = onOff;
            this.numOfChanels = numOfChanels;
            this.smart = smart;
            this.oS = oS;
        }

        public void PrintScreen()
        {
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("On/Off: "+onOff);
            Console.WriteLine("Num of chanels: " +numOfChanels);
            Console.WriteLine("Smart: " + smart);
            Console.WriteLine("Os: " + oS);
        }
    }

    public class GameConsole : ElectricProducts
    {
        protected int memory;
        protected bool portable;
        protected int gpuPower;

        public GameConsole(int memory, bool portable, int gpuPower): base(0,"NA", "NA", 0)
        {
            this.memory = memory;
            this.portable = portable;
            this.gpuPower = gpuPower;
        }
    }

    public class PlayStation : GameConsole
    {
        private int numOfJoysticks;

        public PlayStation(int numOfJoysticks): base(100, false, 200)
        {
            this.numOfJoysticks = numOfJoysticks;
        }

        public  void PrintDetails()
        {
            Console.WriteLine("Num of joysticks: " + numOfJoysticks);
            Console.WriteLine("Memory: " + base.memory);
            Console.WriteLine("Portable: " + base.portable);
            Console.WriteLine("GPU: " + base.gpuPower);
        }
    }

    public class Keyboard: ElectricProducts
    {
        private bool standard;
        private bool hasHebrew;
        private bool hasArabic;

        public Keyboard(bool standard, bool hasHebrew, bool hasArabic): base(125, "Logitec", "White", 150)
        {
            this.standard = standard;
            this.hasHebrew = hasHebrew;
            this.hasArabic = hasArabic;
        }
    }
}
