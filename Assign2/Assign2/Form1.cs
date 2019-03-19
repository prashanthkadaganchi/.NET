/*
 CSCI 680                   ASSIGNMENT 2
 NAME: PRASHANTH KADAGANCHI
 ZID: Z1829989
 DUE DATE: 02/16/2018
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
using System.IO;

namespace Assign2
{
    public partial class Form1 : Form // A partial class named Form1 which is subclass of Form
    {
        public static List<Person> list = new List<Person>(); // Creating a list of type Person
        public Form1() 
        {
            InitializeComponent();
            read(); // calling read method
            this.printList.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged); // All the buttons are being attached to the event handler named RadioButtons_CheckedChanged
            this.addEntry.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            this.searchName.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            this.searchOff_Num.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            this.searchTel_Num.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            this.changeOff_Num.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            this.sortList.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            this.quit.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
        }

        public static void read() // read method to load all the contents form the file into a list
        {
            String name1;
            String off_num1;
            String tel_num1;
            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + "\\data1.txt")) // StreamReader is used to read data from a text file
            {
                name1 = r.ReadLine(); // The texted content from keyboard is stored in name1
                while (name1 != null) // while loop to test a condition and execute the inner statements till the condition fails
                {

                    off_num1 = r.ReadLine();
                    tel_num1 = r.ReadLine();
                    if (list.Count < 20)//checking for the size of array
                    {
                        list.Add(new Person(name1, off_num1, tel_num1));//Adding a Person instance by creating new object and adding it to the list
                    }
                    name1 = r.ReadLine();
                }
            }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e) // Event handler is to do something when a button is clicked
        {
            if (printList.Checked) // Checks whether printList button is clicked or not
            {
                printlist(); // Calling printlist method
                printList.Checked = false; // Assigning the Checked status to false
            }
                
            else if (addEntry.Checked) // Checks whether addEntry button is clicked or not
            {
                addentry(); // Calling addentry method
                addEntry.Checked = false;
            }
                
            else if (searchName.Checked) // Checks whether searchName button is clicked or not
            {
                searchname(); // Calling searchname method
                searchName.Checked = false;
            }
                
            else if (searchOff_Num.Checked) // Checks whether searchOff_Num button is clicked or not
            {
                searchoff_num(); // Calling searchoff_num method
                searchOff_Num.Checked = false;
            }
                
            else if (searchTel_Num.Checked) // Checks whether searchTel_Num button is clicked or not
            {
                searchtel_num(); // Calling searchtel_num method
                searchTel_Num.Checked = false;
            }
                
            else if (changeOff_Num.Checked) // Checks whether changeOff_Num button is clicked or not
            {
                changeoff_num(); // Calling changeoff_num method
                changeOff_Num.Checked = false;
            }
                
            else if (sortList.Checked) // Checks whether sortList button is clicked or not
            {
                sort_list(); // Calling sort_list method
                sortList.Checked = false;
            }
                
            else if (quit.Checked) // Checks whether quit button is clicked or not
            {
                Quit(); // Calling Quit method
            }
        }
        private void clearAll_Click(object sender,EventArgs e) //  Event Handler for clear button
        {
            bool clearAllwasclicked = true;
            if(clearAllwasclicked) // Checks whether clear button is clicked or not
            {
                textBox1.Clear(); // Clearing textBox1
                textBox2.Clear(); // Clearing textBox2
                textBox3.Clear(); // Clearing textBox3
                listBox1.Items.Clear(); // Clearing listBox1
            }
        }
        void printlist() // printlist method
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Name".PadRight(20) + "Office Number".PadRight(20) + "Telephone Number".PadRight(20));
            foreach (Person p in list) 
                listBox1.Items.Add((p.Name).PadRight(20) + (p.Off_num).PadRight(20) + (p.Tel_num).PadRight(20)); // Printing each person entry on listBox1
        }
        void addentry() // addentry method
        {
            listBox1.Items.Clear();
            String name2 = textBox1.Text; // The input given in textBox1 is assigned to name2
            String off_num2 = textBox2.Text; // The input given in textBox2 is assigned to off_num2
            String tel_num2 = textBox3.Text; // The input given in textBox3 is assigned to tel_num2
            bool val = false;
            if (name2 == "" || off_num2 == "" || tel_num2 == "") // Checks whether the text boxes is empty or not
            {
                listBox1.Items.Add("Error: Empty String.");
                return;
            }
            for (int i = 0; i < list.Count; i++) // For loop
            {
                if ((list[i].Name).Equals(name2)) // Checks for the existance of input name in the list 
                {
                    MessageBox.Show("The Name Already Exists.","Error",MessageBoxButtons.OK);
                    val = true;
                }
            }
            if (val == false)
            {
                //add person to list, add success message to output
                list.Add(new Person(name2, off_num2, tel_num2)); // Adding new entry into the list
                listBox1.Items.Add("Entry Added"); // Adding the content into listBox1
            }
        }
        void searchname() // searchname method
        {
            listBox1.Items.Clear();
            String input = textBox1.Text;
            bool result = false;
            if (input == "")
            { 
                listBox1.Items.Add("Error: Empty String.");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i].Name).Equals(input))
                {
                    listBox1.Items.Add("The name is "+input+", office number is "+list[i].Off_num+" and telephone number is "+list[i].Tel_num);
                    result = true;
                }   
            }
            if (result == false)
                MessageBox.Show("The Name Doesn't Exist.", "Error", MessageBoxButtons.OK);
            textBox1.Clear(); // Clears texBox1
        }
        void searchoff_num() // searchoff_num method
        {
            listBox1.Items.Clear();
            String input = textBox2.Text;
            bool result = false;
            if (input == "")
            {
                listBox1.Items.Add("Error: Empty String.");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i].Off_num).Equals(input))
                {
                    listBox1.Items.Add("The name is " + list[i].Name + ", office number is " + input + " and telephone number is " + list[i].Tel_num);
                    result = true;
                }
            }
            if (result == false)
                MessageBox.Show("The Office Number Doesn't Exist.", "Error", MessageBoxButtons.OK);
            textBox2.Clear();
        }
        void searchtel_num() // searchtel_num method
        {
            listBox1.Items.Clear();
            String input = textBox3.Text;
            bool result = false;
            if (input == "")
            {
                listBox1.Items.Add("Error: Empty String.");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i].Tel_num).Equals(input))
                {
                    listBox1.Items.Add("The name is " + list[i].Name+ ", office number is " + list[i].Off_num + " and telephone number is " + input);
                    result = true;
                }
            }
            if (result == false)
                MessageBox.Show("The Telephone Number Doesn't Exist.", "Error", MessageBoxButtons.OK);
            textBox3.Clear();
        }
        void changeoff_num() // changeoff_num method
        {
            listBox1.Items.Clear();
            String name2 = textBox1.Text;
            String off_num2 = textBox2.Text;
            bool val = false;
            if (name2 == ""||off_num2=="")
            {
                listBox1.Items.Add("Error: Empty String.");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i].Name).Equals(name2))
                {
                    list[i].Off_num = off_num2;
                    listBox1.Items.Add("Done");
                    val = true;
                }
            }
            if (val == false)
                MessageBox.Show("No Such Information Found.", "Error", MessageBoxButtons.OK);
            textBox1.Clear();
            textBox2.Clear(); // Clears textBox2
        }
        void sort_list() // sort_list method
        {
            listBox1.Items.Clear();
            list.Sort(); // Sorting the list
            listBox1.Items.Add("Name".PadRight(20) + "Office Number".PadRight(20) + "Telephone Number".PadRight(20));
            for (int i = 0; i < list.Count; i++)
                listBox1.Items.Add((list[i].Name).PadRight(20) + (list[i].Off_num).PadRight(20) + (list[i].Tel_num).PadRight(20));
        }
        void Quit() // Quit method
        {
            Application.Exit(); // Exiting the application
        }
    }
    public class Person : IComparable // Here Person class implements IComparable interface
    {
        private String name, off_num, tel_num; // Declaring variables of string type and is private
        public String Name // Name method
        {
            get { return name; } //Get property
            set { name = value; } // Set property
        }
        public String Off_num // Off_num method
        {
            get { return off_num; }
            set { off_num = value; }
        }
        public String Tel_num // Tel_num method
        {
            get { return tel_num; }
            set { tel_num = value; }
        }
        public Person(String name, String off_num, String tel_num) // Constructor for Person class
        {
            this.name = name;
            this.off_num = off_num;
            this.tel_num = tel_num;
        }
        public int CompareTo(object OBJ) // CompareTo method
        {
            Person person = (Person)OBJ;
            if ((this.name).Equals(person.name))
                return 0;
            else if (((this.name).CompareTo(person.name)) > 0)
                return 1;
            else return -1;
        }
    }       
}
