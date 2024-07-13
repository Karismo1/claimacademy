using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    public class Student
    {
        private string _firstName {  get; set; } // private field names should start with underscore for good practice
        private string _lastName { get; set; }

        // Constructors: See Constructorsection in week1 code for more info
        public Student()
        {
            //Default constructor  - No arguments/parameters and no code
        }

        public Student(string firstName, string lastName) //parametered constructor, accepts arguments as parameters(in this case, 2 strings are being accepted
        {
            _firstName = firstName; //Set the private field via the parameter passed into public constructor
            _lastName = lastName;
        }

        //Getters and setters
        //Setter
        public void setFirstName(string firstName)//Settoer can be
        {
            _firstName = firstName;
        }

        public string getFirstName()
        {
            return _firstName;
        }

        public void setLastName(string lastName)
        {
            _lastName = lastName;
        }

        public string getLastName()
        {
            return _lastName;
        }

    }
}
