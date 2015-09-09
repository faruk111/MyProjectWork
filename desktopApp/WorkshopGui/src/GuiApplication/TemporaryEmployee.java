package GuiApplication;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
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

public class TemporaryEmployee extends JFrame {

	private static  JPanel contentPane;
	private static JTextField salary;
	private static JTextField id;
	private static JTextField name;
	private static JTextField hour;
	private static JTextField day;


	static Connection connection=null;
	static Statement statement=null;
	static ResultSet resultSet=null;
	static PreparedStatement preparedStatement=null;
	
	public static String url="jdbc:mysql://localhost:3306/workshop";
	public static String username="root";
	public static String passwordString="";
	private static JTextField ratePerday;
	
	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					TemporaryEmployee frame = new TemporaryEmployee();
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
	public TemporaryEmployee() {
		setTitle("TemporaryEmployee");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblId = new JLabel("Id:");
		lblId.setBounds(26, 21, 46, 14);
		contentPane.add(lblId);
		
		JLabel lblName = new JLabel("Name :");
		lblName.setBounds(26, 60, 46, 14);
		contentPane.add(lblName);
		
		JLabel lblWorkingHour = new JLabel("Working Hour :");
		lblWorkingHour.setBounds(26, 97, 75, 14);
		contentPane.add(lblWorkingHour);
		
		JLabel lblWorkingDay = new JLabel("Working Day");
		lblWorkingDay.setBounds(26, 128, 75, 14);
		contentPane.add(lblWorkingDay);
		
		JLabel lblTotalSalary = new JLabel("Total  Salary :");
		lblTotalSalary.setBounds(26, 195, 87, 14);
		contentPane.add(lblTotalSalary);
		
		salary = new JTextField();
		salary.setBounds(123, 192, 86, 20);
		contentPane.add(salary);
		salary.setColumns(10);
		
		id = new JTextField();
		id.setBounds(119, 18, 86, 20);
		contentPane.add(id);
		id.setColumns(10);
		
		name = new JTextField();
		name.setBounds(119, 57, 86, 20);
		contentPane.add(name);
		name.setColumns(10);
		
		hour = new JTextField();
		hour.setBounds(119, 94, 86, 20);
		contentPane.add(hour);
		hour.setColumns(10);
		
		day = new JTextField();
		day.setBounds(123, 125, 86, 20);
		contentPane.add(day);
		day.setColumns(10);
		
		JButton btnOk = new JButton("Ok");
		btnOk.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				String id1=id.getText();
				String name1=name.getText();
				String hour1=hour.getText();
				String rate=ratePerday.getText();
				
				String day1=day.getText();
				
				int rateInt=Integer.parseInt(rate);
				int hourInt=Integer.parseInt(hour1);
				int dayInt=Integer.parseInt(day1);
				int totalsalary=rateInt*hourInt*dayInt;
				
				
				String t=Integer.toString(totalsalary);
				salary.setText(t);
				String sa=salary.getText();
				
				try{
					connection=DriverManager.getConnection(url,username,passwordString);
					preparedStatement=connection.prepareStatement("insert into tememployee values(?,?,?,?,?)");
					
					preparedStatement.setString(1, id1);
					preparedStatement.setString(2, name1);
					preparedStatement.setString(3, hour1);
					preparedStatement.setString(4, day1);
					preparedStatement.setString(5, sa);
					
					preparedStatement.executeUpdate();
					
					id.setText(null);
					name.setText(null);
					hour.setText(null);
					day.setText(null);
					
					
					
					
					JOptionPane.showMessageDialog(null, "successful");
				}catch (SQLException e1) {
					
					e1.printStackTrace();
				}
			}
		});
		btnOk.setBounds(66, 223, 89, 23);
		contentPane.add(btnOk);
		
		JButton btnCancel = new JButton("cancel");
		btnCancel.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				dispose();
			}
		});
		btnCancel.setBounds(185, 223, 89, 23);
		contentPane.add(btnCancel);
		
		JLabel lblRatePerDay = new JLabel("Rate Per Day");
		lblRatePerDay.setBounds(26, 159, 87, 14);
		contentPane.add(lblRatePerDay);
		
		ratePerday = new JTextField();
		ratePerday.setBounds(123, 156, 86, 20);
		contentPane.add(ratePerday);
		ratePerday.setColumns(10);
	}
}
