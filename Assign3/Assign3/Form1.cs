/* 
  CSCI 680
  Name: PRASHANTH KADAGANCHI
  ZID: Z1829989
  Assignment: 03
  Due Date: 03/07/2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace Assign3
{
    public partial class Form1 : Form // A partial class named Form1 which is subclass of Form
    {
        public Form1()
        {
            InitializeComponent();
            this.execute.Click += new System.EventHandler(this.execute_Click); // All the buttons are being attached to their respective event handlers
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.exit.Click += new System.EventHandler(this.exit_Click);
        }

        private void Form1_Load(object sender, EventArgs e) // The inner statements get executed when a form loads
        {
            try // try block
            {
                using (MySqlConnection connection = new MySqlConnection("server=10.158.56.53;uid=csci473g45;pwd=wordpass45;database=csci473g45;")) // Making a MySqlConnection
                {
                    connection.Open(); // Opening a connection 
                    MySqlCommand drop3 = new MySqlCommand("DROP Table IF exists ClassTable", connection); // Dropping the ClassTable if it already exists
                    drop3.ExecuteNonQuery(); 
                    MySqlCommand drop1 = new MySqlCommand("DROP Table IF exists RoomTable", connection); // Dropping the RoomTable if it already exists
                    drop1.ExecuteNonQuery();
                    MySqlCommand drop2 = new MySqlCommand("DROP Table IF exists OfficeTable", connection); // Dropping the OfficeTable if it already exists
                    drop2.ExecuteNonQuery();
          
                    MySqlCommand command1 = new MySqlCommand("Create Table RoomTable (Room varchar(3) PRIMARY KEY, Capacity int, Smart char(1))", connection); // Creating a RoomTable
                    command1.ExecuteNonQuery();
                    MySqlCommand command2 = new MySqlCommand("Create Table OfficeTable (Teacher varchar(20) PRIMARY KEY, Office int)", connection); // Creating an OfficeTable
                    command2.ExecuteNonQuery();
                    MySqlCommand command3 = new MySqlCommand("Create Table ClassTable (ClassNum varchar(10) PRIMARY KEY, Teacher varchar(20), Room varchar(3), Time varchar(5), Days varchar(5), Enrollment int, FOREIGN KEY (Teacher) references OfficeTable(Teacher), FOREIGN KEY (Room) references RoomTable(Room))", connection); // Creating a ClassTable
                    command3.ExecuteNonQuery();
                    using (StreamReader SR = new StreamReader("Room.txt")) // Here StreamReader is used to read data from a Room.text file
                    {
                        String S = SR.ReadLine();
                        while (S != null) // Checks whether the file contains data or not
                        {
                            String[] SArray = S.Split(',');  // Room.txt contains tab-delimited fields.
                            int M = Convert.ToInt32(SArray[1]); // Converts string type to integer type 
                            String SqlString = "Insert Into RoomTable (Room, Capacity, Smart) Values('" + SArray[0] + "', " + M.ToString() + ", '" + SArray[2] + "')"; // Inserting values into RoomTable
                            MySqlCommand Command2 = new MySqlCommand(SqlString, connection);
                            Command2.ExecuteNonQuery(); // Executing the MySqlCommand 
                            S = SR.ReadLine();
                        }// end of while
                        SR.Close(); // Closing the file
                    } // end of using for StreamReader
                    using (StreamReader SR = new StreamReader("Office.txt")) // Here StreamReader is used to read data from a Office.text file
                    {
                        String S = SR.ReadLine();
                        while (S != null) // Checks whether the file contains data or not
                        {
                            String[] SArray = S.Split(',');  // Office.txt contains tab-delimited fields.
                            int M = Convert.ToInt32(SArray[1]); // Converts string type to integer type 
                            String SqlString = "Insert Into OfficeTable (Teacher, Office) Values('" + SArray[0] + "', " + M.ToString() + ")"; // Inserting values into OfficeTable
                            MySqlCommand Command2 = new MySqlCommand(SqlString, connection);
                            Command2.ExecuteNonQuery(); // Executing the MySqlCommand
                            S = SR.ReadLine();
                        }// end of while
                        SR.Close();
                    } // end of using for StreamReader
                    using (StreamReader SR = new StreamReader("Class.txt")) // Here StreamReader is used to read data from a Class.text file
                    {
                        String S = SR.ReadLine();
                        while (S != null)
                        {
                            String[] SArray = S.Split(',');  // Class.txt contains tab-delimited fields.
                            int M = Convert.ToInt32(SArray[5]);
                            String SqlString = "Insert Into ClassTable (ClassNum, Teacher, Room, Time, Days, Enrollment) Values('" + SArray[0] + "', '" + SArray[1] + "', " + SArray[2] + ", '" + SArray[3] + "', '" + SArray[4] + "', " + M.ToString() + ")"; // Inserting values into ClassTable
                            MySqlCommand Command2 = new MySqlCommand(SqlString, connection);
                            Command2.ExecuteNonQuery();
                            S = SR.ReadLine();
                        }// end of while
                        SR.Close();
                    } // end of using for StreamReader
                    DataTable allTables = connection.GetSchema("Tables"); // All the table names are being stored in allTables
                    foreach (DataRow dt in allTables.Rows)
                        listBox1.Items.Add(dt[2].ToString()); // Printing the table names in the listBox
                    connection.Close(); // Closing the connection
                }
            }
            catch (MySqlException error) // Catch block to handle any exception
            {
                listBox1.Items.Add("Error: " + error.Message);
            }
        }
        private void execute_Click(object sender, EventArgs e) // When the execute button is clicked this method gets called
        {
            try // try block
            {
                using (MySqlConnection connection = new MySqlConnection("server=10.158.56.53;uid=csci473g45;pwd=wordpass45;database=csci473g45;"))
                {
                    connection.Open();
                    String name1 = textBox1.Text; // The sql command given in text box is stored in name1
                    listBox1.Items.Clear(); // Clearing the list box
                    String[] SArray = name1.Split(' '); // Spliting the sql command in the textbox whenever a space is present and stored in an array 
                    if(SArray[0] == "Select" || SArray[0] == "select") // Checks whether the first element in array is select or not
                    {
                        if(SArray[1] == "Count" || SArray[1] == "count") // Checks whether the second element in array is count or not
                        {
                            MySqlCommand commandB = new MySqlCommand(name1, connection);
                            Object OBJ = commandB.ExecuteScalar(); // Using ExecuteScalar method
                            listBox1.Items.Add(OBJ); // Printing OBJ onto list box
                        }
                        else
                        {
                            MySqlCommand commandC = new MySqlCommand(name1, connection);
                            MySqlDataReader reader = commandC.ExecuteReader();
                            while (reader.Read())
                            {
                                ReadSingleRow((IDataRecord)reader); // Calling ReadSingleRow
                            }
                            reader.Close();
                        }
                    }
                    else if (SArray[0] == "Insert" || SArray[0] == "insert") // Checks whether the first element in array is insert or not
                    {
                        MySqlCommand commandA = new MySqlCommand(name1, connection);
                        commandA.ExecuteNonQuery(); // Usinf ExecuteNonQuery method
                        listBox1.Items.Add("Done"); // Printing done ont the lisT box
                    }
                    else
                        listBox1.Items.Add("Other SQL commands are not yet implemented"); // Printing a message onto list box
                }
            }
            catch(MySqlException error) // Catch block to handle exception
            {
                listBox1.Items.Add("Error: " + error.Message);
            }
        }
        private void ReadSingleRow(IDataRecord record) // ReadSingleRow method
        {
            int K;
            String line = "";
            for (K = 0; K < record.FieldCount; K++)
            {
                if (String.IsNullOrEmpty(record[K].ToString())) // Checks whether the string obtained is null or an empty string 
                {
                    line += "null";
                    line += "\t";
                }
                else
                {
                    line += String.Format("{0}", record[K]);
                    line += "\t";
                }
            }
            listBox1.Items.Add(line); // Printing on the list box
        }// end of ReadSingleRow

        private void clear_Click(object sender, EventArgs e) //  Event Handler for clear button
        {
            bool clearAllwasclicked = true;
            if (clearAllwasclicked) // Checks whether clear button is clicked or not
            {
                textBox1.Clear(); // Clearing textBox1
                listBox1.Items.Clear(); // Clearing listBox1
            }
        }
        private void exit_Click(object sender, EventArgs e) //  Event Handler for exit button
        {
            Application.Exit(); // The application exits on executing this command
        }

        private void execute_Click_1(object sender, EventArgs e)
        {

        }
    }
}
