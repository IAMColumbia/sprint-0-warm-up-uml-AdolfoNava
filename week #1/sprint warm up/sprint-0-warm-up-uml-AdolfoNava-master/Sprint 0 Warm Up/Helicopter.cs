using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class Helicopter : AerialVehicle
    {
        public Helicopter(IEngine engine)
        {
            MaxAltitude = 8000;
            this.Engine = engine;
        } 
    }
}
