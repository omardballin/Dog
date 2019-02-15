namespace dog
{
    public enum Gender { Male, Female };

    public class Dog
    {
        public string name;
        public string owner;
        int age;
        public Gender gender;

        public Dog(string Name, string Owner, int Age, Gender Gender)
        {
            name = Name;
            owner = Owner;
            age = Age;
            gender = Gender;
        }

        public void Bark()
        {
            Console.WriteLine("Woof");
        }

        public string Bark(int times)
        {
            string strBarks = "Woof";

            if (times <= 0)
            {
                return "";
            }

            for (int i = 1; i < times; i++)
            {
                strBarks += " Woof";
            }

            return strBarks;
        }

        public string GetTag()
        {
            string strGender1 = gender == Gender.Male ? "His" : "Her";
            string strGender2 = gender == Gender.Male ? "he" : "she";
            string strAgeText = age == 1 ? " year old" : " years old";
             
            return "If lost, call " + owner + ". " + strGender1 + " name is " + name + " and " + strGender2 + " is " + age + strAgeText +".";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dog
{
    class Program
    {
        static void Main()
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            Console.WriteLine(puppy.Bark(3));
            Console.WriteLine(puppy.GetTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            Console.WriteLine(myDog.Bark(1));
            Console.WriteLine(myDog.GetTag());

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

