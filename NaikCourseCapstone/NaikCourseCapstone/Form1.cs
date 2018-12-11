using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaikCourseCapstone
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet1.CourseNo' table. You can move, or remove it, as needed.
            this.courseNoTableAdapter1.Fill(this.finalDataSet1.CourseNo);
            
        }

       

        public void btnSet_Click(object sender, EventArgs e)
        
        {
            // Storeing the values to variables
            
           DateTime dateTime = Convert.ToDateTime(ClassDate.Text);
            Class1.setdate(dateTime);// passing the value of datetime variable to another variable dtTime of the setdate method in class1.
            // checks if the combo box has null values if it does. throws an error merssage. if not passes the value to the set method in class1.
            if (courseNoComboBox.Text == "")
            {
                MessageBox.Show("course number cannot be blank. please select one value from the list.");

            }
            else
            {
                string courseno = courseNoComboBox.Text;// stores the value of course number in variable courseno.
                Class1.setNumber(courseno);// passes the value of courseno to the set method of class 1.
            }
            // the following code tests the first textbox No. of Course Taken
            // it checks if the text box contains a null value if it does it shows an error message.
            // also it checks if the value entered is integer if not it shows an error.
            if (CrsTaken.Text == "")
            {
                MessageBox.Show("Number of courses taken cannot be blank Enter a number.");
            }
            else
            {
                try
                {
                    int NoOfCourse = int.Parse(CrsTaken.Text, System.Globalization.NumberStyles.None); // parses the string in CrsTaken text box.
                    Class1.setsnocours(NoOfCourse); // passing the value of NoOfCourse variable to another variable course of the setsnocours method in class1.
                }

                catch (Exception)
                {
                    MessageBox.Show("Enter the Number of Courses Taken. Enter the values in form of integer only.");
                    CrsTaken.Clear();// Clears the TextBox CrsTaken

                }
            }
            // the following code tests the Second textbox Student Name
            // it checks if the value entered ends with or starts with a space if it does it shows an error. 
            // Also it checks if there is a space in between the first and last name if it has it passes the value to class1 else it will throw and error.
            // Also it checks if the text box is blank or not if it is blank it throws an error message.
            string StudentName = StdName.Text; // storeing of value to variable
            if (StudentName == "")
            {
                MessageBox.Show("Student name cannot be blank. please enter a value.");
            }
            else if (StudentName.EndsWith(" ") || StudentName.StartsWith(" ")) // the code checks if the string starts with or ends with a Blank
            {
                MessageBox.Show("Student Name Cannot Start or End with a Space");
                StdName.Clear();

            }
            else if (StudentName.Contains(" ")) // checks if there is space in between first and last name.
            {
                Class1.sets1(StudentName); // passing the value of StudentName variable to another variable sname of the sets1 method in class1.
            }
            else
            {
                MessageBox.Show("There should be a space between First name and Last name");
                StdName.Clear();
            }
            
            // code that checks for the radio button that is selected and passes the values to class1.
            if (radioOnline.Checked == true)
            {
                string type = "Online";
                Class1.settype(type); // passing the value of type variable to another variable Type of the settype method in class1. 

            }

            else
            {
                radioHybrid.Checked = true;
                string type1 = "Hybrid";
                Class1.settype(type1); // passing the value of type variable to another variable Type of the settype method in class1.
            }
           
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();// to exit the application.
        }

        private void btnGet_Click(object sender, EventArgs e)
       
        {
            try // throws exception if any
            {
                // the following code gets the value of student neame from class2 and passes the value to variable content and the variable passes the value to textbox to display the name. 
                string content = Class2.gets1();
                StudentName.Text = content;
                // the following code gets the value of number of course taken from class2 and passes the value to variable courseno and the variable passes the value to textbox to display the no of course taken.
                int courseno = Class2.getnocours();
                CourseTaken.Text = Convert.ToString(courseno);
                // the following code gets the value of class start date from class2 and passes the value to variable cdttime and the variable passes the value to textbox to display the Start Date
                DateTime dttime = Class2.getdate();
                StartDate.Text = Convert.ToString(dttime);
                // the following code gets the value of Type of class from class2 and passes the value to variable type3 and the variable passes the value to textbox to display the type of class.
                string type3 = Class2.gettype();
                ClassType.Text = type3;
                // the following code gets the value of course number from class2 and passes the value to variable num and the variable passes the value to textbox to display the course number.
                string num = Class2.getNum();
                CourseNo.Text = num;
            }
            catch(Exception) // catches the exception and prompts the user to enter data in the required format.
            {
                MessageBox.Show("An exception has occured due to entry of invalid data. enter the value in integer for courseno, enter the name, start date and the course no in proper format.");
            }
        }

        private void courseNoLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}


        
    

