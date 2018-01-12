import java.awt.Color;
import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;


public class Parking {
	ClassArray<ITransport> parking;
    
	List<ClassArray<ITransport>> parkingStages;
	int currentLevel;
	
	int countPlaces = 15;   
    int placeSizeWidth = 210;
    int placeSizeHeight = 100;
    
    
	public int getCurrentLevel() {
 		return currentLevel;
 	}

 	public Parking(int countStages) {
 		parkingStages = new ArrayList<ClassArray<ITransport>>(countStages);
 		for (int i = 0; i < countStages; i++) {
 			parking = new ClassArray<ITransport>(countPlaces, null);
 			parkingStages.add(parking);
 		}
 	}

 	public void LevelUp() {
 		if (currentLevel + 1 < parkingStages.size()) {
 			currentLevel++;
 		}
 	}

 	public void LevelDown() {
 		if (currentLevel > 0) {
 			currentLevel--;
 		}
 	}

 	public int PutAirplaneInParking(ITransport airplane) {
 		
		return ClassArray.Plus(parkingStages.get(currentLevel), airplane);
 	}

 	public ITransport GetAirplaneInParking(int ticket) {
 		
 		return ClassArray.Minus(parkingStages.get(currentLevel), ticket);	
 	}


	public void Draw(Graphics g, int wigth, int height)
	{
		DrawMarking(g);
		for (int i = 0; i < countPlaces; i++)
		{
			ITransport airplane = parkingStages.get(currentLevel).getObject(i);
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
		
		g.drawString(("L" + currentLevel + 1), (countPlaces / 5) * placeSizeWidth - 70, 420);
        g.drawRect(0, 0, (countPlaces / 5) * placeSizeWidth, 510);
        for (int i = 0; i < countPlaces / 5; i++)
        {
            for (int j = 0; j < 6; ++j)
            {

                g.drawLine(i * placeSizeWidth, j * placeSizeHeight,
                    i * placeSizeWidth + 110, j * placeSizeHeight);
                if (j < 5) {
					String str = "" + (i * 5 + j + 1);
					g.drawString(str, i * placeSizeWidth + 30, j * placeSizeHeight + 20);
          
                }
                }           
            g.drawLine(i * placeSizeWidth, 0, i * placeSizeWidth, 500);

        }
    }
}