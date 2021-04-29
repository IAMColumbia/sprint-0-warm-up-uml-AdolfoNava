using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Sprint_0_Warm_Up;
using Sprint_0_Warm_Up.Engines;
using Sprint_0_Warm_Up.NinjectModules;

namespace AerialVehicleUnitTestInjections
{
    [TestClass]
    public class ToyPlaneEngine
    {
        IKernel kernal;
        public ToyPlaneEngine()
        {
            kernal = new StandardKernel(new ToyPlaneNinject());
        }

        [TestMethod]
        public void ToyPlaneEngineStartupNinject()
        {
            ToyPlane tp;

            tp = kernal.Get<ToyPlane>();

            Assert.AreEqual(false, tp.Engine.IsStarted);
            tp.WindUp();
            tp.StartEngine();
            Assert.AreEqual(true, tp.Engine.IsStarted);

        }
        [TestMethod]
        public void ToyPlaneNinject()
        {
            AerialVehicle tp;


            tp = kernal.Get<ToyPlane>();

            Assert.IsInstanceOfType(tp, typeof(AerialVehicle));
            Assert.IsInstanceOfType(tp, typeof(ToyPlane));
            Assert.IsInstanceOfType(tp.Engine, typeof(RubberBandEngine));
            Assert.AreEqual("This is a basic engine that functions out of rubber band's tension force.", tp.Engine.About());

        }
        [TestMethod]
        public void ToyPlaneNoNinject()
        {
            AerialVehicle tp;
            RubberBandEngine je;

            je = new RubberBandEngine();
            tp = new ToyPlane(je);

            Assert.IsInstanceOfType(tp, typeof(AerialVehicle));
            Assert.IsInstanceOfType(tp, typeof(ToyPlane));
            Assert.IsInstanceOfType(tp.Engine, typeof(Engine));
            Assert.AreEqual("This is a basic engine that functions out of rubber band's tension force.", tp.Engine.About());
        }
    }
}
