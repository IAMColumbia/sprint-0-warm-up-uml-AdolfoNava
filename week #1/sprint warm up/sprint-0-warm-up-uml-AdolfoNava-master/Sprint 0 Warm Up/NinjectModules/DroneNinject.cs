using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using Ninject.Modules;
using Sprint_0_Warm_Up;
using Sprint_0_Warm_Up.Engines;

namespace Sprint_0_Warm_Up.NinjectModules
{
    public class DroneNinject : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAerialVehicle>().To<Drone>();
            this.Bind<AerialVehicle>().To<Drone>();
            this.Bind<IEngine>().To<UAVEngine>();

            this.Bind<IEngine>().To<UAVEngine>().WhenInjectedInto<Drone>();
        }

    }
}
