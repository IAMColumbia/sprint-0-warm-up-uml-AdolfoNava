using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;
using Sprint_0_Warm_Up.Engines;

namespace Sprint_0_Warm_Up.NinjectModules
{
    public class ToyPlaneNinject : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAerialVehicle>().To<ToyPlane>();
            this.Bind<AerialVehicle>().To<ToyPlane>();
            this.Bind<IEngine>().To<RubberBandEngine>();

            this.Bind<IEngine>().To<RubberBandEngine>().WhenInjectedInto<ToyPlane>();

        }
    }
}
