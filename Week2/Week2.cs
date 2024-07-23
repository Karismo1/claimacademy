using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Week2
    {
        public static void Main(string[] args)
        {
            ////String builder demo

            ////Create a string builder
            Console.WriteLine("Creating string builder");

            StringBuilder sb = new StringBuilder();

            //sb.Append("HelloWorld ");// Appends a string without a new line character
            //sb.AppendLine("Hello World with new line character"); //Appends a string with a new line, i.e typing somthing and pressing enter
            //sb.Append("New line starts");
            ////To convert the string builder object (which is just amemory object to hold the string) to an acual string, we call the ToString method

            //string sbText = sb.ToString();

            ////Every object in C# has a 2 string method because the parent class of every C# class is Object. And object has a 2 string method

            //// After converting the stringBuilder to a string, we will print watever text with one call to Console.Write

            //Console.WriteLine(sbText);

            //Writing multiple records to a file, each line in a file is a record, each piece of data in the record
            //is seperated by a "delimiter", a character which seperates each piece of data in the record
            //Delimiters can be commas, pipes (|), tabs (   ) represented by \t in C# code

            //We are writing 10000 patients to a file

            Console.WriteLine("Generate Medical Records");
            var random = new Random();//Create a random Number generator


            for (int i = 0; i < 10000;i++)
            {
                var code = random.Next(1000, 9999);//Create a new random 4-digit number
                sb.AppendLine($"Patient number {i}; FirstName-{i}\tLastName-{i}\tMedical Code: {code}");
            }

            Console.WriteLine("Save");
            var contents = sb.ToString();//Turns our 10000 records into a string
            File.WriteAllText("C:\\Users\\hfofa\\Documents\\MedicalRecords.txt", contents); //Write contents to a txt file
            Console.WriteLine("Done!");

            Console.Read();//Leave console window open
        }
    }
}
