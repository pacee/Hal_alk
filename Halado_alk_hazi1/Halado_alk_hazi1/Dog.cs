using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halado_alk_hazi1
{
    class Dog : Animal, IPrintable
    {
        public bool indoor { get; private set; }

        public Dog(string Size, string Color, int Legs, bool CanFly, bool CanSwim, string Sound, bool Indoor) : base(Size, Color, Legs, CanFly, CanSwim, Sound)
        {
            this.indoor = Indoor;
        }

        public override string print()
        {
            return base.print() + ", Indoor dog: " + indoor.ToString();
        }
    }
}
