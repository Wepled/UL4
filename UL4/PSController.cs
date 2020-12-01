using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UL4
{
    public class PSController
    {
        public PSController()
        {
            Init();
        }
        private PrPoint _centralPoint = new PrPoint(520, 400);
        public List<Planet> planetsList = new List<Planet>();
        public List<SpaceShip> SpaceShips = new List<SpaceShip>();
        public void Init()
        {
            planetsList.Add(new Planet(600, 400, 0.01, 4));
            planetsList.Add(new Planet(650, 400, 0.02, 6));
            planetsList.Add(new Planet(700, 400, 0.015, 10));
            planetsList.Add(new Planet(750, 400, 0.019, 15));
            planetsList.Add(new Planet(800, 400, 0.013, 8));
            planetsList.Add(new Planet(850, 400, 0.012, 9));
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
