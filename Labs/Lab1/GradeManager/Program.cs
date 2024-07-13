using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string applicationName = "Grade Manager";//Declare the name of application as a string

            Console.WriteLine(applicationName);//print application on first line
            Console.WriteLine(new String('-', applicationName.Length));
            Console.WriteLine('\n');//Create 2 blank line to start menu. WriteLine method call does the first blank line, \n prints the second
            Console.WriteLine("1. Print all student grades.");
            Console.WriteLine("2. Add student grade.");
            Console.WriteLine("3. Calculate Class Average.");
            Console.WriteLine("4. Print highest Grade.");
            Console.WriteLine("5. Print lowest grade.");
            Console.WriteLine("6. Delete student grade.");
            Console.WriteLine("7. Exit.");
            Console.WriteLine("\n");//Line Break
            Console.Write("Enter a choice: ");//See user input from week 1

            string choiceInput = Console.ReadLine();//Keyboard input is always a string
            int choice = int.Parse(choiceInput);//We ise int's (Integers) Parse method to convert the string into an integer

            switch (choice) 
            {
                case 1:
                    //PrintStudentGrades(); //Call PrintStudentGrades method for 1rst choice.
                    break;//Each case must end with break statement, otherwise all cases will execute
                case 2:
                    //AddStudentGrade();
                    break;
                case 3: 
                    //CalculateClassAverage();
                    break;
                case 4:
                    //PrintHighestGrade();
                    break;
                case 5:
                    //PrintLowestGrade();
                    break;
                case 6:
                    //DeleteStudent();
                    break;
                case 7:
                    //EditStudentGrade();
                default://execute default case
                    break;
            }
        }
    }
}
