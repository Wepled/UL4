using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace UL4
{
    public class SpaceShip : PrPoint
    {
        public SpaceShip(Planet p, double dX, double dY) : base(p.GetX(), p.GetY())
        {
            _startX = p.GetX();
            _startY = p.GetY();
            _dx = dX;
            _dy = dY;
            
        }
        private double _startX;
        private double _startY;
        private double _dx;
        private double _dy;
        public void DrawSpaceShip(Graphics g)
        {
            Pen pen = new Pen(Color.Blue);
            SolidBrush sb = new SolidBrush(Color.Blue);

            g.DrawRectangle(pen, (int)_startX, (int)_startY, 5, 10);
            g.FillRectangle(sb, (int)_startX, (int)_startY, 5, 10);

        }
        public void MoveSpaceship() 
        {
          _startX += _dx;
          _startY += _dy;
           
        }
    }
}
