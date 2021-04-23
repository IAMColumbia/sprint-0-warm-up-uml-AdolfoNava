using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
using Sprint_0_Warm_Up.Engines;

namespace Sprint_0_Unit_Testing
{
    [TestClass]
    public class DroneTest
    {
        Drone drone;
        public DroneTest()
        {
            drone = new Drone(new UAVEngine());
        }
        [TestMethod]
        public void DroneAbout()
        {
            Drone d = drone;
            string aboutText;

            aboutText = $"This model airplane has a max altitude of {500} feet while it's current altitude is at {0}";

            Assert.AreEqual(aboutText, d.About());

        }
        [TestMethod]
        public void DroneTakeOff()
        {
            Drone d = drone;
            bool engineStarted;
            bool engineEnd;
            bool isFlyingBeginning;
            bool isFlyingEnd;

            engineStarted = d.Engine.IsStarted;
            engineEnd = true;
            isFlyingBeginning = d.IsFlying;
            isFlyingEnd = true;

            Assert.AreEqual(false, engineStarted);// test engine class
            d.Engine.Start();
            Assert.AreEqual(true, d.Engine.IsStarted);
            d.Engine.Stop();
            Assert.AreEqual(false, d.Engine.IsStarted);//reset
            d.TakeOff();
            Assert.IsFalse(d.IsFlying);
            d.StartEngine();
            Assert.AreEqual(engineEnd, d.Engine.IsStarted);
            d.TakeOff();
            Assert.AreEqual(isFlyingEnd, d.IsFlying);


        }
        [TestMethod]
        public void DroneFlightAdjustment()
        {
            Drone d = drone;
            d.IsFlying = true;
            int startAltitude = 125;
            int endAltitudeDown = 0;
            int endAltitudeUp = 500;
            d.CurrentAltitude = startAltitude;


            Assert.AreEqual(startAltitude, d.CurrentAltitude);
            d.FlyUp();
            d.FlyUp(9000);
            Assert.AreEqual(endAltitudeUp, d.CurrentAltitude);
            d.CurrentAltitude = startAltitude;
            d.FlyDown();
            Assert.AreEqual(endAltitudeDown, d.CurrentAltitude);
        }
    }

}
