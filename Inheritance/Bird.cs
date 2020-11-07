using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Owl()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 0;
        }

        public string FurColor { get; set; }
        public bool CanFly { get; set; }
        public bool LaysEggs { get; set; }
        public double BeakLength { get; set; }
    }
}
