using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaikCourseCapstone
{
    public static class Class1
    {
        // declaring the variables to which the value is passed which is collected from main form and same are used to pass values to class2.
        private static string studname;
        private static int nocourse;
        private static DateTime dateTime;
        private static string type;
        private static string No;


        // this get method is used to get the student name from the set method of class 1 and pass the value to set method in class2.
        public static void gets1()
        {
            try // throws exception if any
            {
                Class2.sets1(studname); // passes the value of student name to the set method of class2.
            }
            catch (Exception) // catches the exception and asks user to enter valid data.
            {
                System.Windows.Forms.MessageBox.Show("Enter proper data in the text box.");
            }
        }
        // this method is used to get the value of student name from  the text box and set the value of variable studname.
        public static void  sets1(String sname)
        {
            try // throws exception if any
            {
                studname = sname;
                gets1(); // calling the get method.
            }
            catch (Exception) // catches the exception and asks user to enter valid data.
            {
                System.Windows.Forms.MessageBox.Show("Enter proper data in the text box.");
            }
        }
        // this get method is used to get the number of courses taken from the set method of class 1 and pass the value to set method in class2.
        public static void getnocours()
        {
            try // throws exception if any
            {
                Class2.setsnocours(nocourse); // passes the value of number of courses taken to the set method of class2.
            }
            catch (Exception) // catches the exception and asks user to enter valid data
            {
                System.Windows.Forms.MessageBox.Show("Enter proper data in the text box");
            }

        }
        // this method is used to get the value of number of courses taken from the text box and set the value of variable nocourse.
        public static void setsnocours(int course)
        {
            try // throws exception if any
            {
                nocourse = course;
                getnocours(); //calling the get method in class 1
            }
            catch (Exception) // catches the exception and asks user to enter valid data
            {
                System.Windows.Forms.MessageBox.Show("Enter proper data in the text box");
            }
        }
        // this get method is used to get the start date from the set method of class 1 and pass the value to set method in class2.
        public static void getdate()
        {
            try // throws exception if any
            {
                Class2.setdate(dateTime); //passes the value of date and time to the set method of class2.
            }
            catch(Exception) // catches the exception and asks user to enter valid data
            {
                System.Windows.Forms.MessageBox.Show("Enter proper data in the text box");
            }

        }
        // this method is used to get the value of course start date from  the text box and set the value of variable dateTime.
        public static void setdate(DateTime dtTime)
        {
            try // throws exception if any
            {
                dateTime = dtTime;
                getdate(); // calls the get method of class 1
            }
            catch(Exception) // catches the exception and asks user to enter valid data
            {
                System.Windows.Forms.MessageBox.Show("Enter Proper data in the text box");
            }
        }
        // this get method is used to get the type of class from the set method of class 1 and pass the value to set method in class2.
        public static void gettype()
        {
            try // throws exception if any
            {
                Class2.settype(type); // passes the value of class type to set method of class2.
            }
            catch(Exception) // catches the exception and asks user to enter valid data
            {
                System.Windows.Forms.MessageBox.Show("Enter proper data in the text box");
            }
        }
        // this method is used to get the value of Type of class from  the text box and set the value of variable type.
        public static void settype(string Type)
        {
            try // throws exception if any
            {
                type = Type;
                gettype(); // calls the get method of class 1.
            }
            catch(Exception) // catches the exception and asks user to enter valid data
            {
                System.Windows.Forms.MessageBox.Show("Enter Proper data in the text box.");
            }
        }
        // this get method is used to get the course number from the set method of class 1 and pass the value to set method in class2.
        public static void getNumber()
        {
            try // throws exception if any
            {
                Class2.setNum(No); // passes the value of course number to set method of class2.
            }
            catch (Exception) // catches the exception and asks user to enter valid data
            {
                System.Windows.Forms.MessageBox.Show("Enter proper data in the text box");
            }
        }
        // this method is used to get the value of Course Number from  the combo box and set the value of variable Number.
        public static void setNumber(string Number)
        {
            try // throws exception if any
            {
                No = Number;
                getNumber(); // calls the get method of class 1.
            }
            catch (Exception) // catches the exception and asks user to enter valid data
            {
                System.Windows.Forms.MessageBox.Show("Enter Proper data in the text box.");
            }
        }
    }
}
