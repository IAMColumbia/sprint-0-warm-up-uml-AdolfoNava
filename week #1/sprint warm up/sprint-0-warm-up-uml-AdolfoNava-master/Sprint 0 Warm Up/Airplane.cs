using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class Airplane : AerialVehicle
    {
        public Airplane(IEngine engine)
        {
            this.CurrentAltitude = 0;
            this.MaxAltitude = 41000;
            this.Engine = engine;
        }
    }
}
