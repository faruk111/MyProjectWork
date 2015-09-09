package GuiApplication;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class EmployeeSalary extends JFrame {

	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					EmployeeSalary frame = new EmployeeSalary();
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
	public EmployeeSalary() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblSelectAEmployee = new JLabel("Select a Employee Type :");
		lblSelectAEmployee.setBounds(26, 39, 171, 23);
		contentPane.add(lblSelectAEmployee);
		
		final JComboBox emptype = new JComboBox();
		
		emptype.addItem("Permanent");
		emptype.addItem("Temporary");
		emptype.setBounds(207, 40, 104, 23);
		contentPane.add(emptype);
		
		JButton btnOk = new JButton("ok");
		btnOk.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String emptyString=(String) emptype.getSelectedItem();
				
				if(emptyString.equals("Permanent")){
					
					this.setVisible(false);
					new PermanentEmployee().setVisible(true);
				}else if(emptyString.equals("Temporary")){
					this.setVisible(false);
					new TemporaryEmployee().setVisible(true);
				}
			}

			private void setVisible(boolean b) {
				// TODO Auto-generated method stub
				
			}
		});
		btnOk.setBounds(162, 90, 89, 23);
		contentPane.add(btnOk);
		
		JButton btnCancel = new JButton("cancel");
		btnCancel.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				dispose();
			}
		});
		btnCancel.setBounds(261, 90, 89, 23);
		contentPane.add(btnCancel);
	}

}
