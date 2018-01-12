import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.regex.Matcher;

import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;


public class Form1 {

	

	private JFrame frame;

	
	private JTextField TextField_angar;
	Matcher m;
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
	int SelectedIndex;
	String[] data;
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
		parking = new Parking(5);
		SelectedIndex = -1;
		data = new String[6];
		for (int i = 0; i < data.length; i++) {
			data[i] = "Уровень " + i;
		}
		initialize();
	}

	private void Draw(JPanel panel) {
		
				if (parking.getCurrentLevel() > -1) {
					//
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					parking.Draw(gr, panel.getWidth(), panel.getHeight());
				}
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

	
		final JList listbox_levels = new JList(data);
		listbox_levels.setBounds(670, 112, 233, 108);
		frame.getContentPane().add(listbox_levels);
		listbox_levels.setSelectedIndex(parking.getCurrentLevel());
		
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
		btn_Airplane.setBounds(670, 57, 100, 29);
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

				inter = new Aerobus(100, 4, 1000, color, true, true,true,true, dopcolor);
				int place = parking.PutAirplaneInParking(inter);
				Draw(panel);
				JOptionPane.showMessageDialog(frame, "Ваше место: " + place);

			}
		});
		btn_Aerobus.setBounds(780, 57, 122, 29);
		frame.getContentPane().add(btn_Aerobus);
		
		
		JLabel btn_NumberAngar = new JLabel("\u2116 \u0410\u043D\u0433\u0430\u0440\u0430:");
		btn_NumberAngar.setBounds(699, 323, 67, 17);
		frame.getContentPane().add(btn_NumberAngar);

		TextField_angar = new JTextField();
		TextField_angar.setBounds(780, 320, 67, 20);
		frame.getContentPane().add(TextField_angar);

		final JPanel view_Plane = new JPanel();
		view_Plane.setBounds(670, 391, 233, 214);
		frame.getContentPane().add(view_Plane);

		JButton btn_TakeAirplane = new JButton("\u0412\u044B\u0431\u0440\u0430\u0442\u044C");
		btn_TakeAirplane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				
				if (listbox_levels.getSelectedIndex() > -1) {
					String level = listbox_levels.getSelectedValue().toString();
					//
					if (TextField_angar.getText() != "") {
						ITransport airplane = parking.GetAirplaneInParking(Integer
								.parseInt(TextField_angar.getText()));
						if (airplane != null) {
							Graphics gr = view_Plane.getGraphics();
							gr.clearRect(0, 0, view_Plane.getWidth(),view_Plane.getHeight());
							airplane.setPosition(30, 30);
							airplane.drawAirplane(gr);
							Draw(panel);
						}
					}
				}
			}
		});
		btn_TakeAirplane.setBounds(709, 351, 156, 29);
		frame.getContentPane().add(btn_TakeAirplane);

		JButton btn_DrawParking = new JButton("Draw Parking");
		btn_DrawParking.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Draw(panel);
			}
		});
		btn_DrawParking.setBounds(670, 17, 232, 29);
		frame.getContentPane().add(btn_DrawParking);
		

		JButton btn_up = new JButton(">>");
		btn_up.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				parking.LevelUp();
				listbox_levels.setSelectedIndex(parking.getCurrentLevel());
				Draw(panel);
			}
		});
		btn_up.setBounds(795, 246, 108, 39);
		frame.getContentPane().add(btn_up);
		
		JButton btn_down = new JButton("<<");
		btn_down.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				parking.LevelDown();
				listbox_levels.setSelectedIndex(parking.getCurrentLevel());
				Draw(panel);
			}
		});
		btn_down.setBounds(670, 246, 115, 39);
		frame.getContentPane().add(btn_down);
		
		
		}
}
