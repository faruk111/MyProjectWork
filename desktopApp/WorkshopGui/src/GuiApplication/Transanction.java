package GuiApplication;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import javax.swing.JTextField;

public class Transanction extends JFrame {

	private static JPanel contentPane;
	private static JTextField id;
	private static JTextField name;
	private static JTextField tprice;
	private static JTextField pprice;
	private static JTextField dprice;

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
					Transanction frame = new Transanction();
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
	public Transanction() {
		setTitle("Transanction");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblItemId = new JLabel("Item Id :");
		lblItemId.setBounds(10, 29, 67, 14);
		contentPane.add(lblItemId);
		
		JLabel lblItemName = new JLabel("Item Name :");
		lblItemName.setBounds(10, 54, 67, 14);
		contentPane.add(lblItemName);
		
		JLabel lblNewLabel = new JLabel("Total Price");
		lblNewLabel.setBounds(10, 79, 67, 14);
		contentPane.add(lblNewLabel);
		
		JLabel lblPaidPrice = new JLabel("Paid Price");
		lblPaidPrice.setBounds(10, 104, 67, 14);
		contentPane.add(lblPaidPrice);
		
		JLabel lblDuePrice = new JLabel("Due Price :");
		lblDuePrice.setBounds(10, 129, 67, 14);
		contentPane.add(lblDuePrice);
		
		JButton btnOk = new JButton("OK");
		btnOk.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
			String id1=id.getText();
			String name1=name.getText();
			String tprice1=tprice.getText();
			String pprice1=pprice.getText();
			String dprice1=dprice.getText();
			
			try {
				connection=DriverManager.getConnection(url, username, passwordString);
				preparedStatement=connection.prepareStatement("insert into transanction values(?,?,?,?,?)");
				
				preparedStatement.setString(1, id1);
				preparedStatement.setString(2, name1);
				preparedStatement.setString(3, tprice1);
				preparedStatement.setString(4, pprice1);
				preparedStatement.setString(5, dprice1);
				
				preparedStatement.executeUpdate();
				
				id.setText(null);
				name.setText(null);
				tprice.setText(null);
				pprice.setText(null);
				dprice.setText(null);
				
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			
			}
		});
		btnOk.setBounds(37, 173, 89, 23);
		contentPane.add(btnOk);
		
		JButton btnCancel = new JButton("Cancel");
		btnCancel.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				dispose();
			}
		});
		btnCancel.setBounds(164, 173, 89, 23);
		contentPane.add(btnCancel);
		
		id = new JTextField();
		id.setBounds(93, 26, 132, 20);
		contentPane.add(id);
		id.setColumns(10);
		
		name = new JTextField();
		name.setBounds(93, 51, 132, 20);
		contentPane.add(name);
		name.setColumns(10);
		
		tprice = new JTextField();
		tprice.setBounds(93, 76, 132, 20);
		contentPane.add(tprice);
		tprice.setColumns(10);
		
		pprice = new JTextField();
		pprice.setBounds(93, 101, 132, 20);
		contentPane.add(pprice);
		pprice.setColumns(10);
		
		dprice = new JTextField();
		dprice.setBounds(93, 126, 132, 20);
		contentPane.add(dprice);
		dprice.setColumns(10);
	}
}
