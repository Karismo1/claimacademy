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
        }
    }
}
