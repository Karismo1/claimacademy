using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week2
{
    internal class Week2
    {
        public static void Main(string[] args)
        {
            ////String builder demo

            ////Create a string builder
            //Console.WriteLine("Creating string builder");

            //StringBuilder sb = new StringBuilder();

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

            //Console.WriteLine("Generate Medical Records");
            //var random = new Random();//Create a random Number generator


            //for (int i = 0; i < 10000;i++)
            //{
            //    var code = random.Next(1000, 9999);//Create a new random 4-digit number
            //    sb.AppendLine($"Patient number {i}; FirstName-{i}\tLastName-{i}\tMedical Code: {code}");
            //}

            //Console.WriteLine("Save");
            //var contents = sb.ToString();//Turns our 10000 records into a string
            //File.WriteAllText("C:\\Users\\hfofa\\Documents\\MedicalRecords.txt", contents); //Write contents to a txt file
            //Console.WriteLine("Done!");

            //Date Times

            //DateTime is a C# Class, giving us DateTime functionality. A DateTime is simply MM/dd/yyyy HH:mm:ss
            //DateTimes are unique to the second

            //Current DateTime can be obtained by calling DateTime.Now

            //var now = DateTime.Now; // Capture current datetime to variable. DateTime will be whatever it was when it was assigned

            //Console.WriteLine(now);

            //Print the current datetime each second

            //while (true)// call infinite loop to keep going
            //{
            //    Console.WriteLine(DateTime.Now);
            //    Thread.Sleep(1000);//Pause execution for 1000ms or 1s
            //}

            //var dt1 = new DateTime(2024, 07, 23);//Create a datetine object for 7/23/2024 12:00 AM
            //Console.WriteLine($"DateTime dt1 is {dt1}");
            //var dt2 = new DateTime(2024, 08, 01, 09, 00, 00);//Create a DateTime object for 8/1/2024 9:00 AM
            //Console.WriteLine($"DateTime dt2 is {dt2}");
            //var dt3 = new DateTime(2024, 08, 15, 15, 30, 00);//08/15/2024 3:30 PM
            //Console.WriteLine($"DateTime dt3 is {dt3}");

            //Console.WriteLine("Adding 1 day to dt1");
            //dt1 = dt1.AddDays(1); //Add 1 Day to the dt1 DateTime and reassign to dt1
            //                      //AddDaysis not a void method, it returns a new datetime so it must be reassigned to dt1 for the new datetime
            //Console.WriteLine($"DateTime dt1 is now {dt1}");

            //Console.WriteLine("Adding 1 month to dt2");
            //dt2 = dt2.AddMonths(1);
            //Console.WriteLine($"new dt2 {dt2}");

            //Console.WriteLine("Adding 1 Hour to dt3");
            //dt3 = dt3.AddHours(1);
            //Console.WriteLine($"new dt3 {dt3}");

            ////Computing a difference between DateTimes
            //var dtdiff = dt3 - dt1;
            //Console.WriteLine($"The time span between {dt3} and {dt1} is {dtdiff.TotalDays} day.");

            //Enum

            //Console.WriteLine("Enums");
            //Console.WriteLine($"Male is {Gender.Male}");
            //Console.WriteLine($"Female is {Gender.Female}");

            //// Guid - A unique identifier generated randomly by Windows. Guid is microsoft and windows specific
            ////Generally known else as UUID (Unique Universal Identifier) GUID is global Unique Identifier

            //var guid = Guid.NewGuid();
            //Console.WriteLine($"New GUID is {guid}");

            // Tuples - Tuples are groups of 2 or 3 data values that you can put in a variable

            //Tuple<int, string> t1 = new Tuple<int, string>(1, "Joe");

            //Console.WriteLine($"ID is {t1.Item1} and Name is {t1.Item2}");

            //Declare multiple ints

            //int a, b, c, d, e, f;//6 ints
                                 //Same as
                                 //int a;//Declarationn
                                 //int b;
                                 //int c;
                                 //int d;
                                 //int e;
                                 //int f;
                                 //You can assign all of these on one statement, but can only assign a single variable

            //a = b = c = d = e = f = 1;//6 ints all equal 1
                                      //Same as
                                      //int a = 1; //Asignment
                                      //int b = 1;
                                      //int c = 1;
                                      //int d = 1;
                                      //int e = 1;
                                      //int f = 1;
                                      //However, if the 6 ints need to be seperate values, then this must be done on seperate statements
            int g = 1;
            int h = 2;
            int i = 3;
            int j = 4;
            int k = 5;
            int l = 6;

            //Operators
            //Addition
            double a = 7;
            double b = 1.5;
            double c = a + b;//we are adding the 7 in a with the 1.5 in b --> 7

            a += 2.5; // this is the same as doing a a=a + 2.5. We are adding 2.5 to the value currently in a, which is 7 --> 7 + 2.5 = 9.5
                      // We then replace the value of 7 in a with the new 9.5 value we got from adding, and replace it by assigning it

            // Subtraction
            // a and b are already declared above, but we will reset them to 7 and 1.5 by assigning these back to a and b

            a = 7;
            b = 1.5;

            // c is also declared above so we will just do the subtraction without declaring c again

            c = a - b; // We are subtracting b (1.5) from a (7) --> - 1.5 = 5.5 is then being assigned to c

            a -= 2.5; // this is the same as a = a - 2.5. We are subtracting  

            //Multiplication

            // We are changing the values of a and b to 7 and 3 respectfully
            a = 7;
            b = 3;

            c = a * b;//We are multiplying a (7) by b(3) --> 7 * 3 = 21
                      // 21 is the being assigned back to c (c=21)

            a *= 3;//This is the same as a = a * 3. We are multiplying a (7) times 3 --> 7 * 3 = 21
                   //We are then replacing the old value of a (7) by assigning the new computed value of 21 back to a (a = 21)

            // Division 

            // We will assign the values of a and b to 7 and 2 respectively

            a = 7;
            b = 2;
            c = a / b; // We will then divide a and b and assign the result to c 7/2 = 3
                       //Since a and b are both ints, c will also be an int and so will be a whole #
                       // 7/2 is supposed to be 3.5, but it does not round up to 4. The int is whatever
                       //The whole number portion of the result would be, in this case with 3.5, it will be 3
                       //To get the appropriate result of 3.5 when when dividing 7 by 2, one or both of a or b must be a double
                       // i.e int a = 7 double a = 7; int b = 2 OR double a = 7; double b = 2
                       //Modulus
                       //The Modulus operator (%) will give the remainder of a division operation
                       // i.e 7 % 2 = 1 because dividing 7 by 2, we would have 3 remainder 1. (long division)


            //Modulus demo

            // We can use modulus to determine even or odd numbers
            //If a number is even, it has a modulus of 0 because dividing an even number by 2 always results in a remainder of 0
            // If a number is odd, it has a modulus of 1 because diving an odd number by 2 will always results in a remainder of 1

            //bool isEven = false;
            //bool isOdd = false;//Set isEven and isOdd to false by default because modulus should prove a number to be odd or even
            //                   // Proving the odd or even with the modulus check would then make it true

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in numbers)
            {
                if (number % 2 == 0)// If the number divided by 2 results in remainder 0, the number is even
                {
                    Console.WriteLine($"The number {number} is even");
                }
                else //If the number divided by 2 is not 0, it is odd. The modulus of a number and 2 can only be 0 or 1
                {
                    Console.WriteLine($"The number {number} is odd";
                }
            }

            


            Console.Read();//Leave console window open
        }
    }
}
