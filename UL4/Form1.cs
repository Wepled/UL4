using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UL4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startStop.Text = "Start";
            planetSystem = new PSController((double) this.Width / 3, (double) this.Height / 2);

        }

        PSController planetSystem;
        Graphics graphics;

        private void DrawPlanetsSYS(PSController PS)
        {

            PS.planetsList.ForEach(x => x.Draw(CreateGraphics()));
            PS.SpaceShips.ForEach(x => x.DrawSpaceShip(CreateGraphics()));

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawPlanetsSYS(planetSystem);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            planetSystem.Move();
            this.Refresh();
            DrawPlanetsSYS(planetSystem);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moveOnce_Click(object sender, EventArgs e)
        {
            timer1.Start();
            planetSystem.Move();
            this.Refresh();
            DrawPlanetsSYS(planetSystem);

            timer1.Stop();

        }

        private void startStop_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }

        }
    }
}
