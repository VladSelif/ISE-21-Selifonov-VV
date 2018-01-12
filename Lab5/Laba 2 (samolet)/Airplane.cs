using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Laba_2__samolet_
{
    public class Airplane : Vehicle
    {
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 1300)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 1150;
                }
            }
        }

        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }
            protected set
            {
                if (value > 0 && value < 5)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 4;
                }
            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if (value > 1500 && value < 2500)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 2000;
                }
            }
        }

        public Airplane(int maxSpeed, int maxCountPassenger, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassenger;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public override void moveAirplane(Graphics g)
        {
            startPosX += (MaxSpeed * 50 / (float)Weight) / (countPassengers == 0 ? 1 : countPassengers);
            drawAirplane(g);
        }

        public override void UpAirplane(Graphics g)
        {
            startPosY -= (MaxSpeed * 50 / (float)Weight) / (countPassengers == 0 ? 1 : countPassengers);
            drawAirplane(g);
        }

        public override void DownAirplane(Graphics gr)
         {
            startPosY += (MaxSpeed * 50 / (float)Weight) / (countPassengers == 0 ? 1 : countPassengers);
            drawAirplane(gr);
         }

    public override void drawAirplane(Graphics g)
        {
            drawLightAirplane(g);
        }    

        protected virtual void drawLightAirplane(Graphics g)
        {
            
            Brush br = new SolidBrush(this.ColorBody);
            //tail spoiler
            g.FillRectangle(br, startPosX + 10, startPosY+15 , 10, 40);
            //wings
            g.FillRectangle(br, startPosX+35, startPosY-10 ,15, 90);
            // fluzelyaj       
            g.FillRectangle(br, startPosX , startPosY + 25, 66, 20);
            g.FillRectangle(br, startPosX+ 76, startPosY + 25, 4, 20);
            Brush brBlack = new SolidBrush(Color.Black);         
            //kabina 
            g.FillRectangle(brBlack, startPosX+66, startPosY + 25, 10, 20);
            
        }
    }
}
