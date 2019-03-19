/*
 CSCI 680                   ASSIGNMENT 1
 NAME: PRASHANTH KADAGANCHI
 ZID: Z1829989
 DUE DATE: 02/02/2018
 */
using System;
using System.IO;

namespace Assign1
{
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
    static class Program // Program class
    {
        public static Person[] arr = new Person[20]; // new array named arr is created of 20 Person instances
        public static int InUse = 0; 
        static public void read() // read method to get data from a file
        {
            String name1;
            String off_num1;
            String tel_num1;
            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory()+"\\data1.txt")) // StreamReader is used to read data from a text file
            {
                name1 = r.ReadLine(); // The texted content from keyboard is stored in name1
                while (name1  != null) // while loop to test a condition and execute the inner statements till the condition fails
                {

                    off_num1 = r.ReadLine();
                    tel_num1 = r.ReadLine();
                    Console.WriteLine(tel_num1);
                    if (InUse < 20)//checking for the size of array
                    {
                        arr[InUse] = new Person(name1, off_num1, tel_num1);//creating new object
                        InUse++;
                    }
                    name1 = r.ReadLine();
                }
            }
        }
        public static void Main(string[] args) // Main method
        {
            Program.read();//calls the read method
            Char s;
            int num = 0;
            while (num == 0)//checking for condition
            {                                    //printing a menu based on the question
                Console.WriteLine("A. Print the List.");
                Console.WriteLine("B. Add an entry.");
                Console.WriteLine("C. Search for a Name.");
                Console.WriteLine("D. Search for an Office Number.");
                Console.WriteLine("E. Search for a Telephone Number.");
                Console.WriteLine("F. Change an Office Number.");
                Console.WriteLine("G.Sort the List.");
                Console.WriteLine("H.Quit.");
                Console.WriteLine(arr[0].Name);
                Console.WriteLine(InUse);
                s = Convert.ToChar(Console.ReadLine()); // User types a choice of his own to perform an action
               
                switch (s) // Switch case
                {
                    case 'A':
                    case 'a': // Printing the array
                        for (int i = 0; i < InUse; i++)
                        {
                            Console.WriteLine((arr[i].Name).PadRight(20) + (arr[i].Off_num).PadRight(20) + (arr[i].Tel_num).PadRight(20));
                        }
                            break; // break statement
                    case 'B':
                    case 'b': Console.WriteLine("Enter the name"); // Adding an entry
                        String name2 = Console.ReadLine();
                        Console.WriteLine("Enter the office number");
                        String off_num2 = Console.ReadLine();
                        Console.WriteLine("Enter the telephone number");
                        String tel_num2 = Console.ReadLine();
                        bool val = false;
                        for(int i=0;i < InUse;i++)
                        {
                            if ((arr[i].Name).Equals(name2))
                            {
                                Console.WriteLine("Error: Already Exists");
                                val = true;
                            }
                        }
                        if (val == false)
                        {
                            arr[InUse] = new Person(name2, off_num2, tel_num2);
                            Console.WriteLine("Done");
                        }
                        break;
                    case 'c':
                    case 'C': Console.WriteLine("Enter the name");// Searching for a name
                              String input = Console.ReadLine();
                              bool result = false;
                           //   int k = 0;
                        for(int i=0;i < InUse;i++)
                        {
                            if ((arr[i].Name).Equals(input))
                            {
                                Console.WriteLine("The name is {0}, office number is {1} and telephone number is {2}", input, arr[i].Off_num, arr[i].Tel_num);
                                result = true;
                                break;
                            }
                        }
                        if (result == false)
                            Console.WriteLine("The name doesn't exists");
                        break;
                    case 'd':
                    case 'D': Console.WriteLine("Enter the name"); // Searching for office number
                              input = Console.ReadLine();
                               result   = false;
                        //int k = 0;
                        for(int i=0;i < InUse;i++)
                        {
                            if ((arr[i].Off_num).Equals(input))
                            {
                                Console.WriteLine("The name is {0}, office number is {1} and telephone number is {2}", arr[i].Name, input, arr[i].Tel_num);
                                result = true;
                            }
                        }
                        if (result == false)
                            Console.WriteLine("The office number doesn't exists");
                        break;
                    case 'e':
                    case 'E': Console.WriteLine("Enter the name"); // Searching for a telephone number
                              input = Console.ReadLine();
                            result= false;
                        for (int i=0; i < InUse;i++)
                        {
                            if ((arr[i].Tel_num).Equals(input))
                            {
                                Console.WriteLine("The name is {0}, office number is {1} and telephone number is {2}", arr[i].Name, arr[i].Off_num, input);
                                result = true;
                            }
                        }
                        if (result == false)
                            Console.WriteLine("The telephone number doesn't exists");
                        break;
                    case 'f':
                    case 'F': val = false; // Changing an office number
                        Console.WriteLine("Enter the name");
                        name2 = Console.ReadLine();
                        Console.WriteLine("Enter the office number");
                        off_num2 = Console.ReadLine();
                //        int k = 0;
                        for (int i=0; i < InUse;i++)
                        {
                            if ((arr[i].Name).Equals(name2))
                            {
                                arr[i].Off_num = off_num2;
                                Console.WriteLine("Done");
                                val = true;
                            }
                        }
                        if (val == false)
                            Console.WriteLine("No such information found");
                        break;
                    case 'G':
                    case 'g': Array.Sort(arr, 0, InUse); //Sorting the list
                        Console.WriteLine("Array in sorted order: ");
                        //int k = 0;
                        for (int i=0;i < InUse;i++)
                            Console.WriteLine((arr[i].Name).PadRight(20) + (arr[i].Off_num).PadRight(20) + (arr[i].Tel_num).PadRight(20));
                        break;
                    case 'h':
                    case 'H': Console.WriteLine("Quit"); //Quit
                        num = 1;
                        break;
                    default: Console.WriteLine("That was not a choice"); // Default case
                        break;
                }
            }
            Console.WriteLine("Press Enter To Exit");
            Console.ReadLine();
        }
    }
}