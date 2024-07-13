using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    public class GradeManager
    {
        private static readonly string applicationName = "Grade Manager";//Declare application name as a string, make global and readonly as this value will not change
        private static bool exit = false; // create a boolean(True/false value)
        public static void Main(string[] args)
        {
            string applicationName = "Grade Manager";//Declare the name of application as a string

            Console.WriteLine(applicationName);//print application on first line
            Console.WriteLine(new String('-', applicationName.Length));
            Console.WriteLine('\n');//Create 2 blank line to start menu. WriteLine method call does the first blank line, \n prints the second

            //Create some students

            Student student1 = new Student("Tavish", "Misra");
            Student student2 = new Student("Jibreel", "Muhammad");
            Student student3 = new Student("Hassan", "Fofana");
            Student student4 = new Student("Jarvis", "Potter");
            Student student1 = new Student("Greg", "Leeker");


            while (!exit) // Keep menu running after each choice untill application is exited. !exit checks for false (! is not operator, checks for opposite of what the current boolean
            {
                menu();
            }
            
        }
        private static void menu() 
        {
            Console.WriteLine("1. Print all student grades.");
            Console.WriteLine("2. Add student grade.");
            Console.WriteLine("3. Calculate Class Average.");
            Console.WriteLine("4. Print highest Grade.");
            Console.WriteLine("5. Print lowest grade.");
            Console.WriteLine("6. Delete student grade.");
            Console.WriteLine("7. Delete student grade.");
            Console.WriteLine("8. Exit.");
            Console.WriteLine("\n");//Line Break
            Console.Write("Enter a choice: ");//See user input from week 1

            string choiceInput = Console.ReadLine();//Keyboard input is always a string
            int choice = int.Parse(choiceInput);//We use int's (Integers) Parse method to convert the string into an integer

            switch (choice)
            {
                case 1:
                    PrintStudentGrade(); //Call PrintStudentGrades method for 1rst choice.
                    break;//Each case must end with break statement, otherwise all cases will execute
                case 2:
                    AddStudentGrade();
                    break;
                case 3:
                    CalculateClassAverage();
                    break;
                case 4:
                    PrintHighestGrade();
                    break;
                case 5:
                    PrintLowestGrade();
                    break;
                case 6:
                    DeleteStudent();
                    break;
                case 7:
                    EditStudentGrade();
                    break;
                case 8:
                    Exit();
                    break;
                default://execute default case, if choice does not match any of the cases. We add no code and just break statement which will end the switch block.
                    break;
            }
        }

        private static void PrintStudentGrade()
        {
            Console.WriteLine("PrintStudentGrade is called");
        }

        private static void AddStudentGrade()
        {
            Console.WriteLine("AddStudentGrade is called");
        }

        private static void CalculateClassAverage()
        {
            Console.WriteLine("CalculateClassAverage is called");
        }

        private static void PrintHighestGrade()
        {
            Console.WriteLine("PrintHighestGrade is called");
        }

        private static void PrintLowestGrade()
        {
            Console.WriteLine("PrintLowestGrade is called");
        }

        private static void DeleteStudent()
        {
            Console.WriteLine("DeleteStudent is called");
        }

        private static void EditStudentGrade()
        {
            Console.WriteLine("EditStudentGrade is called");
        }

        private static void Exit()
        {
            Console.WriteLine("Good Bye!");
            Console.ReadKey();
            exit = true; //Set exit to true so application will exit.
        }
    }
}
