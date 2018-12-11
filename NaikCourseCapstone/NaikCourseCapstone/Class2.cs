using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaikCourseCapstone
{
    class Class2
    {
        // declaring the variables to which the value is passed which is later passed on to the main form to show the result when get button is clicked.
        private static string studentname;
        private static int courseno;
        private static DateTime dateTime;
        private static string type2;
        private static string number;

        // the get method returns the value of Student Name when the get button is pressed.
        public static string gets1()
        {
           
                return studentname;
            
        }
        // the set method sets the value of variable studentname which is received from class1.
        public static void sets1(String stdname)
        {
            string s = studentname; // used to store the previous value of studentname.
            studentname = stdname;
            // checks if the value is changed or not. if the value is chenged displays a message with the new value.
            if (s != studentname)
            {
                System.Windows.Forms.MessageBox.Show("The value of Student Name has been changed to " + studentname);
            }
        }
        // the get method returns the value of number of courses taken when the get button is pressed.
        public static int getnocours()
        {
            return courseno;

        }
        // the set method sets the value of variable courseno which is received from class1.
        public static void setsnocours(int course)
        {

            int c = courseno; // used to store the previous value of courseno.
            courseno = course;
            // checks if the value is changed or not. if the value is chenged displays a message with the new value.
            if (c != courseno)
            {
                System.Windows.Forms.MessageBox.Show("The value of course Number has been changed to " + courseno);
            }
        }
        // the get method returns the value of Start date when the get button is pressed.
        public static DateTime getdate()
        {
            return dateTime;

        }
        // the set method sets the value of variable dateTime which is received from class1.
        public static void setdate(DateTime dtTime)
        {
            DateTime d = dateTime; // used to store the previous value of dateTime.
            dateTime = dtTime;
            // checks if the value is changed or not. if the value is chenged displays a message with the new value.
            if ( d != dateTime)
            {
                System.Windows.Forms.MessageBox.Show("The value of course strat date has been changed to " + dateTime);
            }
        }
        // the get method returns the value of Type of class when the get button is pressed.
        public static string gettype()
        {
            return type2;

        }
        // the set method sets the value of variable type2 which is received from class1.
        public static void settype(string Type)
        {
            string t = type2; // used to store the previous value of string type 2
            type2 = Type;
            // checks if the value is changed or not. if the value is changed it displays a message with the new value 
             if (t != type2)
            {
                System.Windows.Forms.MessageBox.Show("The value of Course type has been changed to " + type2 );
            }

        }
        // the get method returns the value of Course Number when the get button is pressed.
        public static string getNum()
        {
            return number;

        }
        // the set method sets the value of variable t which is received from class1.
        public static void setNum(string Num)
        {
            string t = number; // used to store the previous value of string type 2
            number = Num;
            // checks if the value is changed or not. if the value is changed it displays a message with the new value 
            if (t != number)
            {
                System.Windows.Forms.MessageBox.Show("The value of Course Number has been changed to " + number);
            }

        }

    }
}
