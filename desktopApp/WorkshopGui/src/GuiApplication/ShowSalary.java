package GuiApplication;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.Frame;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.event.TableModelEvent;
import javax.swing.event.TableModelListener;
import javax.swing.table.DefaultTableModel;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.JButton;
import javax.swing.JScrollPane;
import javax.swing.JTable;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Arrays;
import java.util.Vector;

public class ShowSalary extends JFrame {

	private JPanel contentPane;

	static Connection connection=null;
	static Statement statement=null;
	static ResultSet resultSet=null;
	static PreparedStatement preparedStatement=null;
	
	public static String url="jdbc:mysql://localhost:3306/workshop";
	public static String username="root";
	public static String passwordString="";
	
	 static  String[] permanent = {"Id", " Name", "Month", "Salary"};
	 Vector column=new Vector(Arrays.asList(permanent));
	 
	 Vector rowdataVector=new Vector();
	 
	 
	 static  String[] columnNames1 = {"Id", "Name", "Working Hour", "Working Day ","Total Salary"};
	 Vector temcolumn=new Vector<>(Arrays.asList(columnNames1));
	 Vector temrowdata=new Vector<>();
	 
	 static  String[] columnNames2 = { "Total permanent Salary","Total Temporary Salary"};
	 Vector tsalarycolumnVector=new Vector(Arrays.asList(columnNames2));
	 Vector salaryrowVector=new Vector<>();
	 
	   static JTable table;
	   static Frame frame1;
	   
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ShowSalary frame = new ShowSalary();
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
	public ShowSalary() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblEnterAType = new JLabel("Enter a type :");
		lblEnterAType.setBounds(35, 37, 83, 14);
		contentPane.add(lblEnterAType);
		
		final JComboBox comboBox = new JComboBox();
		comboBox.addItem("permanent");
		comboBox.addItem("temporary");
		comboBox.setBounds(144, 31, 162, 28);
		contentPane.add(comboBox);
		
		JButton btnOk = new JButton("ok");
		btnOk.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				String combostring=(String) comboBox.getSelectedItem();
				
				if(combostring.equals("permanent")){
					
					try {
						connection=DriverManager.getConnection(url,username,passwordString);
						statement=connection.createStatement();
						
						String sql1="select id,name,month,salary from peremployee";
						resultSet=statement.executeQuery(sql1);
						

				            while (resultSet.next()) {

				               String id = resultSet.getString("id");
				               String    name = resultSet.getString("name");
				               String  month = resultSet.getString("month");
				               String   salary = resultSet.getString("salary");
				                
				              Vector rowvalueVector=new Vector<>(Arrays.asList(id,name,month,salary));
				              rowdataVector.add(rowvalueVector);

				               

				                

				            }
				            
				            frame1 = new JFrame("Database Search Result");

				            ((JFrame) frame1).setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

				            frame1.setLayout(new BorderLayout());
				            JTable table=new JTable(rowdataVector,column);
				            JScrollPane scrollPane = new JScrollPane(table);
				    		scrollPane.setBounds(0, 5, 427, 121);
				    		table.getModel().addTableModelListener(new TableModelListener() {
				    			
				    			@Override
				    			public void tableChanged(TableModelEvent e) {
				    				// TODO Auto-generated method stub
				    				
				    				System.out.println(e);
				    				
				    			}
				    		});
				    		frame1.add(scrollPane);

				            frame1.setVisible(true);

				            frame1.setSize(400, 300);

				            
						
					} catch (SQLException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}else if(combostring.equals("temporary")){
					
					try {
						connection=DriverManager.getConnection(url,username,passwordString);
						statement=connection.createStatement();
						
						String sql1="select * from tememployee";
						resultSet=statement.executeQuery(sql1);
						
					        String id="";
					        String name = "";
					        String whour = "";
					        String wday = "";
					        String tsalary = "";
					        
					        
					  

				            while(resultSet.next()) {

				                id = resultSet.getString("id");
				                name = resultSet.getString("name");
				                whour = resultSet.getString("hour");
				                wday = resultSet.getString("day");
				                tsalary = resultSet.getString("tsalary");
				                
				              Vector temval=new Vector<>(Arrays.asList(id,name,whour,wday,tsalary));
				              temrowdata.add(temval);

				            }
				            
				            frame1 = new JFrame("Database Search Result");

				            ((JFrame) frame1).setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
				            
				            JTable table=new JTable(temrowdata,temcolumn);
				            JScrollPane scrollPane = new JScrollPane(table);
				    		scrollPane.setBounds(0, 5, 427, 121);
				    		frame1.add(scrollPane);

				            frame1.setLayout(new BorderLayout());
				            frame1.setVisible(true);
				            frame1.setSize(400, 300);

				            
						
					} catch (SQLException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
					
				}
				
				
			}
		});
		btnOk.setBounds(174, 78, 83, 23);
		contentPane.add(btnOk);
		
		JButton btnShowTotalSalary = new JButton("show Total Salary");
		btnShowTotalSalary.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					connection=DriverManager.getConnection(url,username,passwordString);
					statement=connection.createStatement();
					
					String sql1="select peremployee.salary,tememployee.tsalary from peremployee,tememployee";
					resultSet=statement.executeQuery(sql1);
				
				        String salary = "";
				        String finalsalary = "";
				        String tsalary = "";
				        String finaltsalary = "";
				        
				        
				       
				        double sum1=0,sum2=0;

			            while(resultSet.next()) {

			                salary = resultSet.getString("salary");
			               double salary1=Double.parseDouble(salary);
			             sum1=sum1+salary1;
			             finalsalary=Double.toString(sum1);
			                
			                tsalary = resultSet.getString("tsalary");
			                double tsalary1=Double.parseDouble(tsalary);
				             sum2=sum2+tsalary1;
				             finaltsalary=Double.toString(sum2);

			                Vector rowvalueVector=new Vector<>(Arrays.asList(finalsalary,finaltsalary));
			                salaryrowVector.add(rowvalueVector);
			                
			           }
			            
			            frame1 = new JFrame("Database Search Result");

			            ((JFrame) frame1).setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			            JTable table=new JTable(salaryrowVector,tsalarycolumnVector);
			            JScrollPane scrollPane = new JScrollPane(table);
			    		scrollPane.setBounds(0, 5, 427, 121);
			    		frame1.add(scrollPane);

			            frame1.setLayout(new BorderLayout());
			            frame1.setVisible(true);

			            frame1.setSize(400, 300);

			            
					
				} catch (SQLException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		btnShowTotalSalary.setBounds(144, 128, 162, 39);
		contentPane.add(btnShowTotalSalary);
		
		JButton btnClose = new JButton("close");
		btnClose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				dispose();
			}
		});
		btnClose.setBounds(174, 223, 89, 23);
		contentPane.add(btnClose);
	}
}
