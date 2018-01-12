import java.awt.Graphics;

/**
 * 
 */

/**
 * @author Администратор
 *
 */
public interface ITransport {
	void moveAirplane(Graphics g);

    void UpAirplane(Graphics gr);

    void DownAirplane(Graphics gr);

    void drawAirplane(Graphics g);

    void setPosition(int x, int y);

    void loadPassenger(int count);

    int getPassenger();
}





