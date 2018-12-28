package laba1tp;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.border.EmptyBorder;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;


public class FormTruck extends JFrame{

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private Truck truck;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					FormTruck frame = new FormTruck();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	@Override
	public void paint(Graphics g) {
		super.paint(g);
		try {
			if (truck != null) {
				truck.drawTruck(g);
			}
		} catch (Exception ex) {

		}
	}

	public void moveButton(JButton sender) {
		try {
			String name = sender.getToolTipText();
			switch (name) {
			case "Up":
				truck.moveTruck(Direction.Up);
				break;
			case "Down":
				truck.moveTruck(Direction.Down);
				break;
			case "Left":
				truck.moveTruck(Direction.Left);
				break;
			case "Right":
				truck.moveTruck(Direction.Right);
				break;
			}
			this.repaint();
		} catch (Exception ex) {
			System.out.print("Click on the button <Создать>! ");
		}
	}

	/**
	 * Create the frame.
	 */
	public FormTruck() {

		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 900, 500);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);

		JButton buttonCreate = new JButton("\u0421\u043E\u0437\u0434\u0430\u0442\u044C");
		buttonCreate.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				try {
					truck = new Truck(100 + (int) (Math.random() * 300), 1000 + (int) (Math.random() * 2000),
							Color.YELLOW, Color.BLACK, true, true);
				} catch (Exception e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}

				try {
					truck.setPosition(70 + (int) (Math.random() * 160), 70 + (int) (Math.random() * 160),
							FormTruck.this.getWidth(), FormTruck.this.getHeight());
				} catch (Exception e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}

				FormTruck.this.repaint();

			}
		});
		buttonCreate.setBounds(10, 11, 89, 29);
		contentPane.add(buttonCreate);

		JButton buttonUp = new JButton("");
		buttonUp.setIcon(new ImageIcon("C:\\Users\\User\\workspace\\laba1tp\\Up.png"));
		buttonUp.setToolTipText("Up");
		buttonUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				moveButton(buttonUp);
			}
		});
		buttonUp.setBounds(804, 369, 35, 35);
		contentPane.add(buttonUp);

		JButton buttonLeft = new JButton("");
		buttonLeft.setIcon(new ImageIcon("C:\\Users\\User\\workspace\\laba1tp\\Left.png"));
		buttonLeft.setToolTipText("Left");
		buttonLeft.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				moveButton(buttonLeft);
			}
		});
		buttonLeft.setBounds(759, 415, 35, 35);
		contentPane.add(buttonLeft);

		JButton buttonDown = new JButton("");
		buttonDown.setIcon(new ImageIcon("C:\\Users\\User\\workspace\\laba1tp\\Down.png"));
		buttonDown.setToolTipText("Down");
		buttonDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				moveButton(buttonDown);
			}
		});
		buttonDown.setBounds(804, 415, 35, 35);
		contentPane.add(buttonDown);

		JButton buttonRight = new JButton("");
		buttonRight.setIcon(new ImageIcon("C:\\Users\\User\\workspace\\laba1tp\\Right.png"));
		buttonRight.setToolTipText("Right");
		buttonRight.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				moveButton(buttonRight);
			}
		});
		buttonRight.setBounds(849, 415, 35, 35);
		contentPane.add(buttonRight);
	}

}