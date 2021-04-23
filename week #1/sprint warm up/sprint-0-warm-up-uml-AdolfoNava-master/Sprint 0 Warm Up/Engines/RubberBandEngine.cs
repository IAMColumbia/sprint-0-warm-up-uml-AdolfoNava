using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up.Engines
{
    public class RubberBandEngine : Engine
    {
        public RubberBandEngine()
        {
            IsStarted = false;
        }
        public override string About()
        {
            return "This is a basic engine that functions out of rubber band's tension force.";
        }
    }
}
