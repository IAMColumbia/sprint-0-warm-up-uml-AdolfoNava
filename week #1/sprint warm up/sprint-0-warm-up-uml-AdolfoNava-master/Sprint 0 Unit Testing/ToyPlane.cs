using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;

namespace Sprint_0_Unit_Testing
{
    [TestClass]
    public class ToyPlaneTest
    {

        ToyPlane toyPlane;
        public ToyPlaneTest()
        {
            toyPlane = new ToyPlane();
        }
        [TestMethod]
        public void ToyPlaneAbout()
        {
            ToyPlane tp = toyPlane;
            string aboutToyPlaneText;

            aboutToyPlaneText = $"This toy plane model currently has a current altitude of {0} feet with a max altitude of {50} feet.";
            Assert.AreEqual(aboutToyPlaneText, tp.About());
        }
        [TestMethod]
        public void ToyPlaneText()
        {
            ToyPlane tp = toyPlane;
            string pickupText;

            pickupText = "Obtained string to Wind up the plane to unleash flight.";
            Assert.AreEqual(pickupText, tp.getWindUpString());
        }
        [TestMethod]
        public void ToyPlaneTakeOff()
        {
            ToyPlane tp = toyPlane;
            bool endWoundUp;
            bool startWoundUp;
            bool startIsFlying;
            bool endIsFlying;
            bool startEngineStatus;
            bool endEngineStatus;

            startWoundUp = tp.isWoundUp;
            endWoundUp = true;
            startIsFlying = tp.IsFlying;
            endIsFlying = true;
            startEngineStatus = tp.engine.isStarted;
            endEngineStatus = true;

            Assert.AreEqual(startIsFlying, tp.IsFlying);
            Assert.AreEqual(startWoundUp, tp.isWoundUp);
            Assert.AreEqual(startEngineStatus, tp.engine.isStarted);
            tp.WindUp();
            Assert.IsTrue(tp.isWoundUp);
            tp.UnWind();
            Assert.IsFalse(tp.isWoundUp);
            tp.WindUp();
            tp.TakeOff();
            Assert.IsFalse(tp.IsFlying);
            tp.StartEngine();
            Assert.IsTrue(endEngineStatus);
            tp.TakeOff();
            Assert.AreEqual(endIsFlying, tp.IsFlying);
            Assert.AreEqual(endWoundUp, tp.isWoundUp);


        }
    }

}
