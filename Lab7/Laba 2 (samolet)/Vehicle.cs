using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2__samolet_
{
    public abstract class Vehicle : ITransport
    {
        protected float startPosX;
        protected float startPosY;
        protected int countPassengers;

        public virtual int MaxCountPassengers { protected set; get; }
        public virtual int MaxSpeed { protected set; get; }

        public Color ColorBody { protected set; get; }

        public virtual double Weight { protected set; get; }

        public abstract void moveAirplane(Graphics g);

        public abstract void DownAirplane(Graphics gr);


        public abstract void UpAirplane(Graphics gr);

        public abstract void drawAirplane(Graphics g);

        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public void loadPassenger(int count)
        {
            if (countPassengers + count < MaxCountPassengers)
            {
                countPassengers += count;
            }
        }

        public int getPassenger()
        {
            int count = countPassengers;
            countPassengers = 0;
            return count;
        }
        public virtual void setMainColor(Color color)
        {
            ColorBody = color;
        }

        public abstract string getInfo();
    }
}
