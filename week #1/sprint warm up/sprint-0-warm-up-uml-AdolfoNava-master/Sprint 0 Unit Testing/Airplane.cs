using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Sprint_0_Warm_Up;

namespace Sprint_0_Unit_Testing
{
    [TestClass]
    public class AirplaneTest
    {
        Airplane airplane;
        public AirplaneTest()
            {
            airplane = new Airplane();
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

            apEngineAboutText = "This is a fully functional engine for aerial vehicles only.";
            Assert.AreEqual(apEngineAboutText,ap.engine.About());
        }
        [TestMethod]
        public void AirplaneTakeOff()
        {
            Airplane ap = airplane;
            bool engineStarted;
            bool engineEnd;
            bool isFlyingBeginning;
            bool isFlyingEnd;

            engineStarted = ap.engine.isStarted;
            engineEnd = true;
            isFlyingBeginning = ap.IsFlying;
            isFlyingEnd = true;

            Assert.AreEqual(false, engineStarted);// test engine class
            ap.engine.Start();
            Assert.AreEqual(true, ap.engine.isStarted);
            ap.engine.Stop();
            Assert.AreEqual(false, ap.engine.isStarted);//reset
            ap.TakeOff();
            Assert.IsFalse(ap.IsFlying);
            ap.StartEngine();
            Assert.AreEqual(engineEnd, ap.engine.isStarted);
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
