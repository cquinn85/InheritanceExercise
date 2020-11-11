using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        // DONE: Create a class Reptile
        // DONE: Set this class to inherit from your Animal Class
        public Reptile()
        {
            IsAlive = true;
            LegCount = 4;
            Age = 0;
            LandSeaAir = "Land";
        }

           
        // DONE: give this class 4 members that are specific to Reptile
        public bool HasScales { get; set; }
        public bool IsVenomous { get; set; }
        public string Habitat { get; set; }
        public bool IsCarnivor { get; set; }
    }
}
