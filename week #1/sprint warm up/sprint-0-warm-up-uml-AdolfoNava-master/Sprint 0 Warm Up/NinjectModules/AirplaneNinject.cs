using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using Ninject.Modules;
using Sprint_0_Warm_Up.Engines;

namespace Sprint_0_Warm_Up.NinjectModules
{
    public class AirplaneNinject : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAerialVehicle>().To<Airplane>();
            this.Bind<AerialVehicle>().To<Airplane>();
            this.Bind<IEngine>().To<JetEngine>();

            this.Bind<IEngine>().To<JetEngine>().WhenInjectedInto<Airplane>();
        }
    }
}
