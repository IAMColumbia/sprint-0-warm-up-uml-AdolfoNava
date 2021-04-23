using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up.Engines
{
    public class JetEngine : Engine
    {
        public JetEngine()
        {
            IsStarted = false;
        }
        public override string About()
        {
            return "This is an Engine of a Commerical level passenger Jet that is meant to travel across large distances.";
        }
    }
}
