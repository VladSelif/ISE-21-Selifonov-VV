import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

/**
 * 
 */

/**
 * @author Администратор
 *
 */
public class Airplane extends Vehicle {
	
	public int GetMaxCountPassengers()
	{
		return super.GetMaxCountPassengers();
	}
	
	protected void SetMaxCountPassengers(int value)
	{
		if (value > 0 && value < 5)
		{
			super.SetMaxCountPassengers(value);
		}
		else
		{
			super.SetMaxCountPassengers(4);
		}
	}
	
	@Override
	public double GetMaxSpeed()
	{
		return super.GetMaxSpeed();
	}
	@Override
	protected void SetMaxSpeed(int value)
	{
		if (value > 0 && value < 1300)
		{
			super.SetMaxSpeed(value);
		}
		else
		{
			super.SetMaxSpeed(1150);
		}
	}

	@Override
	public int GetWeight()
	{
		return super.GetWeight();
	}
	@Override
	protected void SetWeight(int value)
	{
		if(value > 1500 && value < 2500)
		{
			super.SetWeight(value);
		}
		else
		{
			super.SetWeight(2000);
		}
	}

	public Airplane(int maxSpeed, int maxCountPassengers, int weight, Color color)
	{
		this.SetMaxSpeed(maxSpeed);
		this.SetMaxCountPassengers(maxCountPassengers);
		this.SetColorBody(color);
		this.SetWeight(weight);
		Random rand = new Random();
		startPosX = rand.nextInt(200);
		startPosY = rand.nextInt(200);
	}

	protected void drawLightAirplane(Graphics g)
	{
		{
			g.setColor(GetColorBody());			
			g.fillRect(startPosX + 10, startPosY + 15, 10, 40);			
			g.fillRect(startPosX + 35, startPosY - 10, 15, 90);			
			g.fillRect(startPosX, startPosY + 25, 66, 20);			
			g.fillRect(startPosX + 76, startPosY + 25, 4, 20);			
			g.setColor(Color.BLACK);			
			g.fillRect(startPosX + 66, startPosY + 25, 10, 20);
		
	    }
		
    }

	@Override
	public void moveAirplane(Graphics g)
	{
		// TODO Auto-generated method stub
		startPosX += (GetMaxSpeed() * 50 / (float)GetWeight()) / (countPassengers == 0 ? 1 : countPassengers);
		drawAirplane(g);
	}

	@Override
    public void UpAirplane(Graphics g)
    {
        startPosY -= (GetMaxSpeed() * 50 / (float)GetWeight()) / (countPassengers == 0 ? 1 : countPassengers);
        drawAirplane(g);
    }

    public void DownAirplane(Graphics gr)
    {
        startPosY += (GetMaxSpeed() * 50 / (float)GetWeight()) / (countPassengers == 0 ? 1 : countPassengers);
        drawAirplane(gr);
    }
	

	@Override
    public void drawAirplane(Graphics g)
	{
		drawLightAirplane(g);
	}	
}
