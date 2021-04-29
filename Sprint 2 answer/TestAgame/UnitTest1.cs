using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MakeingTestFromGroundUp;
namespace TestAgame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Kyle K = new Kyle();

            Assert.IsNotNull(K);
            Assert.AreEqual(K.Name, "Kyle");
            Assert.AreEqual(K.Power, 50);
            Assert.AreEqual(K.AttackType, "Bubbles");
            Assert.AreEqual(K.Health, 6000);

            K.Statz();
            K.LifePoints();
            K.AtckLifePoints(0);
            K.Attack();
            
            

        }

    }
}
