using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2__samolet_
{
    class Parking
    {
        ClassArray<ITransport> parking;
        int countPlaces = 15;
        int placeSizeWidth = 210;
        int placeSizeHeight = 100;

        public Parking()
        {
            parking = new ClassArray<ITransport>(countPlaces, null);
        }

        public int PutAirplaneInParking(ITransport airplane)
        {
            return parking + airplane;
        }
        public ITransport GetAirplaneInParking(int ticket)
        {
            return parking - ticket;
        }

        public void Draw(Graphics g, int wigth, int height)
        {
            DrawMarking(g);

            for (int i = 0; i < countPlaces; i++)
            {
                var airplane = parking.getObject(i);
                if (airplane != null)
                {
                    airplane.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight + 15);
                    airplane.drawAirplane(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 550);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                
                for (int j = 0; j < 6; ++j)
                {

                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i * placeSizeWidth + 110, j * placeSizeHeight );
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 502);

            }
        }
    }
}