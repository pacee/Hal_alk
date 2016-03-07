using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halado_alk_hazi1
{
    class Snake : Animal, IComparable
    {
        public bool venomous { get; private set; }
        public static int compareBy { get; set; }

        public Snake(string Size, string Color, int Legs, bool CanFly, bool CanSwim, string Sound, bool Venomous) : base(Size, Color, Legs, CanFly, CanSwim, Sound)
        {
            this.venomous = Venomous;
        }

        public override string print()
        {
            return base.print() + ", Is venomous: " + venomous.ToString() + ", Can swim: " + canSwim.ToString();
        }

        public int CompareTo(object comp)
        {
            Snake obj = comp as Snake;

            if (obj != null){
                switch (compareBy)
                {
                    case 0:
                        return this.size.CompareTo(obj.size);
                    case 1:
                        return this.venomous.CompareTo(obj.venomous);
                }
            }return -1;
        }
    }
}
