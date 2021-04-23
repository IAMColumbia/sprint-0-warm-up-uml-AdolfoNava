using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using Ninject.Modules;
using Sprint_0_Warm_Up.Engines;

namespace Sprint_0_Warm_Up.NinjectModules
{
    public class HelicopterNinject : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAerialVehicle>().To<Helicopter>();
            this.Bind<AerialVehicle>().To<Helicopter>();
            this.Bind<IEngine>().To<ReciprocatingEngine>();

            this.Bind<IEngine>().To<ReciprocatingEngine>().WhenInjectedInto<Helicopter>();
        }
    }
}
