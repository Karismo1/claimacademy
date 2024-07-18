using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

            //Create some students/ Refactoring to list (change)

            var students = new List<Student>() //
            {
                new Student("Tavish", "Misra"), // Student 0 (student number as an index in the list
                new Student("Jibreel", "Muhammad"), // Student 1
                new Student("Hassan", "Fofana"), // Student 2
                new Student("Jarvis", "Potter"), // Student 3
                new Student("Greg", "Leeker") // Student 4

            };// Create list of students and instantiate (create) the students from the start
              //We call the new keyword on each student object in the list because each student object must be created

            while (!exit) // Keep menu running after each choice untill application is exited. !exit checks for false (! is not operator, checks for opposite of what the current boolean
            {
                menu(students);
            }
            
        }
        private static void menu(List<Student> students) 
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
                    PrintStudentGrade(students); //Call PrintStudentGrades method for 1rst choice.
                    break;//Each case must end with break statement, otherwise all cases will execute
                case 2:
                    AddStudentGrade(students);
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

        private static void PrintStudentGrade(List<Student> students)
        {
            string header = "Student Name        Grade";
            Console.WriteLine(header);
            Console.WriteLine(new string('-', header.Length));// Create a new string of dashes

            if (students != null && students.Count > 0) // || means "or". && means "and"
            {
                //Print the student grades+
                foreach (var student in students)
                {
                    var studentFirstName = student.getFirstName();// Get first name
                    var studentLastName = student.getLastName();//Get last name
                    var studentGradeList = student.GetGrades();//Get the student grade list

                    //Print the grades as is they exist, if not say no grades
                    Console.WriteLine(string.Empty);

                    if (studentGradeList != null && studentGradeList.Count > 0) 
                    {
                        foreach (var grade in studentGradeList)
                        {
                            Console.WriteLine($"{studentFirstName} {studentLastName}        {grade}");
                        }
                    }

                    else 
                    {
                        Console.WriteLine($"{studentFirstName} {studentLastName}        No Grade");
                    }
             
                }
            }

            else 
            {
                Console.WriteLine("There are no students");
            }
            
            
        }

        private static void AddStudentGrade(List<Student> students)
        {
            //Check for students to add grades for

            if (students != null && students.Count > 0)
            {
                Console.WriteLine("\nWhich student do you want to add a grade for?\n\n");

                int studentListNumber = 1; // to list students

                foreach (var student in students)
                {
                    var studentFirstName = student.getFirstName();
                    var studentLastName = student.getLastName();
                    Console.WriteLine($"{studentListNumber}. {studentFirstName} {studentLastName}");
                    studentListNumber++;//Increase list number by 1 for each student listed
                }

                string studentChoiceInput = Console.ReadLine(); // Waiting for input
                int studentChoice = int.Parse(studentChoiceInput);

                //Add the grade for the student. BAsed on the student choice, we must selct the right

                studentChoice--; //Decrement by 1 for the student list index #

                string studentChoiceFirstName = students[studentChoice].getFirstName();//acess student from list. Format listVariableNAme[indexNumber]
                string studentChoiceLastName = students[studentChoice].getLastName();

                Console.Write($"Entet grade for student {studentChoiceFirstName} {studentChoiceLastName}: ");
                string gradeInput = Console.ReadLine();
                int grade = int.Parse(gradeInput);

                //Add the grade to student gradelist
                students[studentChoice].AddGrade(grade);

            }
            else
            {
                Console.WriteLine("There are no students in the system.");
            }
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
