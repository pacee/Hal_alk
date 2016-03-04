using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halado_alk_hazi1
{
    abstract class Animal : IPrintable
    {
        public string size { get;  private set; }
        public string color { get; private set; }
        public int legs { get; private set; }
        public bool canFly { get; private set; }
        public bool canSwim { get; private set; }
        public string sound { get; private set; }

        public Animal(string Size, string Color, int Legs, bool CanFly, bool CanSwim, string Sound){
            this.size = Size;
            this.color = Color;
            this.legs = Legs;
            this.canFly = canFly;
            this.canSwim = CanSwim;
            this.sound = Sound;
        }

        public string makeSound(){
            return sound;
        }

        public virtual string print(){
            return size + ", " + color;
        }
    }
}
