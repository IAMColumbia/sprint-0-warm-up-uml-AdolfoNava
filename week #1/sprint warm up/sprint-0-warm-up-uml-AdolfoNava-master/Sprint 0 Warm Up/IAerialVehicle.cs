using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public interface IAerialVehicle
    {
        public int CurrentAltitude { get; set; }
        public IEngine Engine { get; }
        public bool IsFlying { get; set; }
        public int MaxAltitude { get; set; }
    }
}
