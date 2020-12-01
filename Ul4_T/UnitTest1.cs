using Microsoft.VisualStudio.TestTools.UnitTesting;
using UL4;

namespace Ul4_T
{
    [TestClass]
    public class PSSysT
    {

        private PSController ps = new PSController();
        private Planet plnt = new Planet(50, 10, 1, 40);
        [TestMethod]
        public void InitPlanets_Test()
        {
            double expected = ps.planetsList[2].GetX();
            double actual = 700;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void MovePlanets_Test()
        {
            double expected = 649;
            double actual = ps.planetsList[1].GetX();
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void CreatePlanet_Test()
        {
            double expectedX = 50;
            double actualX = plnt.GetX();
            double expectedY = 10;
            double actualY = plnt.GetY();
            double expectedAngular = 1;
            double actualAngular = plnt._angularVelocity;
            double expectedRadius = 40;
            double actualRadius = plnt._planetRadius;
            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
            Assert.AreEqual(expectedAngular, actualAngular);
            Assert.AreEqual(expectedRadius, actualRadius);
        }

    }
}
