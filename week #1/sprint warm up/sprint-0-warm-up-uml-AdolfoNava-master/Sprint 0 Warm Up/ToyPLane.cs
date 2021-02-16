using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class ToyPlane : Airplane
    {
        public bool isWoundUp { get; set; }

        public ToyPlane()
        {
            this.isWoundUp = false;
            this.CurrentAltitude = 0;
            this.MaxAltitude = 50;
            engine.isStarted = false;
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
                engine.isStarted = true;
        }

        public override string TakeOff()
        {
            if (engine.isStarted)
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
