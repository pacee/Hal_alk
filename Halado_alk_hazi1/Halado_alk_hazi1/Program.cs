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

            Console.WriteLine("Dogs:");
            Console.WriteLine();
            foreach (var dog in dogs){
                Console.WriteLine(dog.print());
            }
            Console.WriteLine();
            #endregion

            #region Fishes
            List<Fish> fishes = new List<Fish>();

            fishes.Add(new Fish("XS", "Gold", 0, false, true, "Blob", true));
            fishes.Add(new Fish("S", "Grey", 0, false, true, "Blob", true));
            fishes.Add(new Fish("M", "Deep grey", 0, false, true, "Blob", true));
            fishes.Add(new Fish("L", "Silver", 0, false, true, "Blob", false));
            fishes.Add(new Fish("XL", "Black", 0, false, true, "Blob", false));

            Console.WriteLine("Fishes:");
            Console.WriteLine();
            foreach (var fish in fishes){
                Console.WriteLine(fish.print());
            }
            Console.WriteLine();
            #endregion


            #region Birds

            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird("XS", "Blue", 2, true, false, "Peep", false, false));
            birds.Add(new Bird("S", "Grey", 2, true, false, "Coo", false, true));
            birds.Add(new Bird("M", "Brown", 2, true, false, "Weee", true, false));
            birds.Add(new Bird("L", "White", 2, true, true, "Wee", false, false));
            birds.Add(new Bird("XL", "Black", 2, false, false, "Grr", false, false));

            Console.WriteLine("Birds:");
            Console.WriteLine();
            foreach (var bird in birds){
                Console.WriteLine(bird.print());
            }
            Console.WriteLine();
            #endregion


            #region Snakes

            List<Snake> snakes = new List<Snake>();

            snakes.Add(new Snake("XS", "Red-black", 0, false, false, "SssSssS", true));
            snakes.Add(new Snake("S", "Grey", 0, false, false, "SssSssS", false));
            snakes.Add(new Snake("M", "Black", 0, false, false, "SssSssS", true));
            snakes.Add(new Snake("L", "Deep green", 0, false, true, "SssSssS", false));
            snakes.Add(new Snake("XL", "Brown", 0, false, true, "SssSssS", false));

            Console.WriteLine("Snakes:");
            Console.WriteLine();
            foreach (var snake in snakes){
                Console.WriteLine(snake.print());
            }
            Console.WriteLine();

            Snake.compareBy = 0;
            snakes.Sort();

            Console.WriteLine("Snakes sorted by size:");
            Console.WriteLine();
            foreach (var snake in snakes){
                Console.WriteLine(snake.print());
            }
            Console.WriteLine();

            Snake.compareBy = 1;
            snakes.Sort();

            Console.WriteLine("Snakes sorted by venomous:");
            Console.WriteLine();
            foreach (var snake in snakes){
                Console.WriteLine(snake.print());
            }
            Console.WriteLine();
            #endregion


            #region AllAnimals

            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog("L", "Brown", 4, false, true, "woof", true));

            animals.AddRange(dogs);
            animals.AddRange(fishes);
            animals.AddRange(birds);
            animals.AddRange(snakes);


            Console.WriteLine("All animals:");
            Console.WriteLine();
            foreach (var item in animals){
                Console.WriteLine(item.print());
            }
            Console.WriteLine();

            Console.WriteLine("Animal sounds:");
            Console.WriteLine();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.makeSound());
            }
            Console.WriteLine();
            #endregion


            #region Random
            List<Animal> randomAnimals = new List<Animal>();

            string[] sizes = new string[] { "XS", "S", "M", "L", "XL" };
            string[] colors = new string[] {"White","Black","Brown","Grey","Blond","Silver"};


            int n = 15;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {             
                int x = rnd.Next(0, 4);
                int sizeIndex = rnd.Next(sizes.Length);
                int colorIndex = rnd.Next(colors.Length);
               
                switch (x){
                    case 0 :
                        {
                            randomAnimals.Add(new Dog(sizes[sizeIndex], colors[colorIndex], 2, false, Convert.ToBoolean(rnd.Next(0, 2)), "Wuff", Convert.ToBoolean(rnd.Next(0, 2))));
                        }
                        break;
                    case 1 :
                        {
                            randomAnimals.Add(new Bird(sizes[sizeIndex], colors[colorIndex], 2, Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)), "Peep", Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2))));
                        }
                        break;
                    case 2:
                        {
                            randomAnimals.Add(new Fish(sizes[sizeIndex], colors[colorIndex], 0, false, true, "Blob", Convert.ToBoolean(rnd.Next(0, 2))));
                        }
                        break;
                    case 3:
                        {
                            randomAnimals.Add(new Snake(sizes[sizeIndex], colors[colorIndex], 0, false, Convert.ToBoolean(rnd.Next(0, 2)), "SssSss", Convert.ToBoolean(rnd.Next(0, 2))));
                        }
                        break;
                }    
            }

            Console.WriteLine("Random animals:");
            Console.WriteLine();
            foreach (var animal in randomAnimals)
            {
                Console.WriteLine(animal.print());
            }

            #endregion

            Console.Read();

            
        }
    }
}



