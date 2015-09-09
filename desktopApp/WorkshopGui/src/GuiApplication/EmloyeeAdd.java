package GuiApplication;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JComboBox;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class EmloyeeAdd extends JFrame {

	private static JPanel contentPane;
	private static JTextField id;
	private static JTextField name;
	private  static JTextField address;

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
					EmloyeeAdd frame = new EmloyeeAdd();
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
	public EmloyeeAdd() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblEmployeeid = new JLabel("EmployeeId :");
		lblEmployeeid.setBounds(25, 25, 78, 14);
		contentPane.add(lblEmployeeid);
		
		JLabel lblEmployeeName = new JLabel("Employee Name:");
		lblEmployeeName.setBounds(31, 65, 94, 14);
		contentPane.add(lblEmployeeName);
		
		JLabel lblEmployeeAddress = new JLabel("Employee Address :");
		lblEmployeeAddress.setBounds(31, 109, 95, 14);
		contentPane.add(lblEmployeeAddress);
		
		JLabel lblEmployeeType = new JLabel("Employee Type  :");
		lblEmployeeType.setBounds(31, 154, 94, 14);
		contentPane.add(lblEmployeeType);
		
		id = new JTextField();
		id.setBounds(140, 22, 135, 20);
		contentPane.add(id);
		id.setColumns(10);
		
		name = new JTextField();
		name.setBounds(140, 62, 135, 20);
		contentPane.add(name);
		name.setColumns(10);
		
		address = new JTextField();
		address.setBounds(140, 106, 135, 20);
		contentPane.add(address);
		address.setColumns(10);
		
		final JComboBox type = new JComboBox();
		type.setBounds(144, 151, 131, 20);
		
		type.addItem("temporary");
		type.addItem("Permanent");
		contentPane.add(type);
		
		JButton btnAdd = new JButton("Add");
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				String  id1=id.getText();
				String name1=name.getText();
				String address1=address.getText();
				String type1=(String) type.getSelectedItem();
				
				try {
					connection=DriverManager.getConnection(url,username,passwordString);
					preparedStatement=connection.prepareStatement("insert into employee values(?,?,?,?)");
					
					preparedStatement.setString(1, id1);
					preparedStatement.setString(2, name1);
					preparedStatement.setString(3, address1);
					preparedStatement.setString(4, type1);
					preparedStatement.executeUpdate();
					
					id.setText(null);
					name.setText(null);
					address.setText(null);
					
					JOptionPane.showMessageDialog(null, "successful");
					
				} catch (SQLException e) {
					
					e.printStackTrace();
				}
				
			}
		});
		btnAdd.setBounds(137, 209, 89, 23);
		contentPane.add(btnAdd);
		
		JButton btnCancel = new JButton("cancel");
		btnCancel.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				dispose();
			}
		});
		btnCancel.setBounds(253, 209, 89, 23);
		contentPane.add(btnCancel);
	}
}
