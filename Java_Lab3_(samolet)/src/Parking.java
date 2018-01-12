import java.awt.Color;
import java.awt.Graphics;


public class Parking {
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
		return ClassArray.Plus(parking, airplane);
	}
	public ITransport GetPlaneInParking(int ticket)
	{
		return ClassArray.Minus(parking, ticket);
	}


	public void Draw(Graphics g, int wigth, int height)
	{
		DrawMarking(g);
		for (int i = 0; i < countPlaces; i++)
		{
			ITransport airplane = parking.getObject(i);
			if (airplane != null)
			{
				
				airplane.setPosition(5 + i / 5 * placeSizeWidth + 15, i % 5 * placeSizeHeight + 15);
				airplane.drawAirplane(g);
			}
		}
	}

	private void DrawMarking(Graphics g)
	{
		g.setColor(Color.BLACK);
        // границы парковки
        g.drawRect(0, 0, (countPlaces / 5) * placeSizeWidth, 510);
        for (int i = 0; i < countPlaces / 5; i++)
        {
            //отрисовываем по 5 мест на линии
            for (int j = 0; j < 6; ++j)
            {
                //линия разметки места
                g.drawLine(i * placeSizeWidth, j * placeSizeHeight,
                    i * placeSizeWidth + 110, j * placeSizeHeight);
            }
            g.drawLine(i * placeSizeWidth, 0, i * placeSizeWidth, 500);

        }
    }
}