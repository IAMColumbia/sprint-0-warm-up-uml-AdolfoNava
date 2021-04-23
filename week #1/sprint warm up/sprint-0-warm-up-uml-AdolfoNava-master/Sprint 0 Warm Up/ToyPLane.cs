using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class ToyPlane : AerialVehicle
    {
        public bool isWoundUp { get; set; }

        public ToyPlane(IEngine engine)
        {
            this.isWoundUp = false;
            this.CurrentAltitude = 0;
            this.MaxAltitude = 50;
            this.Engine = engine;
        }

        public override string About()
        {
            return "This toy plane model currently has a current altitude of " + CurrentAltitude + " feet with a max altitude of " + MaxAltitude + " feet.";
        }

        public string getWindUpString()
        {
            return "Obtained string to Wind up the plane to unleash flight.";
        }

        public override void StartEngine()
        {
            if (isWoundUp == true)
                Engine.IsStarted = true;
        }

        public override string TakeOff()
        {
            if (Engine.IsStarted)
            {
                IsFlying = true;
                CurrentAltitude = MaxAltitude;

                return "The toy plane is currently taking off the ground.";

            }
            else
                return "The toy plane cannot take off the ground as the engine has not started.";
        }

        public void UnWind()
        {
            isWoundUp = false;
        }

        public void WindUp()
        {
            isWoundUp = true;
        }
    }
}
