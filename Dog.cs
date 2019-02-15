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

