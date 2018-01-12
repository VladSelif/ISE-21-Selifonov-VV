import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;


public class Form1 {

	private JFrame frame;

	private JTextField TextField_angar;	
	Parking parking;
	Color color;
	Color dopcolor;
	int maxSpeed;
	int maxCountPassengers;
	int weight;
	Boolean reactiveEngine_left = false;
	Boolean reactiveEngine_right = false;
	Boolean windows = false;
	Boolean lines = false;
	private ITransport inter;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form1 window = new Form1();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Form1() {
		color = Color.WHITE;
		dopcolor = Color.YELLOW;
		maxSpeed = 150;
		maxCountPassengers = 4;
		weight = 1500;
		parking = new Parking();
		initialize();
	}

	private void Draw(JPanel panel) {
		Graphics gr = panel.getGraphics();
		gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
		parking.Draw(gr, panel.getWidth(), panel.getHeight());
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {

		frame = new JFrame();
		frame.setBounds(100, 100, 970, 689);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		final JPanel panel = new JPanel();
		panel.setBounds(10, 5, 603, 600);
		frame.getContentPane().add(panel);


		final JButton btn_Airplane = new JButton("Airplane");
		btn_Airplane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = btn_Airplane.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				color = foreground;

				inter = new Airplane(100, 4, 1000, color);
				int place = parking.PutAirplaneInParking(inter);
				Draw(panel);
				JOptionPane.showMessageDialog(frame, "Ваше место: " + place);
			}
		});
		btn_Airplane.setBounds(666, 132, 101, 99);
		frame.getContentPane().add(btn_Airplane);

		
		
		JButton btn_Aerobus = new JButton("Aerobus");
		btn_Aerobus.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Color initialBackground = btn_Airplane.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				color = foreground;

				Color initialBackground1 = btn_Airplane.getForeground();
				Color foreground1 = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground1);
				dopcolor = foreground1;

				inter = new Aerobus(100, 4, 1000, color, true, true, true,true,dopcolor);
				int place = parking.PutAirplaneInParking(inter);
				Draw(panel);
				JOptionPane.showMessageDialog(frame, "Ваше место: " + place);

			}
		});
		btn_Aerobus.setBounds(785, 132, 107, 99);
		frame.getContentPane().add(btn_Aerobus);

		
		
		JLabel btn_NumberAngar = new JLabel("\u2116 \u0410\u043D\u0433\u0430\u0440\u0430:");
		btn_NumberAngar.setBounds(692, 295, 69, 20);
		frame.getContentPane().add(btn_NumberAngar);

		TextField_angar = new JTextField();
		TextField_angar.setBounds(756, 295, 60, 20);
		frame.getContentPane().add(TextField_angar);

		final JPanel view_Airplane = new JPanel();
		view_Airplane.setBounds(703, 375, 191, 230);
		frame.getContentPane().add(view_Airplane);

		JButton btn_TakeAirplane = new JButton("\u0412\u044B\u0431\u0440\u0430\u0442\u044C");
		btn_TakeAirplane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				if (TextField_angar.getText() != "") {
					ITransport airplane = parking.GetPlaneInParking(Integer
							.parseInt(TextField_angar.getText()));
					if (airplane != null) {
						Graphics gr = view_Airplane.getGraphics();
						gr.clearRect(0, 0, view_Airplane.getWidth(),
								view_Airplane.getHeight());
						airplane.setPosition(30, 30);
						airplane.drawAirplane(gr);
						Draw(panel);
					}
				}
			}
		});
		btn_TakeAirplane.setBounds(702, 335, 135, 29);
		frame.getContentPane().add(btn_TakeAirplane);

		JButton btn_DrawParking = new JButton("Draw Parking");
		btn_DrawParking.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Draw(panel);
			}
		});
		btn_DrawParking.setBounds(666, 65, 226, 56);
		frame.getContentPane().add(btn_DrawParking);
	}	
}
