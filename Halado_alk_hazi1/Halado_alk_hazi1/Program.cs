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
            dogs.Add(new Dog("M", "Black", 4, false, true, "Woof", true));
            dogs.Add(new Dog("L", "Blonde", 4, false, true, "Deep woof", false));
            dogs.Add(new Dog("XL", "Grey", 4, false, true, "Deeper woof", false));

            foreach (var dog in dogs){
                Console.WriteLine(dog.print());
            }
            #endregion

            Console.WriteLine();

            #region Fishes
            List<Fish> fishes = new List<Fish>();

            fishes.Add(new Fish("XS", "Gold", 0, false, true, "Blob", true));
            fishes.Add(new Fish("S", "Grey", 0, false, true, "Blob", true));
            fishes.Add(new Fish("M", "Deep grey", 0, false, true, "Blob", true));
            fishes.Add(new Fish("L", "Silver", 0, false, true, "Blob", false));
            fishes.Add(new Fish("XL", "Black", 0, false, true, "Blob", false));


            foreach (var fish in fishes){
                Console.WriteLine(fish.print());
            }
            #endregion

            Console.WriteLine();

            #region Birds

            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird("XS", "Blue", 2, true, false, "Peep", false, false));
            birds.Add(new Bird("S", "Grey", 2, true, false, "Coo", false, true));
            birds.Add(new Bird("M", "Brown", 2, true, false, "Weee", true, false));
            birds.Add(new Bird("L", "White", 2, true, true, "Wee", false, false));
            birds.Add(new Bird("XL", "Black", 2, false, false, "Grr", false, false));

            foreach (var bird in birds){
                Console.WriteLine(bird.print());
            }
            #endregion

            Console.WriteLine();

            #region Snakes

            List<Snake> snakes = new List<Snake>();

            snakes.Add(new Snake("XS", "Red-black", 0, false, false, "SssSssS", true));
            snakes.Add(new Snake("S", "Grey", 0, false, false, "SssSssS", false));
            snakes.Add(new Snake("M", "Black", 0, false, false, "SssSssS", true));
            snakes.Add(new Snake("L", "Deep green", 0, false, true, "SssSssS", false));
            snakes.Add(new Snake("XL", "Brown", 0, false, true, "SssSssS", false));

            foreach (var snake in snakes){
                Console.WriteLine(snake.print());
            }

            Snake.compareBy = 0;
            snakes.Sort();

            Console.WriteLine();
            Console.WriteLine("Snakes sorted by size:");

            foreach (var snake in snakes){
                Console.WriteLine(snake.print());
            }

            Snake.compareBy = 1;
            snakes.Sort();

            Console.WriteLine();
            Console.WriteLine("Snakes sorted by venomous:");
            foreach (var snake in snakes){
                Console.WriteLine(snake.print());
            }
            #endregion



            Console.WriteLine();
            Console.WriteLine("All animals:");
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog("L", "Brown", 4, false, true, "woof", true));

            animals.AddRange(dogs);
            animals.AddRange(fishes);
            animals.AddRange(birds);
            animals.AddRange(snakes);

            foreach (var item in animals){
                Console.WriteLine(item.print());
            }

            Console.WriteLine();
            Console.WriteLine("Animal sounds:");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.makeSound());
            }



            Console.Read();

            
        }
    }
}



