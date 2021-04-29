using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up.Engines
{
    public class UAVEngine : Engine
    {
        public UAVEngine()
        {
            IsStarted = false;
        }
        public override string About()
        {
            return "This is the Engine for Unmanned Aerial Vehicles.";
        }
    }
}
