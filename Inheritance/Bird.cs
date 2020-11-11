using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        //DONE:  Create a class Bird
        // DONE: Set this class to inherit from your Animal Class
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 0;
        }
           
        // DONE: give this class 4 members that are specific to Bird
        
        public bool BirdFlies { get; set; }
        public bool Migrates { get; set; }
        public double BeakLength { get; set; }
        public string WingColor { get; set; }
    }
}
