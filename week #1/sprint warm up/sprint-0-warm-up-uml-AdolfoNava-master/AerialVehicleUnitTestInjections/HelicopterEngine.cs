using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Sprint_0_Warm_Up;
using Sprint_0_Warm_Up.Engines;
using Sprint_0_Warm_Up.NinjectModules;
using System;
using System.Collections.Generic;
using System.Text;

namespace AerialVehicleUnitTestInjections
{
    [TestClass]
    public class HelicopterEngine
    {
        IKernel kernal;
        public HelicopterEngine()
        {
            kernal = new StandardKernel(new HelicopterNinject());
        }

        [TestMethod]
        public void HelicopterEngineStartupNinject()
        {
            AerialVehicle Heli;

            Heli = kernal.Get<Helicopter>();

            Assert.AreEqual(false, Heli.Engine.IsStarted);
            Heli.StartEngine();
            Assert.AreEqual(true, Heli.Engine.IsStarted);

        }
        [TestMethod]
        public void HelicopterNinject()
        {
            AerialVehicle Heli;


            Heli = kernal.Get<Helicopter>();

            Assert.IsInstanceOfType(Heli, typeof(AerialVehicle));
            Assert.IsInstanceOfType(Heli, typeof(Helicopter));
            Assert.IsInstanceOfType(Heli.Engine, typeof(ReciprocatingEngine));
            Assert.AreEqual("This is a engine designed for Hovering vehicles like a Helicopter.", Heli.Engine.About());

        }
        [TestMethod]
        public void HelicopterNoNinject()
        {
            AerialVehicle Heli;
            ReciprocatingEngine je;

            je = new ReciprocatingEngine();
            Heli = new Helicopter(je);

            Assert.IsInstanceOfType(Heli, typeof(AerialVehicle));
            Assert.IsInstanceOfType(Heli, typeof(Helicopter));
            Assert.IsInstanceOfType(Heli.Engine, typeof(Engine));
            Assert.AreEqual("This is a engine designed for Hovering vehicles like a Helicopter.", Heli.Engine.About());
        }
    }
}
