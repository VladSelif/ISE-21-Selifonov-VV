using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2__samolet_
{
    interface ITransport
    {
        void moveAirplane(Graphics g);

        void UpAirplane(Graphics gr);

        void DownAirplane(Graphics gr);

        void drawAirplane(Graphics g);

        void setPosition(int x, int y);

        void loadPassenger(int count);

        int getPassenger();
    }
}
