using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Sprint_0_Warm_Up;
using Sprint_0_Warm_Up.Engines;

namespace Sprint_0_Unit_Testing
{
    [TestClass]
    public class AirplaneTest
    {
        Airplane airplane;
        public AirplaneTest()
            {
            airplane = new Airplane( new JetEngine());
            }
        [TestMethod]
        public void AirplaneAbout()
        {
           Airplane ap = airplane;
            string aboutText;

            aboutText = $"This model airplane has a max altitude of {41000} feet while it's current altitude is at {0}";

            Assert.AreEqual(aboutText, ap.About());

        }
        [TestMethod]
        public void AirplaneEngineTest()
        {
            Airplane ap = airplane;
            string apEngineAboutText;

            apEngineAboutText = "This is an Engine of a Commerical level passenger Jet that is meant to travel across large distances.";
            Assert.AreEqual(apEngineAboutText,ap.Engine.About());
        }
        [TestMethod]
        public void AirplaneTakeOff()
        {
            Airplane ap = airplane;
            bool engineStarted;
            bool engineEnd;
            bool isFlyingBeginning;
            bool isFlyingEnd;

            engineStarted = ap.Engine.IsStarted;
            engineEnd = true;
            isFlyingBeginning = ap.IsFlying;
            isFlyingEnd = true;

            Assert.AreEqual(false, engineStarted);// test engine class
            ap.Engine.Start();
            Assert.AreEqual(true, ap.Engine.IsStarted);
            ap.Engine.Stop();
            Assert.AreEqual(false, ap.Engine.IsStarted);//reset
            ap.TakeOff();
            Assert.IsFalse(ap.IsFlying);
            ap.StartEngine();
            Assert.AreEqual(engineEnd, ap.Engine.IsStarted);
            ap.TakeOff();
            Assert.AreEqual(isFlyingEnd, ap.IsFlying);


        }
        [TestMethod]
        public void AirplaneFlightAdjustment()
        {
            Airplane ap = airplane;
            ap.IsFlying = true;
            int startAltitude = 20000;
            int endAltitudeDown = 10000;
            int endAltitudeUp = 30000;
            ap.CurrentAltitude = startAltitude;


            Assert.AreEqual(startAltitude, ap.CurrentAltitude);
            ap.FlyUp();
            ap.FlyUp(9000);
            Assert.AreEqual(endAltitudeUp, ap.CurrentAltitude);
            ap.CurrentAltitude = startAltitude;
            ap.FlyDown();
            ap.FlyDown(9000);
            Assert.AreEqual(endAltitudeDown, ap.CurrentAltitude);
            ap.FlyUp(300000);
            Assert.AreEqual(ap.MaxAltitude, ap.CurrentAltitude);
            ap.FlyDown(300000);
            Assert.AreEqual(0, ap.CurrentAltitude);

        }
    }
}
