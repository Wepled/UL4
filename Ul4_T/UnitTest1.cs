using Microsoft.VisualStudio.TestTools.UnitTesting;
using UL4;

namespace Ul4_T
{
    [TestClass]
    public class PSSysT
    {

        private PSController ps = new PSController(0, 0);
        private Planet plnt = new Planet(50, 10, 1, 40);
        private SpaceShip ship = new SpaceShip(new Planet(10,10,0.5, 2), 10, 10);
        [TestMethod]
        public void InitPlanets_Test()
        {
            double expected = ps.planetsList[2].GetX();
            double actual = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void MovePlanets_Test()
        {
            double expected = 49;
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
        [TestMethod]
        public void CreateSpaceShip_Test()
        {
            double expectedX = 10;
            double actualX = ship._startX;
            double expectedY = 10;
            double actualY = ship._startY;
            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }
        [TestMethod]
        public void MoveSpaceShip_Test()
        {
            ship.MoveSpaceship();
            double expectedX = 20;
            double actualX = ship._startX;
            double expectedY = 20;
            double actualY = ship._startY;
            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);
        }
    }
}
