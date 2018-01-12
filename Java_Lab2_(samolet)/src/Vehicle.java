import java.awt.Color;
import java.awt.Graphics;

/**
 * 
 */

/**
 * @author Администратор
 *
 */
public abstract class Vehicle implements ITransport {
	
	protected int startPosX;
	protected int startPosY;
	protected int countPassengers;


	public abstract void moveAirplane(Graphics g);
    public abstract void DownAirplane(Graphics gr);
    public abstract void drawAirplane(Graphics g);
    public abstract void UpAirplane(Graphics gr);

	public void setPosition(int x, int y)
	{
		startPosX = x;
		startPosY = y;
	}
	
    
	private int MaxCountPassengers;
	protected void SetMaxCountPassengers(int m) {
		MaxCountPassengers = m;
	}
	public int GetMaxCountPassengers() {
		return MaxCountPassengers;
	}
	
	private double MaxSpeed;
	protected void SetMaxSpeed(int s) {
		MaxSpeed = s;
	}
	public double GetMaxSpeed() {
		return MaxSpeed;
	}
	
	private int Weight;
	protected void SetWeight(int w) {
		Weight = w;
	}
	public int GetWeight() {
		return Weight;
	}

	private Color ColorBody;
	protected void SetColorBody(Color c) {
		ColorBody = c;
	}
	public Color GetColorBody() {
		return ColorBody;
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
	
}	
	
