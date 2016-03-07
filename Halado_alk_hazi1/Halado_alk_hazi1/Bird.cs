using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halado_alk_hazi1
{
    class Bird : Animal
    {
        public bool predator { get; private set; }
        public bool cage { get; private set; }

        public Bird(string Size, string Color, int Legs, bool CanFly, bool CanSwim, string Sound, bool Predator, bool Cage) : base(Size, Color, Legs, CanFly, CanSwim, Sound)
        {
            this.predator = Predator;
            this.cage = Cage;
        }

        public override string print(){
            return base.print() + ", Can fly: " + canFly.ToString() + ", Cage bird: " + cage.ToString();
        }


    }
}
