using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        // DONE:  Create a class Animal
        
        public Animal()
        {

        }

        // DONE: give this class 4 members that all Animals have in common
        public bool IsAlive { get; set; }
        public int LegCount { get; set; }
        public int Age { get; set; }
        public string LandSeaAir { get; set; }

    }
}
