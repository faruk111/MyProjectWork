package GuiApplication;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class PermanentEmployee extends JFrame {

	private JPanel contentPane;
	private static JTextField salary;
	private static JTextField textField;

	static Connection connection=null;
	static Statement statement=null;
	static ResultSet resultSet=null;
	static PreparedStatement preparedStatement=null;
	
	public static String url="jdbc:mysql://localhost:3306/workshop";
	public static String username="root";
	public static String passwordString="";
	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PermanentEmployee frame = new PermanentEmployee();
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
	public PermanentEmployee() {
		setTitle("PermanentEmployee");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblId = new JLabel("Id :");
		lblId.setBounds(22, 37, 46, 14);
		contentPane.add(lblId);
		
		final JComboBox id = new JComboBox();
		id.addItem("1");
		id.addItem("2");
		id.addItem("3");
		id.addItem("4");
		id.addItem("5");
		id.addItem("6");
		id.addItem("6");
		id.addItem("7");id.addItem("8");id.addItem("9");id.addItem("10");
		id.setBounds(78, 34, 93, 20);
		contentPane.add(id);
		
		JLabel lblName = new JLabel("Name :");
		lblName.setBounds(10, 73, 53, 14);
		contentPane.add(lblName);
		
		JLabel lblMonth = new JLabel("Month");
		lblMonth.setBounds(10, 104, 46, 14);
		contentPane.add(lblMonth);
		
		final JComboBox month = new JComboBox();
		
		month.addItem("january");
		month.addItem("february");
		month.addItem("march");
		month.addItem("april");
		month.addItem("may");
		month.addItem("june");
		month.addItem("july");
		month.addItem("August");
		month.addItem("September");
		month.addItem("October");
		month.addItem("November");
		month.addItem("December");
		month.setBounds(78, 101, 93, 20);
		contentPane.add(month);
		
		JLabel lblSalary = new JLabel("Salary :");
		lblSalary.setBounds(10, 150, 46, 14);
		contentPane.add(lblSalary);
		
		salary = new JTextField();
		salary.setBounds(78, 147, 86, 20);
		contentPane.add(salary);
		salary.setColumns(10);
		
		JButton btnOk = new JButton("Ok");
		btnOk.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				
				String id1=(String) id.getSelectedItem();
				String name1=textField.getText();
				String month1=(String) month.getSelectedItem();
				String salary1=salary.getText();
				try{
				connection=DriverManager.getConnection(url,username,passwordString);
				preparedStatement=connection.prepareStatement("insert into peremployee values(?,?,?,?)");
				
				preparedStatement.setString(1, id1);
				preparedStatement.setString(2, name1);
				preparedStatement.setString(3, month1);
				preparedStatement.setString(4, salary1);
				preparedStatement.executeUpdate();
				
				
				textField.setText(null);
				salary.setText(null);
				
				
				JOptionPane.showMessageDialog(null, "successful");
			}catch (SQLException e1) {
				
				e1.printStackTrace();
			}
				}
		});
		btnOk.setBounds(78, 202, 89, 23);
		contentPane.add(btnOk);
		
		JButton btnCancel = new JButton("cancel");
		btnCancel.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				dispose();
			}
		});
		btnCancel.setBounds(199, 202, 89, 23);
		contentPane.add(btnCancel);
		
		textField = new JTextField();
		textField.setBounds(73, 70, 98, 20);
		contentPane.add(textField);
		textField.setColumns(10);
	}

}
