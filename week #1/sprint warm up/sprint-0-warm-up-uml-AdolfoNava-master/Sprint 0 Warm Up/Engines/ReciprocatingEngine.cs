using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up.Engines
{
    public class ReciprocatingEngine : Engine
    {
        public ReciprocatingEngine()
        {
            IsStarted = false;
        }
        public override string About()
        {
            return "This is a engine designed for Hovering vehicles like a Helicopter.";
        }
    }
}
