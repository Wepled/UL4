using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using UL4;

namespace PlanetarySystem
{
    public class Planet : PrPoint
    {
        public double _angularVelocity { get; set; }
        public int _planetRadius { get; set; }
        public Planet(double x, double y, double angularVelocity, int planetRadius) : base(x, y)
        {
          
            _angularVelocity = angularVelocity;
            _planetRadius = planetRadius;
        }

        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Green);
            SolidBrush sb = new SolidBrush(Color.Blue);
            graphics.DrawEllipse(pen, (int)GetX(), (int)GetY(), _planetRadius, _planetRadius);
            graphics.FillEllipse(sb, (int)GetX(), (int)GetY(), _planetRadius, _planetRadius);
        }
    }
}
