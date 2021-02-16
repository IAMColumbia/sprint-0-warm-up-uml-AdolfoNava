using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;

namespace Sprint_0_Unit_Testing
{
    [TestClass]
    public class HelicopterTest
    {
        Helicopter airplane;
        public HelicopterTest()
        {
            airplane = new Helicopter();
        }

        [TestMethod]
        public void HelicopterTakeOff()
        {
            Helicopter heli = airplane;
            bool engineStarted;
            bool engineEnd;
            bool isFlyingBeginning;
            bool isFlyingEnd;

            engineStarted = heli.engine.isStarted;
            engineEnd = true;
            isFlyingBeginning = heli.IsFlying;
            isFlyingEnd = true;

            Assert.AreEqual(false, engineStarted);// test engine class
            heli.engine.Start();
            Assert.AreEqual(true, heli.engine.isStarted);
            heli.engine.Stop();
            Assert.AreEqual(false, heli.engine.isStarted);//reset
            heli.TakeOff();
            Assert.IsFalse(heli.IsFlying);
            heli.StartEngine();
            Assert.AreEqual(engineEnd, heli.engine.isStarted);
            heli.TakeOff();
            Assert.AreEqual(isFlyingEnd, heli.IsFlying);


        }
        [TestMethod]
        public void HelicopterFlightAdjustment()
        {
            Helicopter heli = airplane;
            heli.IsFlying = true;
            int startAltitude = 4000;
            int endAltitudeDown = 0;
            int endAltitudeUp = 8000;
            heli.CurrentAltitude = startAltitude;


            Assert.AreEqual(startAltitude, heli.CurrentAltitude);
            heli.FlyUp(4000);
            Assert.AreEqual(endAltitudeUp, heli.CurrentAltitude);
            heli.CurrentAltitude = startAltitude;
            heli.FlyDown(8000);
            Assert.AreEqual(endAltitudeDown, heli.CurrentAltitude);
        }
    }

}
