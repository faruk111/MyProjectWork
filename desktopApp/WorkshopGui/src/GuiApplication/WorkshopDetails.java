package GuiApplication;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.Toolkit;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.WindowEvent;

public class  WorkshopDetails extends JFrame {

	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					WorkshopDetails frame = new WorkshopDetails();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public WorkshopDetails() {
		setTitle("WorkshopDetails");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblName = new JLabel("Name :");
		lblName.setBounds(10, 25, 57, 29);
		contentPane.add(lblName);
		
		JLabel lblNewLabel = new JLabel("owner :");
		lblNewLabel.setBounds(10, 65, 46, 14);
		contentPane.add(lblNewLabel);
		
		JLabel lblCity = new JLabel("city :");
		lblCity.setBounds(10, 109, 46, 14);
		contentPane.add(lblCity);
		
		JLabel lblCountry = new JLabel("country :");
		lblCountry.setBounds(10, 146, 46, 14);
		contentPane.add(lblCountry);
		
		JLabel lblNewLabel_1 = new JLabel("Al Modina Workshop");
		lblNewLabel_1.setBounds(77, 25, 117, 21);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblShafiqulIslamShahin = new JLabel("Shafiqul Islam Shahin ");
		lblShafiqulIslamShahin.setBounds(74, 65, 120, 21);
		contentPane.add(lblShafiqulIslamShahin);
		
		JLabel lblJeddah = new JLabel("Jeddah");
		lblJeddah.setBounds(72, 109, 82, 21);
		contentPane.add(lblJeddah);
		
		JLabel lblSoudiArabia = new JLabel("Soudi Arabia");
		lblSoudiArabia.setBounds(68, 146, 98, 21);
		contentPane.add(lblSoudiArabia);
		
		JButton btnClose = new JButton("close");
		btnClose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				dispose();
			}

			
			
		});
		btnClose.setBounds(131, 190, 89, 23);
		contentPane.add(btnClose);
	}

}
