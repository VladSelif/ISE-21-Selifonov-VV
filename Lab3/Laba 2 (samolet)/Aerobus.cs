using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2__samolet_
{
    public class Aerobus : Airplane
    {
        private bool reactiveEngine_left;
        private bool reactiveEngine_right;
        private bool windows;
        private bool lines;
        private Color dopColor;
       
        public Aerobus(int maxSpeed, int maxCountPassenger, double weight, Color color, bool windows, bool reactiveEngine_left, bool reactiveEngine_right, bool lines,Color dopColor) :
            base(maxSpeed, maxCountPassenger, weight, color)
        {
            this.reactiveEngine_left = reactiveEngine_left;
            this.reactiveEngine_right = reactiveEngine_right;
            this.lines = lines;
            this.windows = windows;
            this.dopColor = dopColor;
        }

        protected override void drawLightAirplane(Graphics g)
        {
            if (reactiveEngine_left)
            {
                Brush engine = new SolidBrush(dopColor);
                g.FillEllipse(engine, startPosX + 22, startPosY,50, 15);

            }
            if (reactiveEngine_right)
            {
                Brush engine = new SolidBrush(dopColor);
                g.FillEllipse(engine, startPosX + 22, startPosY + 55, 50, 15);

            }
            
            base.drawLightAirplane(g); 
            if (windows)
            {
                Brush window = new SolidBrush(Color.White);

                g.FillEllipse(window, startPosX + 30, startPosY+ 30, 8, 8);
                g.FillEllipse(window, startPosX + 20, startPosY + 30, 8,8);
                g.FillEllipse(window, startPosX + 40, startPosY + 30, 8, 8);
                g.FillEllipse(window, startPosX + 50, startPosY + 30, 8, 8);
            }

            if (lines)
            {
                Brush br = new SolidBrush(Color.Red);
                g.FillRectangle(br, startPosX + 5, startPosY + 15, 10, 40);
            }
        }
    }
}

