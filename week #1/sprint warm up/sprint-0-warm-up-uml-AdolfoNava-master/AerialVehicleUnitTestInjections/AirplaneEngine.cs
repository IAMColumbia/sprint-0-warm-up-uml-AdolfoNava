using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Sprint_0_Warm_Up;
using Sprint_0_Warm_Up.Engines;
using Sprint_0_Warm_Up.NinjectModules;

namespace AerialVehicleUnitTestInjections
{
    [TestClass]
    public class AirplaneEngine
    {
        IKernel kernal;
        public AirplaneEngine()
        {
            kernal = new StandardKernel(new AirplaneNinject());
        }

        [TestMethod]
        public void AirplaneEngineStartupNinject()
        {
            AerialVehicle ap;

            ap = kernal.Get<Airplane>();

            Assert.AreEqual(false, ap.Engine.IsStarted);
            ap.StartEngine();
            Assert.AreEqual(true, ap.Engine.IsStarted);

        }
        [TestMethod]
        public void AirplaneNinject()
        {
            AerialVehicle ap;


            ap = kernal.Get<Airplane>();

            Assert.IsInstanceOfType(ap, typeof(AerialVehicle));
            Assert.IsInstanceOfType(ap, typeof(Airplane));
            Assert.IsInstanceOfType(ap.Engine, typeof(JetEngine));
            Assert.AreEqual("This is an Engine of a Commerical level passenger Jet that is meant to travel across large distances.", ap.Engine.About());

        }
        [TestMethod]
        public void AirplaneNoNinject()
        {
            AerialVehicle ap;
            JetEngine je;

            je = new JetEngine();
            ap = new Airplane(je);

            Assert.IsInstanceOfType(ap, typeof(AerialVehicle));
            Assert.IsInstanceOfType(ap, typeof(Airplane));
            Assert.IsInstanceOfType(ap.Engine, typeof(Engine));
            Assert.AreEqual("This is an Engine of a Commerical level passenger Jet that is meant to travel across large distances.", ap.Engine.About());
        }
    }
}
