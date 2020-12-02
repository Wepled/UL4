using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UL4
{
    public class PSController
    {
        public PSController(double formMidX, double formMidY)
        {
            Init(formMidX, formMidY);
        }
        private PrPoint _centralPoint = new PrPoint(520, 400);
        public List<Planet> planetsList = new List<Planet>();
        public List<SpaceShip> SpaceShips = new List<SpaceShip>();
        public void Init(double formMidX, double formMidY)
        {
            planetsList.Add(new Planet(formMidX, formMidY, 0.0099, 10));
            planetsList.Add(new Planet(formMidX + 50, formMidY, 0.0098, 6));
            planetsList.Add(new Planet(formMidX + 100, formMidY, 0.0006, 10));
            planetsList.Add(new Planet(formMidX + 150, formMidY, 0.0005, 15));
            planetsList.Add(new Planet(formMidX + 200, formMidY, 0.0006, 8));
            planetsList.Add(new Planet(formMidX + 250, formMidY, 0.0005, 9));
            SpaceShips.Add(new SpaceShip(planetsList[0], 2, 1));
            SpaceShips.Add(new SpaceShip(planetsList[1], 2, 3));
            SpaceShips.Add(new SpaceShip(planetsList[2], 0.5, 3));
        }
        public void Move()
        {
            foreach(Planet p in planetsList)
            {
                p.rotate(_centralPoint, p._angularVelocity);
                Console.WriteLine("X:{0} Y:{1}", p.GetX(), p.GetY());
            }
            foreach (SpaceShip p in SpaceShips)
            {
                p.MoveSpaceship();
                Console.WriteLine("X:{0} Y:{1}", p.GetX(), p.GetY());
            }
        }
    }
}
