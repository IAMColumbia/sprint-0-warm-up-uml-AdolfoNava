using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class Airport
    {

        protected int MaxVehicles;
        List<AerialVehicle> Vehicles;

        public string AirportCode {get; protected set;}
        public Airport(string Code)
        {
            AirportCode = Code;
            Vehicles = new List<AerialVehicle>();
        }
        public Airport(string Code, int maxVehicles)
        {
            AirportCode = Code;
            Vehicles = new List<AerialVehicle>();
            MaxVehicles = maxVehicles;
        }
        public string AllTakeOff()
        {
            string allTakeOff = "";
            foreach(AerialVehicle av in this.Vehicles)
            {
                allTakeOff += this.TakeOff(av);
            }
            return allTakeOff;
        }
        public string Land(AerialVehicle a)
        {
            if (Vehicles.Count < MaxVehicles)
            {
                Vehicles.Add(a);
                if(a.CurrentAltitude>0)
                {
                    //This makes sure how ever high the vehicle is it always end up at 0
                    a.FlyDown(a.CurrentAltitude);
                }
                return $"{a} lands at {AirportCode}.";
            }
            return $"{AirportCode} is right now full and can't land {a}.";
        }
        public string Land(List<AerialVehicle> landing)
        {
            string land = "";
            foreach(AerialVehicle av in landing)
            {
                land += this.Land(av);
            }
            return land;
        }
        public string TakeOff(AerialVehicle a)
        {
            Vehicles.Remove(a);
            return $"{a.TakeOff()} from {AirportCode}.";
        }
    }
}
