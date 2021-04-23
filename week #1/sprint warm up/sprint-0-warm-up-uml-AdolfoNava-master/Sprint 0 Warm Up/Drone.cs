using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class Drone : AerialVehicle
    {
        public Drone(IEngine engine)
        {
            MaxAltitude = 500;
            this.Engine = engine;
        }
    }
}
