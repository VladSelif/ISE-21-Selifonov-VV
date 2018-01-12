import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;



public class Form1 
{
	private JFrame frame;
	private JTextField TextFMaxSpeed;
	private JTextField TextFWeight;
	private JTextField TexFMaxCountPassengers;
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
	public Form1() 
	{
		color = Color.GRAY;
		dopcolor = Color.BLACK;
		maxSpeed = 150;
		maxCountPassengers = 4;
		weight = 1500;
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(0, 0, 781, 512);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		final JPanel panel = new JPanel();
		panel.setBounds(0, 0, 765, 348);
		frame.getContentPane().add(panel);
		
		JLabel Label_MaxSpeed = new JLabel("Max Speed:");
		Label_MaxSpeed.setBounds(19, 367, 75, 20);
		frame.getContentPane().add(Label_MaxSpeed);
		
		JLabel Label_Count_Pass = new JLabel("Count Pass:");
		Label_Count_Pass.setBounds(26, 398, 68, 14);
		frame.getContentPane().add(Label_Count_Pass);
		
		JLabel Label_weight = new JLabel("Weight:");
		Label_weight.setBounds(45, 439, 46, 14);
		frame.getContentPane().add(Label_weight);
		
		final JCheckBox checkBox1 = new JCheckBox("left_engine");
		checkBox1.setBounds(182, 366, 102, 23);
		frame.getContentPane().add(checkBox1);
		
		final JCheckBox checkBox2 = new JCheckBox("right_engine");
		checkBox2.setBounds(182, 394, 102, 23);
		frame.getContentPane().add(checkBox2);
		
		final JCheckBox CheckBox3 = new JCheckBox("windows");
		CheckBox3.setBounds(284, 366, 97, 23);
		frame.getContentPane().add(CheckBox3);
		
		final JCheckBox CheckBox4 = new JCheckBox("lines");
		CheckBox4.setBounds(284, 394, 97, 23);
		frame.getContentPane().add(CheckBox4);
		
		
		//кнопки с цветом
		final JButton Color = new JButton("Color");
		Color.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color initialBackground = Color.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					Color.setForeground(foreground);
				}
				color = foreground;
			}
		});
		Color.setBounds(485, 366, 83, 35);
		frame.getContentPane().add(Color);
		
		final JButton DopColor = new JButton("Dop Color");
		DopColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = DopColor.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					DopColor.setForeground(foreground);
				}
				dopcolor = foreground;
			}
		});
		DopColor.setBounds(485, 420, 83, 33);
		frame.getContentPane().add(DopColor);
		
		//UpMove
		JButton button_upMove = new JButton("\u0412\u0437\u043B\u0435\u0442");
		button_upMove.addActionListener(new ActionListener() {
		    public void actionPerformed(ActionEvent e) {
		        if (inter != null) {
			     Graphics gr = panel.getGraphics();
			     gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
			     inter.UpAirplane(gr);
                }
		    }
		});
		button_upMove.setBounds(578, 366, 79, 35);
		frame.getContentPane().add(button_upMove);
		
		//DownMove
		JButton button_downMove = new JButton("\u0421\u043D\u0438\u0436\u0435\u043D\u0438\u0435");
		button_downMove.addActionListener(new ActionListener() {
		    public void actionPerformed(ActionEvent e) {
		    	   if (inter != null) {
					     Graphics gr = panel.getGraphics();
					     gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					     inter.DownAirplane(gr);
	            }
		    }
		});
		button_downMove.setBounds(667, 366, 88, 35);
		frame.getContentPane().add(button_downMove);
		
		//Aerobus
		JButton button_Aerobus = new JButton("Aerobus");
		button_Aerobus.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					reactiveEngine_left = checkBox1.isSelected();
					reactiveEngine_right = checkBox2.isSelected();
					windows = CheckBox3.isSelected();
					lines = CheckBox4.isSelected();
					inter = new Aerobus(maxSpeed, maxCountPassengers,weight, color,reactiveEngine_left,reactiveEngine_right, windows, lines, dopcolor);
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
	                inter.drawAirplane(gr);
				}
			}
		});
		button_Aerobus.setBounds(387, 420, 88, 33);
		frame.getContentPane().add(button_Aerobus);
		
		//Airplane
		JButton button_Airplane = new JButton("Airplane");
		button_Airplane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
				 inter = new Airplane(maxSpeed, maxCountPassengers, weight, color);
				 Graphics gr = panel.getGraphics();
				 gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
				 inter.drawAirplane(gr);
				}
			}
		});
		button_Airplane.setBounds(387, 366, 88, 35);
		frame.getContentPane().add(button_Airplane);
		
		//Полет
		JButton button_move = new JButton("\u041F\u043E\u043B\u0435\u0442");
		button_move.addActionListener(new ActionListener() {
		    public void actionPerformed(ActionEvent e) {
		        if (inter != null) {
			     Graphics gr = panel.getGraphics();
			     gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
			     inter.moveAirplane(gr);
                }
		    }
		});
		button_move.setBounds(578, 419, 177, 35);
		frame.getContentPane().add(button_move);
		
		TextFMaxSpeed = new JTextField();
		TextFMaxSpeed.setBounds(98, 367, 68, 20);
		frame.getContentPane().add(TextFMaxSpeed);
		TextFMaxSpeed.setColumns(10);
		
		TexFMaxCountPassengers = new JTextField();
		TexFMaxCountPassengers.setBounds(98, 398, 69, 20);
		frame.getContentPane().add(TexFMaxCountPassengers);
		TexFMaxCountPassengers.setColumns(10);
		
		TextFWeight = new JTextField();
		TextFWeight.setBounds(98, 436, 68, 20);
		frame.getContentPane().add(TextFWeight);
		TextFWeight.setColumns(10);
		
        }
	private static boolean isDigit(String s) throws NumberFormatException {
		try {
			Integer.parseInt(s);
			return true;
		} catch (NumberFormatException e) {
			return false;
		}
	}
	
	private boolean checkFields() {
		if (isDigit(TextFMaxSpeed.getText())) {
			maxSpeed = Integer.parseInt(TextFMaxSpeed.getText());
		}

		if (isDigit(TexFMaxCountPassengers.getText())) {
			maxCountPassengers = Integer.parseInt(TexFMaxCountPassengers.getText());
		}

		if (isDigit(TextFWeight.getText())) {
			weight = Integer.parseInt(TextFWeight.getText());
		}

		if (isDigit(TextFMaxSpeed.getText())) {
			maxSpeed = Integer.parseInt(TextFMaxSpeed.getText());
		}
         return true;
	}
}
