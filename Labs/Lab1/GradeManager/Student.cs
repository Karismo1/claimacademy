using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    public class Student
    {
        public string FirstName { get; set; } //Private field names should start with underscore (_)
        public string LastName { get; set; }

        public double Average { get; set; }
        public List<int> Grades = new List<int>();  //For lists, see: https://www.tutorialsteacher.com/csharp/csharp-list or https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0

        // Constructors: See Constructor section in Week1 code for more info

        public Student()
        {
            // Default constructor - No arguments/parameters and no code
        }

        public Student(string firstName, string lastName)
        {
            //Parameterized constructor, accepts arguments as parameters (in this case, 2 strings are being accepted as arguments)

            FirstName = firstName; //Set the private field via the parameter passed into public constructor
            LastName = lastName;
        }

        // Getters and setters
        // Setter methods can be void as no return value is needed.
        // We will not use the static keyword on these methods as we are not using these methods inside of the Student class, but rather outside of the class when a Student object is created with the new keyword.
        // See Week1 powerpoint and code on Classes
        public void setFirstName(string firstName) //Parameter for set, because we are passing this data into the method 
        {
            FirstName = firstName;
        }

        public string getFirstName() // Return private _firstName value via public accessor method. Return type "string" needed here as we are returning the string value in _firstName.
        {                            // No parameters here because we are instead returning data from the method rather than passing data into the method.
            return FirstName; // return statement sends this data out of the method when the method is called. Typically you can assign to a string variable this method call like you would a value.
        }                      // i,e. from GradeManager: string firstName = studentname.getFirstName(), same like string FirstName = "First Name"

        public void setLastName(string lastName)
        {
            LastName = lastName;
        }

        public string getLastName()
        {
            return LastName;
        }

        public void AddGrade(int grade) //Void method as list's built-in Add method doesnt require a new list to be returned
        {
            Grades.Add(grade);
        }

        public List<int> GetGrades()
        {
            return Grades;
        }

        public double GetAverage()
        {
            double average = 0; //Default average to 0
            double totalPoints = 0; // To keep track of total grade points to compute the average

            foreach (int grade in Grades) //See ForEach in Week1 code
            {
                totalPoints += grade; // Add up all the student points for the student. This is the same as totalPoints = totalPoints + grade;
            }

            // Compute the average
            int gradeCount = Grades.Count; // Gets the number of grades in the _grades List, assign it to an int variable called "gradeCount"

            average = totalPoints / gradeCount; // Calculate the average by dividing total points by the number of grades.

            return average;

        }

    }

}
