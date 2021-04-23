using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Sprint_0_Warm_Up;
using Sprint_0_Warm_Up.Engines;
using Sprint_0_Warm_Up.NinjectModules;

namespace AerialVehicleUnitTestInjections
{
    [TestClass]
    public class DroneEngine
    {
        IKernel kernal;
        public DroneEngine()
        {
            kernal = new StandardKernel(new DroneNinject());
        }

        [TestMethod]
        public void DroneEngineStartupNinject()
        {
            AerialVehicle dr;

            dr = kernal.Get<Drone>();

            Assert.AreEqual(false, dr.Engine.IsStarted);
            dr.StartEngine();
            Assert.AreEqual(true, dr.Engine.IsStarted);

        }
        [TestMethod]
        public void DroneNinject()
        {
            AerialVehicle dr;


            dr = kernal.Get<Drone>();

            Assert.IsInstanceOfType(dr, typeof(AerialVehicle));
            Assert.IsInstanceOfType(dr, typeof(Drone));
            Assert.IsInstanceOfType(dr.Engine, typeof(UAVEngine));
            Assert.AreEqual("This is the Engine for Unmanned Aerial Vehicles.", dr.Engine.About());

        }
        [TestMethod]
        public void DroneNoNinject()
        {
            AerialVehicle dr;
            UAVEngine je;

            je = new UAVEngine();
            dr = new Drone(je);

            Assert.IsInstanceOfType(dr, typeof(AerialVehicle));
            Assert.IsInstanceOfType(dr, typeof(Drone));
            Assert.IsInstanceOfType(dr.Engine, typeof(Engine));
            Assert.AreEqual("This is the Engine for Unmanned Aerial Vehicles.", dr.Engine.About());
        }
    }
}

