using System;

namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }
        public Engine engine { get; set; }
        public bool IsFlying { get; set; }
        public int MaxAltitude { get; set; }


        public AerialVehicle()
        {
            this.MaxAltitude = 0;
            this.CurrentAltitude = 0;
            this.IsFlying = false;
            engine = new Engine();
        }

        public virtual string About()
        {
            return $"This model airplane has a max altitude of {MaxAltitude} feet while it's current altitude is at {CurrentAltitude}";
        }

        public virtual string TakeOff()
        {
            if (engine.isStarted)
            {
                CurrentAltitude = CurrentAltitude + 1000;
                IsFlying = true;
                return "The plane is taking off from the ground right now.";


            }
            else
                return "Cannot take off right now due to the engine not being started yet.";
        }
        public string getEngineStartedString()
        {
            return "Revving up the engines right now.";
        }
        public virtual void StartEngine()
        {
            engine.isStarted = true;
            Console.WriteLine(getEngineStartedString());

        }
        public void FlyDown()
        {
            if (IsFlying)
                CurrentAltitude = CurrentAltitude - 1000;
            if (CurrentAltitude < 0)
                CurrentAltitude = 0;
        }
        public void FlyDown(int howMuch)
        {
            CurrentAltitude = CurrentAltitude - howMuch;
            if (CurrentAltitude < 0)
            {
                Console.WriteLine("The vehicle will now be at ground level.");
                CurrentAltitude = 0;
            }
        }

        public void FlyUp()
        {
            if (IsFlying)
                CurrentAltitude = CurrentAltitude + 1000;
        }

        public void FlyUp(int HowMuch)
        {
            CurrentAltitude = CurrentAltitude + HowMuch;
            if (CurrentAltitude > MaxAltitude)
            {
                Console.WriteLine("The Altitude given in to the system too high reverting to highest altiutde now.");
                CurrentAltitude = MaxAltitude;
            }
        }
    }
}