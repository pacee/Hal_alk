using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halado_alk_hazi1
{
    class Fish : Animal
    {
        public bool freshwater { get; private set; }

        public Fish(string Size, string Color, int Legs, bool CanFly, bool CanSwim, string Sound, bool Freshwater) : base(Size, Color, Legs, CanFly, CanSwim, Sound)
        {
            this.freshwater = Freshwater;
        }

        public override string print()
        {
            return base.print() + ", Freshwater: " + freshwater.ToString();
        }
    }
}
