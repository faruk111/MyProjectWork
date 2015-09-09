package GuiApplication;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.Frame;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Vector;

public class ShowCost extends JFrame {

	private JPanel contentPane;

	public static Connection connection=null;
	public static Statement statement=null;
	public static ResultSet resultSet=null;
	public static PreparedStatement preparedStatement=null;
	
	public static String url="jdbc:mysql://localhost:3306/workshop";
	public static String username="root";
	public static String passwordString="";
	


   static  String[] columnNames = {"Id", "Item Name", "Total Price", "Paid Price","Due Price"};
   
   Vector columnVector=new Vector<>(Arrays.asList(columnNames));
   Vector rowVector=new Vector<>();
   
   static JTable table;
   static Frame frame1;
   
	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ShowCost frame = new ShowCost();
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
	public ShowCost() {
		setTitle("Showcost");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JButton btnShowallduebill = new JButton("Show All Transanction");
		btnShowallduebill.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				try {
					connection=DriverManager.getConnection(url,username,passwordString);
					statement=connection.createStatement();
					
					String sql1="select * from transanction";
					resultSet=statement.executeQuery(sql1);
					
			            while (resultSet.next()) {
			            	
			               String id = resultSet.getString("id");
			              
			             
			                String name = resultSet.getString("itemname");

			                String tprice = resultSet.getString("tprice");

			               String  pprice  = resultSet.getString("pprice");
			                
			                String dprice = resultSet.getString("dprice");

			               Vector rowvlue=new Vector(Arrays.asList(id,name,tprice,pprice,dprice));
			               
			               rowVector.add(rowvlue);
			               

			            }
			           
			            
			            frame1 = new JFrame("Database Search Result");

			            ((JFrame) frame1).setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

			            frame1.setLayout(new BorderLayout());
			            JTable table=new JTable(rowVector,columnVector);
			            JScrollPane scrollPane = new JScrollPane(table);
			    		scrollPane.setBounds(0, 5, 427, 121);
			    		frame1.add(scrollPane);
			           

			            frame1.setVisible(true);

			            frame1.setSize(400, 300);

			            
					
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
			}
		});
		btnShowallduebill.setBounds(10, 30, 149, 23);
		contentPane.add(btnShowallduebill);
		
		JButton btnClose = new JButton("close");
		btnClose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				dispose();
			}
		});
		btnClose.setBounds(212, 223, 89, 23);
		contentPane.add(btnClose);
		
		JButton btnShowSalary = new JButton("Show Salary");
		btnShowSalary.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				this.setVisible(false);
				new ShowSalary().setVisible(true);
			}

			private void setVisible(boolean b) {
				// TODO Auto-generated method stub
				
			}
		});
		btnShowSalary.setBounds(10, 64, 149, 23);
		contentPane.add(btnShowSalary);
	}
}
