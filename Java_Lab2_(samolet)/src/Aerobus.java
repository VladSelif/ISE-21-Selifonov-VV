import java.awt.Color;
import java.awt.Graphics;

/**
 * 
 */

/**
 * @author Администратор
 *
 */
public class Aerobus extends Airplane {
	private boolean reactiveEngine_left;
	private boolean reactiveEngine_right;
	private boolean windows;
	private boolean lines;
    private Color dopColor;

	public Aerobus(int maxSpeed, int maxCountPassengers, int weight, Color color, boolean reactiveEngine_left, boolean reactiveEngine_right, boolean windows, boolean lines, Color dopColor) 
	{
		super(maxSpeed, maxCountPassengers, weight, color);
	
		this.reactiveEngine_left = reactiveEngine_left;
		this.reactiveEngine_right = reactiveEngine_right;
		this.windows = windows;
		this.lines = lines;
        this.dopColor = dopColor;
	}

	

    protected void drawLightAirplane(Graphics g)
		{
         
			if(reactiveEngine_left)
			{
				   
						 g.setColor(dopColor);	
						 
						 g.fillOval(startPosX + 22, startPosY , 50, 15 ) ;
					}
					
					if(reactiveEngine_right)
					{
						 g.setColor(dopColor);	
						 
						 g.fillOval(startPosX + 22, startPosY+55 , 50, 15 ) ;
					}
					 super.drawLightAirplane(g);
					 
					 
					 if(windows)
					 {
						 g.setColor(Color.WHITE);	
						 
						 g.fillOval(startPosX + 30, startPosY+30 , 8, 8 ) ;
						 g.fillOval(startPosX + 20, startPosY+30 , 8, 8 ) ;
						 g.fillOval(startPosX + 40, startPosY+30 , 8, 8 ) ;
						 g.fillOval(startPosX + 50, startPosY+30, 8, 8 ) ;
					 }
					 
					 if (lines)
					 {
						 g.setColor(Color.RED);
						 g.fillRect(startPosX + 5, startPosY+15, 10, 40 );
						 
					 }
		}
	
}
