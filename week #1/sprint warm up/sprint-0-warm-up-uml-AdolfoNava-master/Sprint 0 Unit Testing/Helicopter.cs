using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
using Sprint_0_Warm_Up.Engines;

namespace Sprint_0_Unit_Testing
{
    [TestClass]
    public class HelicopterTest
    {
        Helicopter airplane;
        public HelicopterTest()
        {
            airplane = new Helicopter(new ReciprocatingEngine());
        }

        [TestMethod]
        public void HelicopterTakeOff()
        {
            Helicopter heli = airplane;
            bool engineStarted;
            bool engineEnd;
            bool isFlyingBeginning;
            bool isFlyingEnd;

            engineStarted = heli.Engine.IsStarted;
            engineEnd = true;
            isFlyingBeginning = heli.IsFlying;
            isFlyingEnd = true;

            Assert.AreEqual(false, engineStarted);// test engine class
            heli.Engine.Start();
            Assert.AreEqual(true, heli.Engine.IsStarted);
            heli.Engine.Stop();
            Assert.AreEqual(false, heli.Engine.IsStarted);//reset
            heli.TakeOff();
            Assert.IsFalse(heli.IsFlying);
            heli.StartEngine();
            Assert.AreEqual(engineEnd, heli.Engine.IsStarted);
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
