using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UL4
{
    public class PrPoint
    {
        private double x { get; set; }
        private double y { get; set; }
        public PrPoint(double _x = 0, double _y = 0)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return "x: " + x + "\n" +
                   "y: " + y + "\n" +
                   "rho: " + rho() + "\n" +
                   "theta: " + theta();
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public double rho()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double theta()
        {
            return Math.Atan2(y, x);
        }
        public PrPoint vectorTo(PrPoint other)
        {
            return new PrPoint(other.x - x, other.y - y);
        }
        public double Distance(PrPoint other)
        {
            return vectorTo(other).rho();
        }
        public void translate(double dx, double dy)
        {
            x += dx;
            y += dy;
        }
        public void scale(double scale)
        {
            x *= scale;
            y *= scale;
        }
        public void centre_rotate(double angle)
        {
            var temp_x = rho() * Math.Cos(theta() + angle);
            var temp_y = rho() * Math.Sin(theta() + angle);
            x = temp_x;
            y = temp_y;
        }
        public void rotate(PrPoint p, double angle)
        {
            translate(-p.x, -p.y);
            centre_rotate(angle);
            translate(p.x, p.y);
        }
    }

}
