using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.Y3S1.Spring_2024_A
{
    public class Q4
    {
    }

    public class Parent
    {
        private string firstName;
        private string lastName;
        public char gender;
        private string city;
        public static int year;

        public Parent(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.gender = 'f'; 
            this.city = "Beer-Sheva"; // Default city
        }

        public Parent(string fName, string lName, char gender)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.gender = gender;
            this.city = "Beer-Sheva"; 
        }

        public static void SetYear(int y)
        {
            year = y;
        }

        public void UpdateCity(string newCity)
        {
            this.city = newCity;
        }

        public string GetName()
        {
            return this.firstName + " " + this.lastName;
        }

        public virtual void PrintDetails()
        {
            if (this.gender == 'f')
                Console.Write("Mother ");
            else
                Console.Write("Father ");
            Console.Write(GetName());
        }

        public void PrintCity()
        {
            Console.WriteLine(" lives in " + this.city);
        }
    }

    public class Child : Parent
    {
        private int age;
        public Child(String fName, String lName, char gender, int age) :
        base(fName, lName, gender)
        {
            this.age = age;
        }
        public Child() : base("David", "Cohen")
        {
            this.age = 13;
            this.gender = 'm';
        }
        public int GetBirthYear()
        {
            return Parent.year - this.age;
        }
        public override void PrintDetails()
        {
            if (this.gender == 'f') Console.Write("Daughter ");
            else Console.Write("Son ");
            Console.Write(GetName() + " was born at " + GetBirthYear());
        }
    }// end of class Child
    public class Driver
    {
        public static void Main1(string[] args)
        {
            Parent.SetYear(2020);
            Parent[] family = new Parent[5];
            family[0] = new Parent("Anna", "Blum");
            family[1] = new Parent("Moshe", "Coehn", 'm');
            family[2] = new Child();
            family[3] = new Child("Dorit", "Levi", 'f', 24);
            family[4] = new Child("Eli", "Coehn", 'm', 30);
            family[3].UpdateCity("Tel-Aviv");
            family[4].UpdateCity("Jerusalem");
            for (int i = 0; i < family.Length; i++)
            {
                family[i].PrintDetails();
                family[i].PrintCity();
            }
        }
    }// end of class Driver
}
