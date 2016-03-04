using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halado_alk_hazi1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dogs
            List<Dog> dogs = new List<Dog>();

            dogs.Add(new Dog("XS", "White", 4, false, false, "Weak woof", true));
            dogs.Add(new Dog("S", "Brown", 4, false, false, "Weak woof", true));
            dogs.Add(new Dog("M", "Black", 4, false, false, "Woof", true));
            dogs.Add(new Dog("L", "Blonde", 4, false, false, "Deep woof", false));
            dogs.Add(new Dog("XL", "Grey", 4, false, false, "Deeper woof", false));

            foreach (var dog in dogs){
                Console.WriteLine(dog.print());
            }
            #endregion

            #region Fishes
            List<Fish> fishes = new List<Fish>();

            fishes.Add(new Fish("XS", "Gold", 0, false, true, "Gaping", true));
            fishes.Add(new Fish("S", "Grey", 0, false, true, "Gaping", true));
            fishes.Add(new Fish("M", "Deep grey", 0, false, true, "Gaping", true));
            fishes.Add(new Fish("L", "Silver", 0, false, true, "Gaping", false));
            fishes.Add(new Fish("XL", "Black", 0, false, true, "Gaping", false));

            Console.WriteLine();
            foreach (var fish in fishes){
                Console.WriteLine(fish.print());
            }
            #endregion



            Console.Read();
        }
    }
}
